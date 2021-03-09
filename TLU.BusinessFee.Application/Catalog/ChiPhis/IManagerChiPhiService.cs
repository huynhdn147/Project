using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;

namespace TLU.BusinessFee.Application.Catalog.ChiPhis
{
    public interface IManagerChiPhiService
    {
        Task<string> Create(CreatedChiPhiRequest request);
        Task<int> Update(UpdateChiPhiRequest request);
        Task<int> Delete(string MaChiPhi);
        Task<ChiPhiViewModel> GetByID(string MaChiPhi);
        Task<List<ChiPhiViewModel>> GetAll();
    }
}
