using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class CapBacConfiguration : IEntityTypeConfiguration<CapBac>
    {
        public void Configure(EntityTypeBuilder<CapBac> builder)
        {
            builder.ToTable("CapBac");
            builder.HasKey(x => x.MaCapBac);
            builder.Property(x => x.TenCapBac).IsRequired().HasMaxLength(25);
            builder.Property(x => x.MaCapBac).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MoTa).HasMaxLength(250);
        }
    }
}
