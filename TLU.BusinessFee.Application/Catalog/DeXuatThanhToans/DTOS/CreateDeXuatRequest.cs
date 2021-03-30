using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS
{
    public class CreateDeXuatRequest
    {
        
        public string MaChuyenCongTac { set; get; }
        public int TongTien { set; get; }
        public string NhanVienDeXuat { set; get; }
        public DateTime ThoiGianDeXuat { set; get; }
        public int SoNhanVien { set; get; }
       // public IFormFile FileHoaDon { set; get; }
    }
}
