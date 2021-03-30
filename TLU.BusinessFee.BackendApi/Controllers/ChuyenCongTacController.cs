using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [Authorize]
    public class ChuyenCongTacController : ControllerBase
    {
        private readonly IChuyenCongTacSerVice _service;
        private readonly TLUBusinessFeeDbContext _context;
        public ChuyenCongTacController(IChuyenCongTacSerVice serVice, TLUBusinessFeeDbContext context)
        {
            _service = serVice;
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
            
                var chuyenCongTac = await _service.GetAll();
                return Ok(chuyenCongTac);
            
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateChuyenCongTacRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {

                var result = await _service.Create(request);
                if (result == null)
                    return BadRequest();
                var chuyenCongTac = await _service.GetByChuyenCongTacID(result);
                return Created(nameof(chuyenCongTac), chuyenCongTac);
            }
            else
                return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateChuyenCongTacRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {

                var result = await _service.Update(request);
                if (result == null)
                    return BadRequest();
                else
                    return Ok();
            }
            else
                return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> delete(string MaChuyenCongTac)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {

                var affecedResult = await _service.Delete(MaChuyenCongTac);
                if (affecedResult == 0)
                    return BadRequest();

                return Ok();
            }
            else
                return Ok();
        }
    }
}
