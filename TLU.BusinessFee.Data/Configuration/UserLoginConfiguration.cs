using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            
            builder.Ignore(x => x.UserId);
            builder.HasKey(x => new { x.MaNhanVien, x.ProviderKey });
            builder.HasOne(x => x.user).WithMany(x => x.UserLogin).HasForeignKey(x => x.MaNhanVien);
            
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            
            builder.ToTable("UserLogins");
        }
    }
}
