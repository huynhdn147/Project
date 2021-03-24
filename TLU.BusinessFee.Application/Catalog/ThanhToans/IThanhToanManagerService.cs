using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ThanhToans.DTOS;

namespace TLU.BusinessFee.Application.Catalog.ThanhToans
{
    public interface IThanhToanManagerService
    {
        Task<List<ThanhToanViewModel>> GetAll();
        Task<string> ThanhToan(string MaHoaDon,string MaDeXuat);
    }
}
