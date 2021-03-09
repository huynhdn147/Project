using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Data.Entities;


namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CapBacController : ControllerBase
    {
        private readonly IManagerCapBacSerVice _ManagerCapBacSerVice;
        public CapBacController(IManagerCapBacSerVice ManagerCapBacSerVice)
        {
            _ManagerCapBacSerVice = ManagerCapBacSerVice;
        }
        [HttpGet]
        public async Task<IActionResult> getall()
        {
            
            var chucvu = await _ManagerCapBacSerVice.GetAll();
            return Ok(chucvu);
        }
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
            var result = await _ManagerCapBacSerVice.Create(request);
            if (result == null)
                return BadRequest();
            var chucvu = await _ManagerCapBacSerVice.GetByID(result);
            return Created(nameof(getbyID), chucvu);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCapBacRequest request)
        {
            var affecedResult = await _ManagerCapBacSerVice.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maCapBac}")]
        public async Task<IActionResult> Delete(string maCapBac)
        {
            var affecedResult = await _ManagerCapBacSerVice.Delete(maCapBac);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
