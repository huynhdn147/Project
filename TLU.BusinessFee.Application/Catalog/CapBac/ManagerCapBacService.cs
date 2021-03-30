using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using System.Linq;

namespace TLU.BusinessFee.Application.Catalog.ChucVus
{
    public class ManagerCapBacService : IManagerCapBacSerVice
    {
        private readonly TLUBusinessFeeDbContext _context;
         public ManagerCapBacService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreatedCapBacRequest request)
        {
            var CapBac = from CB in _context.CapBacs
                                select CB;
            
            string SoLuongCapBac =   CapBac.Count().ToString();
            do
            {
                SoLuongCapBac = (Convert.ToInt32(SoLuongCapBac) + 1).ToString();

            }
            while (_context.CapBacs.Find("C" + SoLuongCapBac) != null) ;
            var chucvu = new CapBac()
                {
                    MaCapBac = "C" + SoLuongCapBac,
                    TenCapBac = request.TenCapBac,
                    MoTa = request.moTa
                };
            
         
              _context.CapBacs.Add(chucvu);
            await _context.SaveChangesAsync();
            return chucvu.MaCapBac;
        }
        public async Task<int> Update(UpdateCapBacRequest request)
        {
            var chucvu = await _context.CapBacs.FindAsync(request.MaCapBac);
            var chucvudf = await _context.CapBacs.FirstOrDefaultAsync(x => x.MaCapBac == request.MaCapBac);
            if (chucvu == null) throw new TLUException("Khong co cap bac");
            chucvudf.MaCapBac = request.MaCapBac;
            chucvudf.TenCapBac = request.TenCapBac;
            chucvudf.MoTa = request.Mota;
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(string MaChucVu)
        {
            var chucvu = await _context.CapBacs.FindAsync(MaChucVu);
            if (chucvu == null) throw new TLUException("Khong co Cap Bac nay");
            _context.CapBacs.Remove(chucvu);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CapBacViewModel>> GetAll()
        {
            var query = from p in _context.CapBacs select p;
            var data = await query.Select(x => new CapBacViewModel()
            {
                MaCapBac=x.MaCapBac,
                TenCapBac=x.TenCapBac,
                moTa=x.MoTa
            }).ToListAsync();
            return data;

        }

        public async Task<PageResult<CapBacViewModel>> GetAllPaging(GetCapBacPagingRequest request)
        {
            var query = from p in _context.CapBacs select p;
            if (!string.IsNullOrEmpty(request.MaCapBac))
                query = query.Where(x => x.MaCapBac.Contains(request.MaCapBac));
            if (request.MaCapBac.Count() > 0)
            {
                query = query.Where(x => request.MaCapBac.Contains(x.MaCapBac));
            }
            int toTalRow = await query.CountAsync();

            var data = await query.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).Select(x => new CapBacViewModel()
            {
                MaCapBac = x.MaCapBac,
                TenCapBac=x.TenCapBac
                ,moTa=x.MoTa
            }).ToListAsync();
            var pageResult = new PageResult<CapBacViewModel>()
            {
                TotalRecord = toTalRow,
                Items = data

            };
            return pageResult;
        }

        public async Task<CapBacViewModel> GetByID(string MaChucVu)
        {
            var chucvu = await _context.CapBacs.FindAsync(MaChucVu);
            var ChucVuViewModel = new CapBacViewModel()
            {

                MaCapBac = chucvu.MaCapBac,
                TenCapBac=chucvu.TenCapBac
                ,moTa=chucvu.MoTa
            };
            return ChucVuViewModel;
        }

        
    }
}
