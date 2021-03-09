using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class RoleClaims: IdentityRoleClaim<string>
    {
        public Role Role { set; get; }
    }
}
