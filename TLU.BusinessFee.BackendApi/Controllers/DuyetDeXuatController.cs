using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DuyetDeXuatController : ControllerBase
    {
        private readonly IDuyetDeXuatService _DuyetDeXuat;
        private readonly TLUBusinessFeeDbContext _context;
        public DuyetDeXuatController(IDuyetDeXuatService DuyetDeXuat, TLUBusinessFeeDbContext context)
        {
            _DuyetDeXuat = DuyetDeXuat;
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
                RoleName = roleName.ToList()[0]
            };
            return data;
        }
        [HttpGet("TruongBoPhan")]
        public async Task<IActionResult> GetDeXuat()
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleName;
            if (role != "Trưởng bộ phận")

                return BadRequest();
            else
            {
                var nhanVienPhongBan = await  _context.NhanVienPhongs.FindAsync(maNhanVien);
                var maPhongBan =  nhanVienPhongBan.MaPhongBan;
                var deXuatThanhToan =  from DX in _context.deXuatThanhToans
                                      join NV in _context.NhanVienPhongs on DX.MaNhanVien equals NV.MaNhanVien
                                      where NV.MaPhongBan == maPhongBan
                                      select DX;

                var dexuatlist =  deXuatThanhToan.Select(x => new DuyetDeXuatViewmodel()
                {
                    MaDeXuat = x.MaDeXuat,
                    TenChuyenCongTac = x.MaChuyenCongTac,
                    SoNhanVien = x.SoNhanVien,
                    ThoiGianDeXuat = x.ThoiGianDeXuat.ToShortDateString(),
                    TongChiPhi = x.TongTien,
                    LyDo = x.Lydo,
                    TinhTrang = x.TinhTrang

                }).ToList();
                return  Ok(dexuatlist);
            }  
        }
        [HttpPost("TruongBoPhan/XetDuyet")]
        public async Task<IActionResult> XetDuyet(string MaDeXuat)
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleName;
            if (role != "Trưởng bộ phận")
                return BadRequest();
            else
            {
                var duyet =  await _DuyetDeXuat.TruongBoPhanManagerXetDuyet(MaDeXuat);
                return Ok(duyet);
            }
        }
        [HttpPost("TruongBoPhan/TuChoi")]
        public async Task<IActionResult> TuChoi(TuChoiDeXuatManagerRequest request)
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleName;
            if (role != "Trưởng bộ phận")
                return BadRequest();
            else
            {
                var duyet = await _DuyetDeXuat.TruongBoPhanManagerTuChoi(request);
                return Ok(duyet);
            }
        }
    }
}
