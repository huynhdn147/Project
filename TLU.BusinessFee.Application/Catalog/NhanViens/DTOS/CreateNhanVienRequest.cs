using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.NhanViens.DTOS
{
    public class CreateNhanVienRequest
    {
        public string MaNhanVien { set; get; }
        public string TenNhanVien{ set; get; }
        public string MaCapBac { set; get; }
        public string MaPhongBan { set; get; }
        public string Roleid { set; get; }
        public string PassWord { set; get; }
    }
}
