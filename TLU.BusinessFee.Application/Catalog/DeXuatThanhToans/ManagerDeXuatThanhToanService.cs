using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans
{
    public  class ManagerDeXuatThanhToanService : IManagerDeXuatThanhToanService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagerDeXuatThanhToanService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        
        //public Task<string> CreateDeXuat(CreateDeXuatRequest request)
        //{
            
        //}

        public async Task<string> CreateDeXuat(CreateDeXuatRequest request)
        {
            var SoLuongNhanVien = from NV in _context.nhanVienCongTacs
                                  where NV.MaChuyenCongTac == request.MaChuyenCongTac
                                  select NV.MaNhanVien;
            var DeXuat = new DeXuatThanhToan()
            {
                MaDeXuat = request.MaDeXuat,
                MaChuyenCongTac = request.MaChuyenCongTac,
                SoNhanVien = SoLuongNhanVien.Count(),
                TinhTrang = 0,
                MaNhanVien=request.NhanVienDeXuat,
                ThoiGianDeXuat=request.ThoiGianDeXuat
            };
            await _context.deXuatThanhToans.AddAsync(DeXuat);

            await _context.SaveChangesAsync();
            return DeXuat.MaDeXuat;
        }

        public async Task<List<DeXuatThanhToanViewModel>> GetallDeXuat(string MaNhanVien)
        {
            var query = from p in _context.deXuatThanhToans join  NV in _context.NhanVienPhongs
                             on p.MaNhanVien equals NV.MaNhanVien
                             join CCT in _context.chuyenCongTacs on p.MaChuyenCongTac equals CCT.MaChuyenCongTac
                             where p.MaNhanVien==MaNhanVien
                             select new { p, NV, CCT };

            //var SoLuongNhanVien = from NV in _context.nhanVienCongTacs
            //                      where NV.MaChuyenCongTac == request.MaChuyenCongTac
            //                      select NV.MaNhanVien;
            var DeXuat = await query.Select(x => new DeXuatThanhToanViewModel()
            {
                MaDeXuat = x.p.MaDeXuat,
                
                TenNhanVien = x.NV.TenNhanVien,
                TenChuyenCongTac = x.CCT.TenChuyenCongTac,
                SoNhanVien=x.p.SoNhanVien,   
                ThoiGianDeXuat = x.p.ThoiGianDeXuat,
                TongTien = x.p.TongTien,
                TinhTrang = x.p.TinhTrang,
                Lydo=x.p.Lydo
            }).ToListAsync();

            return DeXuat;
        }

        public Task<int> UpdateDeXuat()
        {
            throw new NotImplementedException();
        }
    }
}