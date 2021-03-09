using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class ChiPhiConfiguration : IEntityTypeConfiguration<ChiPhi>
    {
        public void Configure(EntityTypeBuilder<ChiPhi> builder)
        {
            builder.ToTable("ChiPhi");
            builder.HasKey(x => x.MaChiPhi);
            builder.Property(x => x.MaChiPhi).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.TenChiPhi).IsRequired().HasMaxLength(25).IsUnicode(true);


        }
    }
}
