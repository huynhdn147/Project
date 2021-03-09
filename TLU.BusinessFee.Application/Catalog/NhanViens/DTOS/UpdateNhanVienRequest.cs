using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.NhanViens.DTOS
{
    public class UpdateNhanVienRequest
    {
        public string MaNhanVien { set; get; }
        public string TenNhanVien
        { set; get; }
        public string MaCapBac { set; get; }


        public string MaPhongBan { set; get; }
    }
}
