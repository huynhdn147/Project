using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using System.Linq;
namespace TLU.BusinessFee.Application.Catalog.ChiPhis
{
    public class ManagerChiPhiService : IManagerChiPhiService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagerChiPhiService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreatedChiPhiRequest request)
        {
            var ChiPhi = from CP in _context.ChiPhis
                         select CP;

            string SoLuongChiPhi = ChiPhi.Count().ToString();
            do
            {
                SoLuongChiPhi = (Convert.ToInt32(SoLuongChiPhi) + 1).ToString();

            }
            while (_context.CapBacs.Find("CP" + SoLuongChiPhi) != null);
            var chiphi = new ChiPhi()
            {
                MaChiPhi = "CP" + SoLuongChiPhi,
                TenChiPhi = request.TenChiPhi,
                MoTa=request.MoTa
            };
            _context.ChiPhis.Add(chiphi);
            await _context.SaveChangesAsync();
            return chiphi.MaChiPhi;
        }

        public async Task<int> Delete(string MaChiPhi)
        {
            var chiphi = await _context.ChiPhis.FindAsync(MaChiPhi);
            if (chiphi == null) throw new TLUException("Khong co chuc vu");
            _context.ChiPhis.Remove(chiphi);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ChiPhiViewModel>> GetAll()
        {
            var query = from p in _context.ChiPhis select p;
            var data = await query.Select(x => new ChiPhiViewModel()
            {
                MaChiPhi=x.MaChiPhi,
                TenChiPhi=x.TenChiPhi,
                MoTa = x.MoTa
            }).ToListAsync();
            return data;
        }

        public async Task<ChiPhiViewModel> GetByID(string MaChiPhi)
        {
            var chiphi = await _context.ChiPhis.FindAsync(MaChiPhi);
            var chiphiviewmodel = new ChiPhiViewModel()
            {

                MaChiPhi = chiphi.MaChiPhi,
                TenChiPhi = chiphi.TenChiPhi,
                MoTa=chiphi.MoTa
            };
            return chiphiviewmodel;
        }

        public async Task<int> Update(UpdateChiPhiRequest request)
        {
            var chiphi = await _context.ChiPhis.FindAsync(request.MaChiPhi);
            var chiphidf = await _context.ChiPhis.FirstOrDefaultAsync(x => x.MaChiPhi == request.MaChiPhi);
            if (chiphi == null) throw new TLUException("Khong co loai chi phi");
            chiphidf.MaChiPhi = request.MaChiPhi;
            chiphidf.TenChiPhi = request.TenChiPhi;
            chiphidf.MoTa = request.MoTa;
            return await _context.SaveChangesAsync();
        }
    }
}
