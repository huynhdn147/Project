using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS
{
    public class DuyetDeXuatViewmodel
    {
        public string MaDeXuat { set; get; }
        public string MaChuyenCongTac { set; get; }
        public string TenChuyenCongTac { set; get; }
        public int SoNhanVien { set; get; }
        public string ThoiGianDeXuat { set; get; }
        public int TongChiPhi { set; get; }
        public string TinhTrang { set; get; }
        public string LyDo { set; get; }
        public string TenNhanVien { set; get; }
        public string NgayBatDau { set; get; }
        public string NgayKetThuc { set; get; }
    }
}
