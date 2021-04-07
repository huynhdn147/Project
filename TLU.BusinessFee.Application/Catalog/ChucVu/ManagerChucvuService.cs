using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVu.DTOS;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.ChucVu
{
    public class ManagerChucvuService : IManagerChucvuService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagerChucvuService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<ChucVuViewModel>> GetAll()
        {
            var query = from p in _context.Roles
                        where p.Id != "RL01"
                        select p;
            //var query2= from US in _context.User join 
            var data = await query.Select(x => new ChucVuViewModel()
            {
                RoleID = x.Id,
                RoleName=x.Name,
                Description=x.Description
            })
            .ToListAsync();
            return data;
        }
    }
}
