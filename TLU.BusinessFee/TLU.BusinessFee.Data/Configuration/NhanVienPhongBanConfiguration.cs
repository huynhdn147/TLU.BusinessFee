﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class NhanVienPhongBanConfiguration : IEntityTypeConfiguration<NhanVienPhongBan>
    {
        public void Configure(EntityTypeBuilder<NhanVienPhongBan> builder)
        {
            builder.ToTable("NhanVienPhongBans");
            builder.HasKey(x => x.MaNhanVien);
            builder.Property(x => x.MaNhanVien).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.TenNhanVien).IsRequired().HasMaxLength(25);
            builder.Property(x => x.MaPhongBan).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.MaChucVu).HasMaxLength(5).IsUnicode(false);

            builder.HasOne(x => x.PhongBan).WithMany(pc => pc.NhanVienPhongBans)
                .HasForeignKey(pc=>pc.MaPhongBan);
            builder.HasOne(x => x.ChucVu).WithMany(pc => pc.NhanVienPhongBans)
                .HasForeignKey(pc => pc.MaChucVu);
        }
    }
}
