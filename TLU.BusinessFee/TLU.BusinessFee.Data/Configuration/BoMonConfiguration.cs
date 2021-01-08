using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class BoMonConfiguration : IEntityTypeConfiguration<BoMon>
    {
        public void Configure(EntityTypeBuilder<BoMon> builder)
        {
            builder.ToTable("BoMon");
            builder.HasKey(x => x.MaBoMon);
            builder.Property(x => x.TenBoMon).IsRequired().HasMaxLength(25);
            builder.Property(x => x.MaPhongBan).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaBoMon).HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.PhongBan).WithMany(pc => pc.BoMons)
                .HasForeignKey(pc => pc.MaPhongBan);
        }
    }
}
