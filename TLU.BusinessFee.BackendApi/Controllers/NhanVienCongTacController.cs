using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NhanVienCongTacController : ControllerBase
    {
        private readonly IManagerNhanVienCongTacService _Service;
        public NhanVienCongTacController(IManagerNhanVienCongTacService Service)
        {
            _Service = Service;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNhanVienCongTacRequest Request)
        {
            var result = _Service.Create(Request);
            if (result == null)
                return BadRequest();
            // var chuyenCongTac = await _Service.(result);
            return Ok(result.Result);
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
            var affecedResult = await _Service.Delete(MaChuyenCongTac, MaNhanVien);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
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
