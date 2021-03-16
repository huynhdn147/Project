using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;

namespace TLU.BusinessFee.Application.Catalog.PhongBans
{
    public class ManagePhongBanService : IManagerPhongBanService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagePhongBanService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(PhongBanCrearteRequest request)
        {
            var PhongBan = new PhongBan()
            {
                MaPhongBan = request.MaPhongBan, TenPhongBan = request.TenPhongBan,NgayThanhLap=request.NgayThanhLap
                
            };
            _context.PhongBans.Add(PhongBan);
             await _context.SaveChangesAsync();
            return PhongBan.MaPhongBan;
        }
        public async Task<PhongBanViewModel> GetByID(string MaPhongBan)
        {
            var PhongBan = await _context.PhongBans.FindAsync(MaPhongBan);
            var phongbanViewModel = new PhongBanViewModel() 
            {

                MaPhongBan = PhongBan.MaPhongBan,
                TenPhongBan = PhongBan.TenPhongBan,
                NgayThanhLap = PhongBan.NgayThanhLap.ToString()
            };
            return phongbanViewModel;
        }
        public async Task<int> Delete(string MaPhongBan)
        {
            var PhongBan = await _context.PhongBans.FindAsync(MaPhongBan);
            if (PhongBan == null) throw new TLUException("khong tim thay phong ban");
            _context.PhongBans.Remove(PhongBan);
             return await _context.SaveChangesAsync();
        }

        
            //public async Task<PageResult<PhongBanViewModel>> GetAllPaging(GetPhongBanPagingRequest request)
            //{
            //var query = from p in _context.PhongBans select p;
            //if (!string.IsNullOrEmpty(request.MaPhongBan))
            //    query = query.Where(x => x.MaPhongBan.Contains(request.MaPhongBan));

            //if (request.MaPhongBan.Count() > 0)
            //{
            //    query = query.Where(x => request.MaPhongBan.Contains(x.MaPhongBan));
            //}
            //int toTalRow = await query.CountAsync();
            //var data = await query.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).Select(x=>new PhongBanViewModel()
            //{ 
            //MaPhongBan=x.MaPhongBan,TenPhongBan=x.TenPhongBan,NgayThanhLap= x.NgayThanhLap
            //}).ToListAsync();

            //var pageResult = new PageResult<PhongBanViewModel>()
            //{
            //    TotalRecord = toTalRow,
            //    Items = data


            //};
            //return pageResult;
            // }

        

        public async Task<int> Update(PhongBanUpdateRequest request)
        {
            var phongban = await _context.PhongBans.FindAsync(request.MaPhongBan);
            var phongbandf = await _context.PhongBans.FirstOrDefaultAsync(x=>x.MaPhongBan==request.MaPhongBan);
            if(phongban==null) throw new TLUException("khong tim thay phong ban");

            phongbandf.MaPhongBan = request.MaPhongBan;
            phongbandf.TenPhongBan = request.TenPhongBan;
            phongbandf.NgayThanhLap = request.NgayThanhLap;
            return await _context.SaveChangesAsync();
        }
    }
}
