using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class ChiPhiChucVuConfiguration : IEntityTypeConfiguration<ChiPhiChucVu>
    {
        public void Configure(EntityTypeBuilder<ChiPhiChucVu> builder)
        {
            builder.ToTable("ChiPhiChucVu");
            builder.HasKey(x => new { x.MaChiPhi, x.MaChucVu });
            builder.Property(x => x.MaChucVu).IsRequired(true).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaChiPhi).IsRequired(true).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.SoTienDinhMuc).IsRequired(true);
            builder.HasOne(x => x.chiPhi).WithMany(pc => pc.chiPhiChucVus).HasForeignKey(pc => pc.MaChiPhi);
            builder.HasOne(x => x.ChucVu).WithMany(pc => pc.chiPhiChucVus).HasForeignKey(pc => pc.MaChucVu);
        }
    }
}
