using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.PhongBans.DTOS
{
    public class PhongBanUpdateRequest
    {
        public string MaPhongBan { set; get; }
        public string TenPhongBan { set; get; }
        public DateTime NgayThanhLap { set; get; }
    }
}
