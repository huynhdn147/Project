using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    class ChiPhiCongTacConfiguration : IEntityTypeConfiguration<ChiPhiCongTac>
    {
        public void Configure(EntityTypeBuilder<ChiPhiCongTac> builder)
        {

            builder.ToTable("ChiPhiCongTac");
            builder.Property(x => x.MaNhanVien).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaChiPhi).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaChuyenCongTac).HasMaxLength(5).IsUnicode(false);
            builder.HasKey(x => new { x.MaChiPhi, x.MaChuyenCongTac, x.MaNhanVien });
            builder.HasOne(x => x.chiPhis).WithMany(pc => pc.chiPhiCongTac).HasForeignKey(x => x.MaChiPhi);
            builder.HasOne(x => x.nhanVienCongTacs).WithMany(pc => pc.chiPhiCongTac).HasForeignKey(pc =>  new { pc.MaChuyenCongTac, pc.MaNhanVien } );
            //builder.HasOne(x => x.nhanVienCongTacs).WithMany(pc => pc.chiPhiCongTac).HasForeignKey(pc =>  pc.MaNhanVien);


        }
    }
}
