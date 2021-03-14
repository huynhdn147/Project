using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ChiPhiCongTac
    { 
        public string MaChiPhi { set; get; }
        public string MaChuyenCongTac { set; get; }
        public int SoTienChiTieu { set; get; }
        public int TongThanhToan { set; get; }
        public ChuyenCongTac ChuyenCongTac { set; get; }
        public ChiPhi chiPhis { set; get; }
    }
}
