using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVu;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChucVuController : ControllerBase
    {
        private readonly TLUBusinessFeeDbContext _context;
        private readonly IManagerChucvuService _service;
        public ChucVuController(TLUBusinessFeeDbContext context, IManagerChucvuService service)
        {
            _context = context;
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var chucvu = await _service.GetAll();
            return Ok(chucvu);
        }
    }
}
