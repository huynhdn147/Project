using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS
{
    public class DeXuatThanhToanViewModel
    {
        public string MaDeXuat { set; get; }
       
        public string Lydo { set; get; }
        //public enum TinhTrang { set; get; }
        public int TongTien { set; get; }
        public int SoNhanVien { set; get; }
        public string ThoiGianDeXuat { set; get; }
        public string TinhTrang { set; get; }//0 là từ chối. 1 là trưởng phòng phê duyệt, chờ phòng kế toán xác nhận
        //2 là phòng kế toán phê duyệt, 3 là ban lãnh đạo phê duyệt, 4 là chờ thanh toán, 5 là đã thanh toán
        public string TenChuyenCongTac { set; get; }
        public string MaChuyenCongTac { set; get; }
        public string TenNhanVien { set; get; }
       public string NgayBatDau { set; get; }
        public string NgayKetThuc { set; get; }
        // public virtual ChuyenCongTac ChuyenCongTac { set; get; }
        
    }
}
