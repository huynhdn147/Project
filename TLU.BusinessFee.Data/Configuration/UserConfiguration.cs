using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            builder.HasKey(x => x.MaNhanVien );
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsRequired().IsUnicode(false);
            builder.HasOne(x => x.NhanVienPhongBan).WithOne(pc => pc.User);
            builder.Ignore(x => x.NormalizedUserName).Ignore(x => x.NormalizedEmail)
            .Ignore(x => x.EmailConfirmed)
            .Ignore(x => x.SecurityStamp)

            .Ignore(x => x.Email)
            .Ignore(x => x.UserName)
            .Ignore(x => x.ConcurrencyStamp)
            .Ignore(x => x.PhoneNumberConfirmed)
            .Ignore(x => x.PhoneNumber)
            .Ignore(x => x.TwoFactorEnabled)
            .Ignore(x => x.LockoutEnd)
            .Ignore(x => x.LockoutEnabled)
            .Ignore(x => x.AccessFailedCount).Ignore(x=>x.Id);
            builder.ToTable("Users");//to change the name of table.
        }
    }
}  
