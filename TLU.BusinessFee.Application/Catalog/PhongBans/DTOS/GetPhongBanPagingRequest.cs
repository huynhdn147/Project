using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.PhongBans.DTOS
{
    public class GetPhongBanPagingRequest: PagingRequestBase
    {
        public string MaPhongBan { set; get; }
    }
}
