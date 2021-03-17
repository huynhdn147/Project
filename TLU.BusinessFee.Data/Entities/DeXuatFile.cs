using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class DeXuatFile
    {
        public int FileID { set; get; }
        public string MaDeXuat { set; get; }
        public string FilePath { set; get; }
        public DeXuatThanhToan DeXuatThanhToan { set; get; }
    }
}
