using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Utilities.Exceptions;

namespace TLU.BusinessFee.Application.Catalog.DuyetDeXuat
{
    public class DuyetDeXuatService : IDuyetDeXuatService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public DuyetDeXuatService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }

        public async Task<int> LanhDaoXetDuyetManager(string MaDeXuat)
        {
            var DeXuat  = await _context.deXuatThanhToans.FindAsync(MaDeXuat);
            if (DeXuat.TinhTrang == "Phong ke toan da xet duyet")
            {
                var DeXuatdf = await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == MaDeXuat);
                DeXuatdf.TinhTrang = "Ban lanh dao da xet duyet";
                return await _context.SaveChangesAsync();
            }
            if(DeXuat.TinhTrang== "Truong bo phan da duyet" || DeXuat.TinhTrang== "Chua xet duyet")
            {
                throw new TLUException("De xuat chua duoc xet duyet");
            }
            else
            {
                throw new TLUException("De xuat da duoc xet duyet");
            }
        }
        public async Task<int> LanhDaoTuChoiManager(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            if (DeXuat.TinhTrang == "Phong ke toan da xet duyet")
            {
                var DeXuatdf = await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == request.MaDeXuat);
                DeXuatdf.TinhTrang = "Ban lanh dao tu choi";
                DeXuatdf.Lydo = request.Lydo;
                return await _context.SaveChangesAsync();
            }
            else
                throw new TLUException("De xuat da xet duyet");
        }
        public async Task<int> PhongKeToanXetDuyetManager(string MaDeXuat)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(MaDeXuat);
            if (DeXuat.TinhTrang == "Chua xet duyet")
            {
                throw new TLUException("De xuat chua duoc truong bo phan xet duyet");
            }
            if(DeXuat.TinhTrang== "Truong bo phan da duyet")
            {
                var DeXuatdf = await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == MaDeXuat);
                DeXuatdf.TinhTrang = "Phong ke toan da xet duyet";
                return await _context.SaveChangesAsync();
            }
            else
            {
                 throw new TLUException("De xuat da duoc xet duyet");
            }
                
        }
        public async Task<int> PhongKeToanTuChoiManager(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            if (DeXuat.TinhTrang == "Truong bo phan da duyet") 
            {
                var DeXuatdf = await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == request.MaDeXuat);
                DeXuatdf.TinhTrang = "Phong ke toan tu choi";
                DeXuatdf.Lydo = request.Lydo;
                return await _context.SaveChangesAsync();
            }
            else
                throw new TLUException("De xuat da xet duyet");

        }

        public async Task<int> TruongBoPhanManagerXetDuyet(string MaDeXuat)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(MaDeXuat);
            if(DeXuat.TinhTrang =="Chua xet duyet")
            {
                var DeXuatdf= await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == MaDeXuat);
                DeXuatdf.TinhTrang = "Truong bo phan da duyet";
                return await _context.SaveChangesAsync();
            }
            else
            throw new TLUException("De xuat da xet duyet");
        }
        public async Task<int> TruongBoPhanManagerTuChoi(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            if (DeXuat.TinhTrang == "Chua xet duyet")
            {
                var DeXuatdf = await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == request.MaDeXuat);
                DeXuatdf.TinhTrang = "Truong bo phan tu choi";
                DeXuatdf.Lydo = request.Lydo;
                return await _context.SaveChangesAsync();
            }
            else
                throw new TLUException("De xuat da xet duyet");
        }
    }
}
