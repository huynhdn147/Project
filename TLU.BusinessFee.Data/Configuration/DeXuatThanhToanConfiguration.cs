using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class DeXuatThanhToanConfiguration : IEntityTypeConfiguration<DeXuatThanhToan>
    {
        public void Configure(EntityTypeBuilder<DeXuatThanhToan> builder)
        {
            builder.HasKey(x => x.MaDeXuat);
            builder.Property(x => x.MaDeXuat).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaChuyenCongTac).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.NhanVienDeXuat).WithMany(pc => pc.deXuatThanhToans).HasForeignKey(pc => pc.MaNhanVien);
        }
    }
}
