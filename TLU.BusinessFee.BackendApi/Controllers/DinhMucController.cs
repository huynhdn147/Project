using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DinhMucController : ControllerBase
    {
        private readonly IManagerDinhMucService _managerChiPhiChucVuService;
        public DinhMucController(IManagerDinhMucService managerChiPhiChucVuService)
        {
            _managerChiPhiChucVuService = managerChiPhiChucVuService;
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
            var affecedResult = await _managerChiPhiChucVuService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatedDinhMucRequest request)
        {
            var result = await _managerChiPhiChucVuService.Create(request);
            if (result == null)
                return BadRequest();
            var chiphi = await _managerChiPhiChucVuService.GetByChiPhiID(result);
            var capBac = await _managerChiPhiChucVuService.GetByChucVuID(result);
            return Ok("DinhMucMoi");
        }
        [HttpDelete("{maCapBac}&{maChiPhi}")]
        public async Task<IActionResult> Delete(string maCapBac,string maChiPhi)
        {
            var affecedResult = await _managerChiPhiChucVuService.Delete(maCapBac, maChiPhi);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
