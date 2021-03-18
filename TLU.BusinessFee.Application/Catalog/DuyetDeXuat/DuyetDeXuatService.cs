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

        public async Task<int> LanhDaoManager(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat  = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            throw new NotImplementedException();
        }

        public async Task<int> PhongKeToanManager(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            throw new NotImplementedException();
        }

        public async Task<int> TruongBoPhanManagerXetDuyet(string MaDeXuat)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(MaDeXuat);
            if(DeXuat.TinhTrang =="chua xet duyet")
            {
                var DeXuatdf= await _context.deXuatThanhToans.FirstOrDefaultAsync(x => x.MaDeXuat == MaDeXuat);
                DeXuatdf.TinhTrang = "truong bo phan da duyet";
                return await _context.SaveChangesAsync();
            }
            else
            throw new TLUException("De xuat da xet duyet");
        }
        public async Task<int> TruongBoPhanManagerTuChoi(TuChoiDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            if (DeXuat.TinhTrang == "chua xet duyet")
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
