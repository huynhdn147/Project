using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS
{
    public class CreateDeXuatRequest
    {
        public string MaDeXuat { set; get; }
        public string MaChuyenCongTac { set; get; }
        public int TongTien { set; get; }
        public string NhanVienDeXuat { set; get; }
        public DateTime ThoiGianDeXuat { set; get; }
        public int SoNhanVien { set; get; }
    }
}
