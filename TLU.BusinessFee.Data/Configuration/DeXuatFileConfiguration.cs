using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data
{
    public class DeXuatFileConfiguration : IEntityTypeConfiguration<DeXuatFile>
    {
        public void Configure(EntityTypeBuilder<DeXuatFile> builder)
        {
            builder.ToTable("DeXuatFile");
            builder.HasKey(x => x.FileID);
            builder.Property(x => x.MaDeXuat).HasDefaultValue(5).IsUnicode(false);
            builder.Property(x => x.FilePath).IsRequired(true);
            builder.HasOne(x => x.DeXuatThanhToan).WithMany(pc => pc.deXuatFiles).HasForeignKey(pc => pc.MaDeXuat);
        }
    }
}
