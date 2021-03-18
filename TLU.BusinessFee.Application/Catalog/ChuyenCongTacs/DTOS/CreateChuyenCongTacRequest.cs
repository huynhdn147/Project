using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS
{
    public class CreateChuyenCongTacRequest
    {
        public string MaChuyenCongTac { set; get; }
        public string TenChuyenCongTac { set; get; }
        public DateTime NgayBatDau { set; get; }
        public DateTime NgayKetThuc { set; get; }
        public string MoTa { set; get; }
        public string DiaDiem { set; get; }
       //true là đã đi, false là chưa đi
    }
}
