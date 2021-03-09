using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaims>
    {
        public void Configure(EntityTypeBuilder<RoleClaims> builder)
        {
            builder.HasOne(x => x.Role).WithMany(pc => pc.RoleClaims).HasForeignKey(pc => pc.RoleId);
            builder.ToTable("RoleClaims");
        }
    }
}
