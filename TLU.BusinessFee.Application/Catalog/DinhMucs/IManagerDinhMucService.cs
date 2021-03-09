using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS;

namespace TLU.BusinessFee.Application.Catalog.ChiPhiChucVus
{
    public interface IManagerDinhMucService
    {
        Task<string> Create(CreatedDinhMucRequest request);
        Task<int> Update(UpdateDinhMucRequest request);
        Task<int> Delete(string MaChiPhi,string MaChucVu);
        Task<List<DinhMucViewModel>> GetByChiPhiID(string MaChiPhi);
        Task<List<DinhMucViewModel>> GetByChucVuID(string MaChucVu);
        Task<List<DinhMucViewModel>> GetAll();
    }
}
