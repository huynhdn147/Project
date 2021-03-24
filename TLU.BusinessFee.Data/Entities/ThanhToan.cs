using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ThanhToan
    {
        public string MaHoaDon { set; get; }
        public string MaDeXuat { set; get; }
        public DateTime ThoiGianDeXuat { set; get; }
        public int TongChiPhi { set; get; }
        public string TinhTrang { set; get; }

        public DeXuatThanhToan DeXuatThanhToan { set; get; }
    }
}
