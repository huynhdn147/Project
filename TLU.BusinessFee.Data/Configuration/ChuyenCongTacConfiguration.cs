using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class ChuyenCongTacConfiguration : IEntityTypeConfiguration<ChuyenCongTac>
    {
        public void Configure(EntityTypeBuilder<ChuyenCongTac> builder)
        {
            builder.ToTable("ChuyenCongTac");
            builder.HasKey(x => x.MaChuyenCongTac);
            builder.Property(x => x.MaChuyenCongTac).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.TrangThai).HasDefaultValue("chua thuc hien");
            // [Required, Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
            builder.Property(x => x.NgayBatDau).HasDefaultValue(DateTime.Now.ToString("MM/dd/yyyy"));
            //builder.HasOne(x=>x.chuy)
        }
    }
}
