using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS
{
    public class UpdateChiPhiRequest
    {
        public string MaChiPhi { set; get; }
        public string TenChiPhi { set; get; }
        public string MoTa { set; get; }
    }
}
