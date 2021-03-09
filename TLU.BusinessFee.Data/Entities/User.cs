using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class User: IdentityUser<string>
    {
        public string MaNhanVien { set; get; }
        public virtual NhanVienPhongBan NhanVienPhongBan { set; get; }
        public List<UserClaim> userClaims { set; get; }
        public List<UserLogin> UserLogin { set; get; }
        public List<UserRole> UserRole { set; get; }
        public List<UserToken> UserToken { set; get; }

    }
}
