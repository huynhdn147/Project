using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    class NhanVienCongTacConfiguration : IEntityTypeConfiguration<NhanVienCongTac>
    {
        public void Configure(EntityTypeBuilder<NhanVienCongTac> builder)
        {
            builder.ToTable("NhanVienCongTac");
            builder.HasKey(x => new { x.MaChuyenCongTac, x.MaNhanVien });
            builder.Property(x => x.MaChuyenCongTac).HasMaxLength(5).IsUnicode(false);
            builder.Property(x =>  x.MaNhanVien ).HasMaxLength(5).IsUnicode(false);

            
            builder.HasOne(x => x.ChuyenCongTac).WithMany(pc => pc.nhanVienCongTacs).HasForeignKey(pc => pc.MaChuyenCongTac);
            builder.HasOne(x => x.NhanVienPhongBan).WithMany(pc => pc.nhanVienCongTacs).HasForeignKey(pc => pc.MaNhanVien);
            
        }
    }
}
