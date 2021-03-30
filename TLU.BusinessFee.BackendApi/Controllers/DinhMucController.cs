using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DinhMucController : ControllerBase
    {
        private readonly IManagerDinhMucService _managerChiPhiChucVuService;
        private readonly TLUBusinessFeeDbContext _context;
        public DinhMucController(IManagerDinhMucService managerChiPhiChucVuService, TLUBusinessFeeDbContext context)
        {
            _managerChiPhiChucVuService = managerChiPhiChucVuService;
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
        public async Task<IActionResult> getAll()
        {
            
            var dinhmuc = await _managerChiPhiChucVuService.GetAll();
            return Ok(dinhmuc);
        }
        [HttpGet("getbyChiPhiid/{MaChiPhi}")]
        public async Task<IActionResult> getbyChiPhiID(string MaChiPhi)
        {
            var chiphi = await _managerChiPhiChucVuService.GetByChiPhiID(MaChiPhi);
            if (chiphi == null)
                return BadRequest("khong the tim thay loai chi phi nay");
            return Ok(chiphi);
        }
        [HttpGet("getbyCapBacid/{MaCapBac}")]
        public async Task<IActionResult> getbyCapBacID(string MaCapBac)
        {
            var CapBac = await _managerChiPhiChucVuService.GetByChucVuID(MaCapBac);
            if (CapBac == null)
                return BadRequest("khong the tim thay loai chi phi nay");
            return Ok(CapBac);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateDinhMucRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var affecedResult = await _managerChiPhiChucVuService.Update(request);
                if (affecedResult == 0)
                    return BadRequest();
                return Ok();
            }
            else
                return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatedDinhMucRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var result = await _managerChiPhiChucVuService.Create(request);
                if (result == null)
                    return BadRequest();
                var chiphi = await _managerChiPhiChucVuService.GetByChiPhiID(result);
                var capBac = await _managerChiPhiChucVuService.GetByChucVuID(result);
                return Ok("DinhMucMoi");
            }
            else
                return BadRequest();
        }
        [HttpDelete("{maCapBac}&{maChiPhi}")]
        public async Task<IActionResult> Delete(string maCapBac,string maChiPhi)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var affecedResult = await _managerChiPhiChucVuService.Delete(maCapBac, maChiPhi);
                if (affecedResult == 0) { 
                    return BadRequest();
                }
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
