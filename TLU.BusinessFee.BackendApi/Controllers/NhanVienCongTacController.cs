using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NhanVienCongTacController : ControllerBase
    {
        private readonly IManagerNhanVienCongTacService _Service;
        private readonly TLUBusinessFeeDbContext _context;
        public NhanVienCongTacController(IManagerNhanVienCongTacService Service,TLUBusinessFeeDbContext context)
        {
            _Service = Service;
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
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNhanVienCongTacRequest Request)
        {
            var role = post().RoleID;
            if(role!="RL04"&&role!="RL05")
            {
                return BadRequest();
            }
            else { 
            var result = _Service.Create(Request);
            if (result.Result == null)
                return BadRequest();
            // var chuyenCongTac = await _Service.(result);
            return Ok(result.Result);
            }
        }
        //[HttpPost]
        //public async Task<IActionResult> Creatlist([FromBody] List<CreateNhanVienCongTacRequest> requests)
        //{
        //    var result = _Service.createListAsync(requests);
        //    if (result == null)
        //        return BadRequest();
        //    //var chuyenCongTac = await _Service.GetNhanVienByChuyenCongTac(result);
        //    return Ok(result.Result);
        //}
        [HttpDelete]
        public async Task<IActionResult> Delete( string MaChuyenCongTac, string MaNhanVien)
        {
            var role = post().RoleID;
            if (role != "RL04"&& role!="RL01")
            {
                return BadRequest();
            }
            else
            {
                var affecedResult = await _Service.Delete(MaChuyenCongTac, MaNhanVien);
                if (affecedResult == 0)
                    return BadRequest();

                return Ok();
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var NhanVien = await _Service.GetAll();
            if (NhanVien == null)
                return BadRequest("khong co nhan vien nay di cong tac nay");
            return Ok(NhanVien);
        }
        [HttpGet("GetByNhanVienID/{MaNhanVien}")]
        public async Task<IActionResult> GetByMaNhanVien(string MaNhanVien)
        {
            var NhanVien = await _Service.GetChuyenCongTacByNhanVien(MaNhanVien);
            if (NhanVien == null)
                return BadRequest("khong co nhan vien nay di cong tac nay");
            return Ok(NhanVien);
        }
        [HttpGet("GetByCTTID/{MaChuyenCongTac}")]
        public async Task<IActionResult> GetByMaChuyenCongTac(string MaChuyenCongTac)
        {
            var NhanVien = await _Service.GetNhanVienByChuyenCongTac(MaChuyenCongTac);
            if (NhanVien == null)
                return BadRequest("khong co chuyen cong tac nay");
            return Ok(NhanVien);
        }
    }
}
