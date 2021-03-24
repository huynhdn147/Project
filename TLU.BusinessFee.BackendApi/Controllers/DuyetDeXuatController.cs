﻿using Microsoft.AspNetCore.Authorization;
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
                RoleName = roleName.ToList()[0],
                RoleID= claims[1].Value
            };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> GetDeXuat()
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleID;
            if (role == "RL03")
            { 
                var nhanVienPhongBan = await _context.NhanVienPhongs.FindAsync(maNhanVien);
                var maPhongBan = nhanVienPhongBan.MaPhongBan;
                var deXuatThanhToan = from DX in _context.deXuatThanhToans
                                  join NV in _context.NhanVienPhongs on DX.MaNhanVien equals NV.MaNhanVien
                                  where NV.MaPhongBan == maPhongBan
                                  join CTT in _context.chuyenCongTacs on DX.MaChuyenCongTac equals CTT.MaChuyenCongTac
                                  orderby DX.ThoiGianDeXuat descending
                                  select new { DX, CTT };

                var dexuatlist = deXuatThanhToan.Select(x => new DuyetDeXuatViewmodel()
                {
                    MaDeXuat = x.DX.MaDeXuat,
                    TenChuyenCongTac = x.CTT.TenChuyenCongTac,
                    MaChuyenCongTac=x.DX.MaChuyenCongTac,
                    SoNhanVien = x.DX.SoNhanVien,
                    ThoiGianDeXuat = x.DX.ThoiGianDeXuat.ToShortDateString(),
                    TongChiPhi = x.DX.TongTien,
                    LyDo = x.DX.Lydo,
                    TinhTrang = x.DX.TinhTrang

                }).ToList();
            return Ok(dexuatlist);
            }
            if(role == "RL04")
            {
                var deXuatThanhToan = from DX in _context.deXuatThanhToans
                                      join NV in _context.NhanVienPhongs on DX.MaNhanVien equals NV.MaNhanVien
                                     // where NV.MaPhongBan == maPhongBan
                                      join CTT in _context.chuyenCongTacs on DX.MaChuyenCongTac equals CTT.MaChuyenCongTac
                                      orderby DX.ThoiGianDeXuat descending
                                      select new { DX, CTT };
                var dexuatlist = deXuatThanhToan.Select(x => new DuyetDeXuatViewmodel()
                {
                    MaDeXuat = x.DX.MaDeXuat,
                    TenChuyenCongTac = x.CTT.TenChuyenCongTac,
                    MaChuyenCongTac = x.DX.MaChuyenCongTac,
                    SoNhanVien = x.DX.SoNhanVien,
                    ThoiGianDeXuat = x.DX.ThoiGianDeXuat.ToShortDateString(),
                    TongChiPhi = x.DX.TongTien,
                    LyDo = x.DX.Lydo,
                    TinhTrang = x.DX.TinhTrang

                }).ToList();
                return Ok(dexuatlist);
            }
            if (role == "RL05")
            {
                var deXuatThanhToan = from DX in _context.deXuatThanhToans
                                      join NV in _context.NhanVienPhongs on DX.MaNhanVien equals NV.MaNhanVien
                                      // where NV.MaPhongBan == maPhongBan
                                      join CTT in _context.chuyenCongTacs on DX.MaChuyenCongTac equals CTT.MaChuyenCongTac
                                      orderby DX.ThoiGianDeXuat descending
                                      select new { DX, CTT };
                var dexuatlist = deXuatThanhToan.Select(x => new DuyetDeXuatViewmodel()
                {
                    MaDeXuat = x.DX.MaDeXuat,
                    TenChuyenCongTac = x.CTT.TenChuyenCongTac,
                    MaChuyenCongTac = x.DX.MaChuyenCongTac,
                    SoNhanVien = x.DX.SoNhanVien,
                    ThoiGianDeXuat = x.DX.ThoiGianDeXuat.ToShortDateString(),
                    TongChiPhi = x.DX.TongTien,
                    LyDo = x.DX.Lydo,
                    TinhTrang = x.DX.TinhTrang

                }).ToList();
                return Ok(dexuatlist);
            }
            else
            {
                return BadRequest();
            }  
        }
        [HttpPost("XetDuyet")]
        public async Task<IActionResult> XetDuyet(string MaDeXuat)
        {
            var maNhanVien = post().MaNhanVien;
            var role = post().RoleID;
            if (role == "RL03") { 
                var duyet = await _DuyetDeXuat.TruongBoPhanManagerXetDuyet(MaDeXuat);
                return Ok(duyet);
            }
            if(role=="RL04")
            {
                var duyet = await _DuyetDeXuat.PhongKeToanXetDuyetManager(MaDeXuat);
                return Ok(duyet);
            }
            if(role=="RL05")
            {
                var duyet = await _DuyetDeXuat.LanhDaoXetDuyetManager(MaDeXuat);
                return Ok(duyet);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost("TuChoi")]
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
        //[HttpGet("")]
    }
}
