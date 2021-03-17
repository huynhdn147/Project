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

        [DataType(DataType.Text)]
        public string NgayBatDau { set; get; }
        [DataType(DataType.Date)]
        public string NgayKetThuc { set; get; }
        public string MoTa { set; get; }
        public string DiaDiem { set; get; }
        public string TrangThai { set; get; }// true là chưa đi, false là đã đi. trạng thái false sẽ không thể sửa hoặc xóa được
    }
}
