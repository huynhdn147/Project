using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.PhongBans
{
    public interface IPublicPhongBanService
    {
        PageResult<PhongBanViewModel> GetAllPaging(GetPhongBanPagingRequest request);
        Task<List<PhongBanViewModel>> GetAll();
    }
}
