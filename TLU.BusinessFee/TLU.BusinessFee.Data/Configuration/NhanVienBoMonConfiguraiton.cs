using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class NhanVienBoMonConfiguraiton : IEntityTypeConfiguration<NhanVienBoMon>
    {
        public void Configure(EntityTypeBuilder<NhanVienBoMon> builder)
        {
            builder.ToTable("NhanVienBoMon");
            builder.HasKey(x => x.MaNhanVien);
            builder.Property(x => x.MaNhanVien).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.TenNhanVien).IsRequired().HasMaxLength(25);
            builder.Property(x => x.MaChucVu).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaBoMon).HasMaxLength(5).IsUnicode(false);
            builder.HasOne(x => x.BoMon).WithMany(pc => pc.nhanVienBoMons)
                .HasForeignKey(pc => pc.MaBoMon);
            builder.HasOne(x => x.ChucVu).WithMany(pc => pc.NhanVienBoMon)
                .HasForeignKey(pc => pc.MaChucVu);
        }
    }
}
