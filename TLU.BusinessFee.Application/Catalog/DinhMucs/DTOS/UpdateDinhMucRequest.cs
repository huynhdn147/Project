using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS
{
    public class UpdateDinhMucRequest
    {
        public string MaCapBac { set; get; }
        public string MaChiPhi { set; get; }
        public string SoTienDinhMuc { set; get; }
        public string DonVi { set; get; }
    }
}
