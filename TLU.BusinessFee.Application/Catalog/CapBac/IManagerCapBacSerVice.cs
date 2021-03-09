using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.ChucVus
{
    public interface IManagerCapBacSerVice
    {
        Task<string> Create(CreatedCapBacRequest request);
        Task<int> Update(UpdateCapBacRequest request);
        Task<int> Delete(string MaCapBac);
        Task<CapBacViewModel> GetByID(string MaCapBac);
        Task<List<CapBacViewModel>> GetAll();
        Task<PageResult<CapBacViewModel>> GetAllPaging(GetCapBacPagingRequest request);

    }
}
