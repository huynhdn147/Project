using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;


namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CapBacController : ControllerBase
    {
        private readonly IManagerCapBacSerVice _ManagerCapBacSerVice;
        private readonly TLUBusinessFeeDbContext _context;
        public CapBacController(IManagerCapBacSerVice ManagerCapBacSerVice, TLUBusinessFeeDbContext context)
        {
            _ManagerCapBacSerVice = ManagerCapBacSerVice;
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
            
            var chucvu = await _ManagerCapBacSerVice.GetAll();
            return Ok(chucvu);
        }//Mọi người đều xem được cấp bậc
        [HttpGet("maCapBac")]
        public async Task<IActionResult> getbyID(string MaCapBac)
        {
            var chucvu = await _ManagerCapBacSerVice.GetByID(MaCapBac);
            if (chucvu == null)
                return BadRequest("khong the tim thay cap bac");
            return Ok(chucvu);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatedCapBacRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var result = await _ManagerCapBacSerVice.Create(request);
            if (result == null)
                return BadRequest();
            var chucvu = await _ManagerCapBacSerVice.GetByID(result);
            return Created(nameof(getbyID), chucvu);
            // admin có thể thêm mới, sửa, xóa
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCapBacRequest request)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var affecedResult = await _ManagerCapBacSerVice.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maCapBac}")]
        public async Task<IActionResult> Delete(string maCapBac)
        {
            var role = post().RoleID;
            if (role != "RL01")
                return BadRequest();
            var affecedResult = await _ManagerCapBacSerVice.Delete(maCapBac);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
