﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ThanhToans.DTOS;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.ThanhToans
{
    public class ThanhToanManagerService : IThanhToanManagerService
    {
        private readonly TLUBusinessFeeDbContext _context;
    
        public ThanhToanManagerService(TLUBusinessFeeDbContext context)
        {
            _context = context;
          
        }
        public async Task<List<ThanhToanViewModel>> GetAll()
        {
            var query = from TT in _context.thanhToans
                            join DX in _context.deXuatThanhToans
                            on TT.MaDeXuat equals DX.MaDeXuat
                            join CTT in _context.chuyenCongTacs
                            on DX.MaChuyenCongTac equals CTT.MaChuyenCongTac
                            select new { TT, DX, CTT };
                            
             var thanhtoan= await query.Select(x=>new ThanhToanViewModel()
            {
                MaHoaDon=x.TT.MaHoaDon,
                MaDeXuat=x.DX.MaDeXuat,
                TenChuyenCongTac=x.CTT.TenChuyenCongTac,
                SoNhanVien=x.DX.SoNhanVien,
                ThoiGianDeXuat=x.DX.ThoiGianDeXuat,
                TongChiPhi=x.DX.TongTien,
                TinhTrang=x.DX.TinhTrang
            }).ToListAsync();

            return thanhtoan;
        }

        
        public async Task<string> ThanhToan(string MaHoaDon,string MaDeXuat)
        {
            
            var ThanhToan =  _context.thanhToans.Find(MaHoaDon, MaDeXuat);
            var dexuat = from TT in _context.thanhToans
                         join DX in _context.deXuatThanhToans on TT.MaDeXuat equals DX.MaDeXuat
                         where MaHoaDon == ThanhToan.MaHoaDon
                         select DX;
            var dexuatDF = dexuat.FirstOrDefault();
            if(dexuatDF.TinhTrang != "Ban lanh dao da xet duyet")
            {
                return null;
            }
            else
            {
                ThanhToan.TinhTrang = "Da Thanh Toan";
                dexuatDF.TinhTrang = "Da ThanhToan";
                await _context.SaveChangesAsync();
                return ThanhToan.MaDeXuat;
            }
            

        }
    }
}
