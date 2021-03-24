using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class DeXuatThanhToan
    {
        
        public string MaDeXuat { set; get; }
        
        public string Lydo { set; get; }
        //public enum TinhTrang { set; get; }
        public int TongTien { set; get; }
        public DateTime ThoiGianDeXuat { set; get; }
        public int SoNhanVien { set; get; }
        public string TinhTrang  {set;get; }//0 là từ chối. 1 là trưởng phòng phê duyệt, chờ phòng kế toán xác nhận
        //2 là phòng kế toán phê duyệt, 3 là ban lãnh đạo phê duyệt, 4 là chờ thanh toán, 5 là đã thanh toán
        public string MaChuyenCongTac { set; get; }
        public string MaNhanVien { set; get; }
       // public virtual ChuyenCongTac ChuyenCongTac { set; get; }
        public  NhanVienPhongBan NhanVienDeXuat { set; get; }
        // public string fileDinhKem { set; get; }
        public List<DeXuatFile> deXuatFiles { set; get; }
        public ThanhToan ThanhToan { set; get; }
    }
}
