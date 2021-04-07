using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.PhongBans;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.BackendApi.Controllers;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhongBanController : ControllerBase
    {
        private readonly IPublicPhongBanService _publicPhongBanService;
        private readonly IManagerPhongBanService _managerPhongBanService;
        private readonly TLUBusinessFeeDbContext _context;
        public PhongBanController(IPublicPhongBanService publicPhongBanService,
            IManagerPhongBanService managerPhongBanService, TLUBusinessFeeDbContext context)
        {
            _publicPhongBanService = publicPhongBanService;
            _managerPhongBanService = managerPhongBanService;
            _context = context;

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
                RoleID= claims[1].Value
        };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            //var identity = HttpContext.User.Identity as ClaimsIdentity;

            //IList<Claim> claims = identity.Claims.ToList();
            //var RoleId = claims[1].Value;
            //var roleName = from Rn in _context.Role
            //               where Rn.Id == RoleId
            //               select Rn.Name;

            //var data = new UserLoginViewModel
            //{
            //    MaNhanVien = claims[0].Value,
            //    RoleName = roleName.ToList()[0]
            //};
            //if (data.RoleName != "admin")
            //    return BadRequest();
           //var role= post().RoleName;
           // if (role != "admin")
           //     return BadRequest();
            var phongban = await _publicPhongBanService.GetAll();
            return Ok(phongban);
        }
        //
        [HttpGet("{MaPhongBan}")]
        public async Task<IActionResult> getbyID(string MaPhongBan)
        {
            var phongban = await _managerPhongBanService.GetByID(MaPhongBan);
            if (phongban == null)
                return BadRequest("khong the tim thay phong ban");
            return Ok(phongban);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PhongBanCrearteRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01" && role !="RL05")
                return BadRequest();
            var result = await _managerPhongBanService.Create(request);
            if (result == null)
                return BadRequest();
            var PhongBan = await _managerPhongBanService.GetByID(result);
            return Created(nameof(getbyID), PhongBan);
        }
        [HttpPut("{MaPhongBan}")]
        public async Task<IActionResult> Update([FromBody] PhongBanUpdateRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01" && role != "RL05")
                return BadRequest();
            var affecedResult = await _managerPhongBanService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maphongban}")]
        public async Task<IActionResult> Delete(string maphongban)
        {
            var role = post().RoleID;
            if (role != "RL01" && role != "RL05")
                return BadRequest();
            var affecedResult = await _managerPhongBanService.Delete(maphongban);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }

    }
}
