using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ChiPhiChucVu
    {
        public string MaChiPhi { set; get; }
        public string MaCapBac { set; get; }
        public string SoTienDinhMuc { set; get; }
        public string DonVi { set; get; }
        public CapBac CapBac { set; get; }
        public ChiPhi chiPhi { set; get; }
    }
}
