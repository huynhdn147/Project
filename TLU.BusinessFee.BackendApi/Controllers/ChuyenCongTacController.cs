using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ChuyenCongTacController : ControllerBase
    {
        private readonly IChuyenCongTacSerVice _service;
        public ChuyenCongTacController(IChuyenCongTacSerVice serVice)
        {
            _service = serVice;
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
            var result = await _service.Create(request);
            if (result == null)
                return BadRequest();
            var chuyenCongTac = await _service.GetByChuyenCongTacID(result);
            return Created(nameof(chuyenCongTac), chuyenCongTac);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateChuyenCongTacRequest request)
        {
            var result = await _service.Update(request);
            if (result == null)
                return BadRequest();
            else
                return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> delete(string MaChuyenCongTac)
        {
            var affecedResult = await _service.Delete(MaChuyenCongTac);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
