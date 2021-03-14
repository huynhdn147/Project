using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class NhanVienCongTac
    { 
        public string MaChuyenCongTac { set; get; }
        public string MaNhanVien { set; get; }
        public NhanVienPhongBan NhanVienPhongBan { set; get; }
        public ChuyenCongTac ChuyenCongTac { set; get; }
       
    }
}
