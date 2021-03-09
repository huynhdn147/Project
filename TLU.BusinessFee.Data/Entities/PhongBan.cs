using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class PhongBan
    {
        public string MaPhongBan { set; get; }
        public string TenPhongBan { set; get; }
        public DateTime? NgayThanhLap { set; get; }

        public List<NhanVienPhongBan> NhanVienPhongBans { set; get; }
    }
}
