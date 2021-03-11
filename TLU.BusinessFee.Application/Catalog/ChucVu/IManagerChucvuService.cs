using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVu.DTOS;

namespace TLU.BusinessFee.Application.Catalog.ChucVu
{
    public interface IManagerChucvuService
    {
        Task<List<ChucVuViewModel>> GetAll();
        
    }
}
