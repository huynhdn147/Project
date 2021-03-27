using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Application.Catalog.NhanViens
{
    public interface IManagerNhanVienService
    {
        Task<string> Create(CreateNhanVienRequest request);
        Task<int> Update(UpdateNhanVienRequest request);
        Task<int> Delete(string MaNhanVien);
        Task<NhanVienViewModel> GetByID(string MaNhanVien);
        Task<List<NhanVienViewModel>> GetAllByPhongBanID(string MaPhongBan);
        Task<List<NhanVienViewModel>> GetAllByChucVuID(string MaCapBac);
        Task<List<NhanVienViewModel>> GetAll();
        Task<List<NhanVienViewModel>>GetAllByPhongBan();
        Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request);
        Task Create(List<NhanVienPhongBan> nhanvien);
        //Task<string> CreatedByExcel();
    }
}
