using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.PhongBans
{
    public interface IManagerPhongBanService
    {
        Task<string> Create(PhongBanCrearteRequest request);
        Task<int> Update(PhongBanUpdateRequest request);
        Task<int> Delete(string MaPhongBan);
        Task<PhongBanViewModel> GetByID(string MaPhongBan);

       // Task<PageResult<PhongBanViewModel>> GetAllPaging(GetPhongBanPagingRequest request);


    }
}
