using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.PhongBans
{
   

    public class PublicPhongBanService:IPublicPhongBanService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public PublicPhongBanService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<PhongBanViewModel>> GetAll()
        {
            
            var query = from p in _context.PhongBans select p;
            var data = await query.Select(x => new PhongBanViewModel()
            {
                MaPhongBan = x.MaPhongBan,
                TenPhongBan = x.TenPhongBan,
                NgayThanhLap = x.NgayThanhLap.ToString().Remove(10),
            }).ToListAsync();
            return data;
        }

        public  PageResult<PhongBanViewModel> GetAllPaging(GetPhongBanPagingRequest request)
        {
            throw new NotImplementedException();
        }
        
    }
}
