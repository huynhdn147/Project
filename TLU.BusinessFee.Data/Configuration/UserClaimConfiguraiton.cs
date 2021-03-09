using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class UserClaimConfiguraiton : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.Ignore(x => x.UserId);
            builder.HasKey(x => x.MaNhanVien);
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.user).WithMany(x => x.userClaims).HasForeignKey(x => x.MaNhanVien);
            builder.ToTable("UserClaim");
            
        }
    }
}
