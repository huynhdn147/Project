using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class PhongBanConfiguration : IEntityTypeConfiguration<PhongBan>
    {
        public void Configure(EntityTypeBuilder<PhongBan> builder)
        {
            builder.ToTable("PhongBans");
            builder.HasKey(x => x.MaPhongBan);
            builder.Property(x => x.MaPhongBan).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.TenPhongBan).IsRequired(true).HasMaxLength(25).IsUnicode(false);
            builder.Property(x => x.NgayThanhLap).HasDefaultValue(DateTime.Now);
        }
    }
}
