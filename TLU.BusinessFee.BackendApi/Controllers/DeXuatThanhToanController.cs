using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;
namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DeXuatThanhToanController : ControllerBase
    {
        private readonly IManagerDeXuatThanhToanService _managerDeXuatThanhToanService;
        private readonly TLUBusinessFeeDbContext _context;
        public DeXuatThanhToanController(IManagerDeXuatThanhToanService managerDeXuatThanhToanService
           , TLUBusinessFeeDbContext context)
        {
            _managerDeXuatThanhToanService = managerDeXuatThanhToanService;
            _context = context;

        }
        [HttpHead]
        public UserLoginViewModel post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claims = identity.Claims.ToList();
            var RoleId = claims[1].Value;
            var roleName = from Rn in _context.Role
                           where Rn.Id == RoleId
                           select Rn.Name;

            var data = new UserLoginViewModel
            {
                MaNhanVien = claims[0].Value,
                RoleName = roleName.ToList()[0]
            };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> getByid()
        {
            string MaNhanVien = post().MaNhanVien.ToString();
            var DeXuat = await _managerDeXuatThanhToanService.GetallDeXuat(MaNhanVien);
            return Ok(DeXuat);
        }
    }
}
