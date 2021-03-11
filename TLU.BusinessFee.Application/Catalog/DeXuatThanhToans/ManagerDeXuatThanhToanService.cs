using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;
using TLU.BusinessFee.Data.EF;

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

        public Task<string> CreateDeXuat()
        {
            throw new NotImplementedException();
        }

        public async Task<List<DeXuatThanhToanViewModel>> GetallDeXuat(string MaNhanVien)
        {
            var query = from p in _context.deXuatThanhToans join  NV in _context.NhanVienPhongs
                             on p.MaNhanVien equals NV.MaNhanVien
                             join CCT in _context.chuyenCongTacs on p.MaChuyenCongTac equals CCT.MaChuyenCongTac
                             where p.MaNhanVien==MaNhanVien
                             
                        select new { p, NV, CCT };
            //var queryTongTien= from 
               
            var DeXuat = await query.Select(x => new DeXuatThanhToanViewModel()
            {
                MaDeXuat = x.p.MaDeXuat,
                
                TenNhanVien = x.NV.TenNhanVien,
                TenChuyenCongTac = x.CCT.TenChuyenCongTac,
                ThoiGianDeXuat = x.p.ThoiGianDeXuat,
                TongTien = x.p.TongTien,
                TinhTrang = x.p.TinhTrang
            }).ToListAsync();

            return DeXuat;
        }

        public Task<int> UpdateDeXuat()
        {
            throw new NotImplementedException();
        }
    }
}