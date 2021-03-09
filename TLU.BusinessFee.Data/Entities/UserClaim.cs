using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public string MaNhanVien { set; get; }
        public User user { set; get; }
    }
}
