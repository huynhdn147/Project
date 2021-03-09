using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.System
{
   public class LoginRequest
    {
        public string maNhanVien { set; get; }
        public string passWord { set; get; }
        public bool rememberme { set; get; }
    }
}
