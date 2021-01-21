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
            builder.ToTable("DinhMuc");
            builder.HasKey(x => new { x.MaCapBac, x.MaChiPhi });
            builder.Property(x => x.MaCapBac).IsRequired(true).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaCapBac).IsRequired(true).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.SoTienDinhMuc).IsRequired(true);
            builder.HasOne(x => x.chiPhi).WithMany(pc => pc.chiPhiChucVus).HasForeignKey(pc => pc.MaCapBac);
            builder.HasOne(x => x.CapBac).WithMany(pc => pc.chiPhiChucVus).HasForeignKey(pc => pc.MaChiPhi);
        }
    }
}
