using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class ThanhToanConfiguration : IEntityTypeConfiguration<ThanhToan>
    {
        public void Configure(EntityTypeBuilder<ThanhToan> builder)
        {
           
            
            builder.Property(x => x.MaHoaDon).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaDeXuat).HasMaxLength(5).IsUnicode(false);
            builder.HasKey(x => new { x.MaHoaDon, x.MaDeXuat });
            builder.ToTable("ThanhToan");
        }
    }
}
