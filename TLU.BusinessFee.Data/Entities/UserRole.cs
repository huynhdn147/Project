
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class UserRole: IdentityUserRole<string>
    {

        public string MaNhanVien { set; get; }
        public User User { set; get; }
        public Role Role { set; get; }
    }
}
