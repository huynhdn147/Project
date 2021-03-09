using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Data;
using Microsoft.SqlServer.Server;

namespace TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS
{
    public class ChuyenCongTacViewModel
    {
        public string MaChuyenCongTac { set; get; }
        public string TenChuyenCongTac { set; get; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime NgayBatDau { set; get; }
        public DateTime NgayKetThuc { set; get; }
        public string MoTa { set; get; }
        public string DiaDiem { set; get; }
        public bool TrangThai { set; get; }// true là chưa đi, false là đã đi. trạng thái false sẽ không thể sửa hoặc xóa được
    }
}
