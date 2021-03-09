using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChiPhis;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiPhiController : ControllerBase
    {
        private readonly IManagerChiPhiService _managerChiPhiService;
        public ChiPhiController(IManagerChiPhiService managerChiPhiService)
        {
            _managerChiPhiService = managerChiPhiService;
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
            var result = await _managerChiPhiService.Create(request);
            if (result == null)
                return BadRequest();
            var chiPhi = await _managerChiPhiService.GetByID(result);
            
            return Created(nameof(chiPhi),chiPhi);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateChiPhiRequest request)
        {
            var affecedResult = await _managerChiPhiService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maChiPhi}")]
        public async Task<IActionResult> Delete(string maChiPhi)
        {
            var affecedResult = await _managerChiPhiService.Delete(maChiPhi);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
