using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.ChucVus.DTOS
{
    public class GetCapBacPagingRequest : PagingRequestBase
    {
        public string MaCapBac { set; get; }

    }
}
