using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChiPhis;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChiPhiController : ControllerBase
    {
        private readonly IManagerChiPhiService _managerChiPhiService;
        private readonly TLUBusinessFeeDbContext _context;
        public ChiPhiController(IManagerChiPhiService managerChiPhiService, TLUBusinessFeeDbContext context)
        {
            _managerChiPhiService = managerChiPhiService;
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
                RoleID = claims[1].Value
            };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> getall()
        {
            var chiPhis = await _managerChiPhiService.GetAll();
            return Ok(chiPhis);
        }
        [HttpGet("MaChiPhi")]
        public async Task<IActionResult> getbyID(string MaChiPhi)
        {
            var chiPhi = await _managerChiPhiService.GetByID(MaChiPhi);
            if (chiPhi == null)
                return BadRequest("khong the tim thay loai chi phi");
            return Ok(chiPhi);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatedChiPhiRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var result = await _managerChiPhiService.Create(request);
            if (result == null)
                return BadRequest();
            var chiPhi = await _managerChiPhiService.GetByID(result);
            
            return Created(nameof(chiPhi),chiPhi);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateChiPhiRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var affecedResult = await _managerChiPhiService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maChiPhi}")]
        public async Task<IActionResult> Delete(string maChiPhi)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var affecedResult = await _managerChiPhiService.Delete(maChiPhi);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
