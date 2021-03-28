using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Application.System.Users;
using System.Runtime;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly TLUBusinessFeeDbContext _context;
        public UsersController(IUserService userService, TLUBusinessFeeDbContext context)
        {
            _userService = userService;
            _context = context;
        }
        [HttpGet]
        [Authorize]
        public async Task<UserLoginViewModel> getUserName()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claims = identity.Claims.ToList();
            var RoleId = claims[1].Value;
            var roleName = from Rn in _context.Roles
                           where Rn.Id == RoleId
                           select Rn.Name;

            var data = new UserLoginViewModel
            {
                MaNhanVien = claims[0].Value,
                RoleName = roleName.ToList()[0],
                RoleID=claims[1].Value
            };
            //var query = from NV in _context.NhanVienPhongs
            //            where NV.MaNhanVien == data.MaNhanVien
            //            select NV.TenNhanVien.ToString();
            //return query.FirstOrDefault().ToString();
            return data;
        }


        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var resultt = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultt)) {
                return BadRequest();
            }
            else
            {
                return Ok(resultt);
            }


        }
        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            var result = await _userService.Register(request);
            if (result == false)
            {
                return BadRequest("saii");
            }
            return Ok();
        }
        //[Authorize]
        //[HttpPost("post")]
        //public UserLoginViewModel post()
        //{
        //    var identity = HttpContext.User.Identity as ClaimsIdentity;
        //    IList<Claim> claims= identity.Claims.ToList();
        //    var RoleId =   claims[1].Value;
        //    var roleName =  from Rn in _context.Role
        //                    where Rn.Id == RoleId
        //                   select Rn.Name;

        //    var data = new UserLoginViewModel
        //    {
        //        MaNhanVien = claims[0].Value,
        //        RoleName = roleName.ToList()[0]
        //    };
        //    return data;

        //}

    }
}
