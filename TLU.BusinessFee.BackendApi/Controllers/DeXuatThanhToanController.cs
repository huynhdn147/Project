using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DeXuatThanhToanController : ControllerBase
    {
        private readonly IManagerDeXuatThanhToanService _managerDeXuatThanhToanService;
        private readonly TLUBusinessFeeDbContext _context;
        public DeXuatThanhToanController(IManagerDeXuatThanhToanService managerDeXuatThanhToanService
           , TLUBusinessFeeDbContext context)
        {
            _managerDeXuatThanhToanService = managerDeXuatThanhToanService;
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
                RoleID=claims[1].Value
            };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> getByid()
        {
            string MaNhanVien =  post().MaNhanVien.ToString();
         
            var DeXuat = await _managerDeXuatThanhToanService.GetallDeXuat(MaNhanVien);
            return Ok(DeXuat);
        }
        [HttpPost]
        //[Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateDeXuat([FromBody]CreateDeXuatRequest request)
        {
            string MaNhanVien = post().MaNhanVien.ToString();
            request.NhanVienDeXuat = MaNhanVien;
            var result = await _managerDeXuatThanhToanService.CreateDeXuat(request);
            if (result == null)
                return BadRequest();
            return Created("ok", MaNhanVien);
        }
        [HttpGet("SoTienChiTieu")]
        public async Task<IActionResult> GetChiPhiThanhToan(string MaChuyenCongTac)
        {

            string MaNhanVien = post().MaNhanVien.ToString();

            var chiPhi = await _managerDeXuatThanhToanService.GetChiTieu(MaChuyenCongTac);

            return Ok(chiPhi);
        }
        [HttpGet("DuyetDeXuat/SoTienChiTieu")]
        public async Task<IActionResult> GetChiPhiThanhToan2(string MaChuyenCongTac)
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleID;
            
                var chiPhi = await _managerDeXuatThanhToanService.GetChiTieu(MaChuyenCongTac);
                return Ok(chiPhi);
            
            
        }
        [HttpPost("ChiPhiThanhToan")]
        public async Task<IActionResult> PostChiPhiThanhToan([FromBody] createChiPhiThanhToanRequest request)
        {
            var result = await _managerDeXuatThanhToanService.postChiPhiThanhToan(request);
            if (result == null)
                return BadRequest();
            return Created("ok", request.MaChuyenCongTac);
        }
        [HttpGet("DonVi")]
        public async Task<IActionResult> GetDonVi(string MaChiPhi)
        {
            var chiPhi = await _managerDeXuatThanhToanService.GetDonViByMaChiPhi(MaChiPhi);

            return Ok(chiPhi);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDeXuat( string MaDeXuat)
        {
            var affecedResult = await _managerDeXuatThanhToanService.DeleteDeXuat(MaDeXuat);
            if (affecedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("ChiPhiCongTac")]
        public async Task<IActionResult> DeleteChiPhiCongTac(string MaChuyenCongTac, string MaChiPhi)
        {
            var affecedResult = await _managerDeXuatThanhToanService.DeleteChiPhiCongTac(MaChuyenCongTac, MaChiPhi);
            if (affecedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
