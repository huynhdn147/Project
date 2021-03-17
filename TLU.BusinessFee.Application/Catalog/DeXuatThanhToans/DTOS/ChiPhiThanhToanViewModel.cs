using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS
{
    public class ChiPhiThanhToanViewModel
    {
        public string MaChiPhi { set; get; }
        public int SoTienChiTieu { set; get; }
       
        public int TongThanhToan { set; get; }
        public string TenChiPhi { set; get; }
        public string MaChuyenCongTac { set; get; }
    }
}
