using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.ThanhToans.DTOS
{
    public class ThanhToanViewModel
    {
        public string MaHoaDon { set; get; }
        public string MaDeXuat { set; get; }
        public string TenChuyenCongTac { set; get; }
        public int SoNhanVien { set; get; }
        public string ThoiGianDeXuat { set; get; }
        public int TongChiPhi { set; get; }
        public string TinhTrang { set; get; }
        public string TenNhanVienDeXuat { set; get; }
        public string MaChuyenCongTac { set; get; }
    }
}
