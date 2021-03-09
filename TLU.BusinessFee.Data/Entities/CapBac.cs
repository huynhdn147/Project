using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class CapBac
    { 
        public string MaCapBac { set; get; }
        public string TenCapBac { set; get; }
        public string MoTa { set; get; }
        public List<NhanVienPhongBan> NhanVienPhongBans { set; get; }
        public List<ChiPhiChucVu> chiPhiChucVus { set; get; }
 
    }
}
