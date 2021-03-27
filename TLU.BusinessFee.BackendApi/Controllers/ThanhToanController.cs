using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ThanhToans;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ThanhToanController : ControllerBase
    {
        private readonly TLUBusinessFeeDbContext _context;
        private readonly IThanhToanManagerService _service;
        public ThanhToanController(TLUBusinessFeeDbContext context, IThanhToanManagerService service)
        {
            _context = context;
            _service = service;
        }
        [HttpHead]
        public UserLoginViewModel post()
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
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var role = post().RoleID;
            if(role!="RL04")
            {
                return BadRequest();
            }
            var ThanhToan = await _service.GetAll();
            return Ok(ThanhToan);
        }
        [HttpPost]
        public async Task<IActionResult> ThanhToan(string MaHoaDon,string MaDeXuat)
        {
            var role = post().RoleID;
            if (role != "RL04")
            {
                return BadRequest();
            }
            var thanhtoan = await _service.ThanhToan(MaHoaDon,MaDeXuat);
            if(thanhtoan ==null)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }
    }
}
