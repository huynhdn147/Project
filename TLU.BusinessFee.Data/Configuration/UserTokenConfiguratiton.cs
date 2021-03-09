using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class UserTokenConfiguratiton : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.Ignore(x => x.UserId);
            builder.HasKey(x =>new { x.MaNhanVien, x.LoginProvider, x.Name });
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.user).WithMany(x => x.UserToken).HasForeignKey(x => x.MaNhanVien);
            builder.ToTable("UserTokens");
        }
    }
}
