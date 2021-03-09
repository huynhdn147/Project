using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class Role: IdentityRole<string>
    {
        public string Description { set; get; }
        public List<UserRole> UserRoles { set; get; }
        public List<RoleClaims> RoleClaims { set; get; }
    }
}
