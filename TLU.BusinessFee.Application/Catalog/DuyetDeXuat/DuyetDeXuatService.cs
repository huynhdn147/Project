using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.Application.Catalog.DuyetDeXuat
{
    public class DuyetDeXuatService : IDuyetDeXuatService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public DuyetDeXuatService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }

        public async Task<int> LanhDaoManager(UpdateDeXuatManagerRequest request)
        {
            var DeXuat  = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            throw new NotImplementedException();
        }

        public async Task<int> PhongKeToanManager(UpdateDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            throw new NotImplementedException();
        }

        public async Task<int> TruongBoPhanManager(UpdateDeXuatManagerRequest request)
        {
            var DeXuat = await _context.deXuatThanhToans.FindAsync(request.MaDeXuat);
            if(DeXuat.TinhTrang == null)
            throw new NotImplementedException();
            else
                throw new NotImplementedException();
        }
    }
}
