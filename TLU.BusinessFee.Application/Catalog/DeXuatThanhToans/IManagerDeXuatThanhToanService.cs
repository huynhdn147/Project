using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans
{
    public interface IManagerDeXuatThanhToanService
    {
        Task<string> CreateDeXuat(CreateDeXuatRequest request);
        Task<int> UpdateDeXuat();
        Task<List<DeXuatThanhToanViewModel>> GetallDeXuat(string MaNhanVien);
        Task<List<DeXuatThanhToanViewModel>> GetallDeXuatToanTruong();
        Task<List<ChiPhiThanhToanViewModel>> GetChiTieu(string MaChuyenCongTac);
        Task<string> postChiPhiThanhToan(createChiPhiThanhToanRequest request);
        Task<DonViViewModel> GetDonViByMaChiPhi(string MaChiPhi);
        Task<int> DeleteChiPhiCongTac(string MaChuyenCongTac, string MaChiPhi);
        Task<int> DeleteDeXuat(string MaDeXuat);
      //  Task<List<>
    }
}
