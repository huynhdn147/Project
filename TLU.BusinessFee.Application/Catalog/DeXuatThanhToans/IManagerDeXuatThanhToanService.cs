using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans
{
    public interface IManagerDeXuatThanhToanService
    {
        Task<string> CreateDeXuat(CreateDeXuatRequest request);
        Task<int> UpdateDeXuat();
        Task<List<DeXuatThanhToanViewModel>> GetallDeXuat(string MaNhanVien);
    }
}
