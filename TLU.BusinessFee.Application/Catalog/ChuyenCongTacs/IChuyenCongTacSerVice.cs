using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;

namespace TLU.BusinessFee.Application.Catalog.ChuyenCongTacs
{
    public interface IChuyenCongTacSerVice
    {
        Task<string> Create(CreateChuyenCongTacRequest Request);
        Task<int> Update(UpdateChuyenCongTacRequest request);
        Task<int> Delete(string MaChuyenCongTac);
        Task<ChuyenCongTacViewModel> GetByChuyenCongTacID(string MaChuyenCongTac);
        Task<List<ChuyenCongTacViewModel>> GetAll();
        Task<List<ChuyenCongTacViewModel>> GetAllByTruongBoPhan(string MaPhongBan);
        Task<List<ChuyenCongTacViewModel>> GetAllByNhanVien(string MaNhanVien);
    }
}
