using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ChuyenCongTac
    {
        public string MaChuyenCongTac { set; get; }
        public string TenChuyenCongTac { set; get; }
        [DataType(DataType.Date)]
        public DateTime NgayBatDau { set; get; }
        [DataType(DataType.Date)]
        public DateTime NgayKetThuc { set; get; }
        public string MoTa { set; get; }
        public string DiaDiem { set; get; }
        public string TrangThai { set; get; }//true là đã đi, false là chưa đi
        //public virtual DeXuatThanhToan DeXuat { set; get; }
        public List<NhanVienCongTac> nhanVienCongTacs { set; get; }
        public List<ChiPhiCongTac> chiPhiCongTacs { set; get; }

    }
}
