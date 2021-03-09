using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs.DTOS;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Application.Catalog.NhanVienCongTacs
{
   public interface IManagerNhanVienCongTacService
    {
        Task<string> Create(CreateNhanVienCongTacRequest Request);
        Task<int> Update(updateNhanVienCongTacRequest request);
        Task<int> Delete(string MaChuyenCongTac, string MaNhanVien);
        Task<List<NhanVienCongTacViewName>> GetAll();
       
        Task<List<CreateNhanVienCongTacRequest>> createListAsync(List<CreateNhanVienCongTacRequest> requests);
        Task<List<NhanVienCongTacViewModel>> GetChuyenCongTacByNhanVien(string MaNhanVien);
        Task<List<NhanVienCongTacViewModel>> GetNhanVienByChuyenCongTac(string MaChuyenCongTac);


    }
}
