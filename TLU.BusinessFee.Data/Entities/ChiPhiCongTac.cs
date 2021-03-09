using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ChiPhiCongTac
    { 
        public string MaChiPhi { set; get; }
        public string MaNhanVien { set; get; }
        public string MaChuyenCongTac { set; get; }
        public int SoTienChiTieu { set; get; }
        public NhanVienCongTac nhanVienCongTacs { set; get; }
        public ChiPhi chiPhis { set; get; }
    }
}
