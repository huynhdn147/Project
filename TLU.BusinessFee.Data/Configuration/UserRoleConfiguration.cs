using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.Ignore(x => x.UserId);
            builder.HasKey(x => new { x.RoleId,x.MaNhanVien });
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            
            builder.HasOne(x => x.User).WithMany(pc => pc.UserRole).HasForeignKey(pc => pc.MaNhanVien);
            builder.HasOne(x => x.Role).WithMany(pc => pc.UserRoles).HasForeignKey(pc => pc.RoleId);
            builder.ToTable("UserRole");
        }
    }
}
