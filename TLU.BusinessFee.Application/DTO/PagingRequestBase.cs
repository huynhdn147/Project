using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.DTO
{
    public class PagingRequestBase
    {
        public int pageIndex { set; get; }
        public int pageSize { set; get; }
    }
}
