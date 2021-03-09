
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;

namespace TLU.BusinessFee.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly TLUBusinessFeeDbContext _context;
        public UserService(UserManager<User> userManager,SignInManager<User> signInManager, RoleManager<Role> roleManager, IConfiguration config,TLUBusinessFeeDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }
        public  async Task<User> FindByNameAsync(string MaNhanVien)
        {
            var users =  await _context.User.FindAsync(MaNhanVien);
            return users;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            var Users = await _userManager.FindByIdAsync(request.maNhanVien);
            if (Users == null)
            {
                return null;
            }
            var result = await _signInManager.CheckPasswordSignInAsync(Users, request.passWord,request.rememberme);
            if(!result.Succeeded)
            {
                return null;
            }
            var roles = from UR in _context.UserRoles join U in _context.Users on UR.MaNhanVien equals U.MaNhanVien 
                        where UR.MaNhanVien== request.maNhanVien
                        select UR.RoleId;
            var claims = new[]  
            {
                new Claim(ClaimTypes.Name,Users.MaNhanVien),
                new Claim(ClaimTypes.Role,string.Join(";",roles))

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Tokens:Issuer"], _config["Tokens:Issuer"], claims, expires: DateTime.Now.AddHours(3), 
                signingCredentials: creds);

            
            var tokenn=  new JwtSecurityTokenHandler().WriteToken(token);// cái này không được
            return new JwtSecurityTokenHandler().WriteToken(token);// cái này được


        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var nhanvien= await _context.NhanVienPhongs.FindAsync(request.MaNhanVien);
            if(nhanvien==null)
            {
                return false;
            }
            var hasher = new PasswordHasher<User>();
            var User = new User()
            {
                MaNhanVien = request.MaNhanVien,
                PasswordHash= hasher.HashPassword(null, request.PassWord)
            };
            _context.User.Add(User);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
