using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class ChiPhi
    {
        public string MaChiPhi { set; get; }
        public string TenChiPhi { set; get; }
        public string MoTa { set; get; }
        public List<ChiPhiChucVu> chiPhiChucVus { set; get; }
        public List<ChiPhiCongTac> chiPhiCongTac { set; get; }
    }
}
