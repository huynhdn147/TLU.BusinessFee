using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class TaiKhoanConfiguration : IEntityTypeConfiguration<TaiKhoan>
    { 
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.MaNhanVien);
            builder.Property(x => x.MaNhanVien).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.PassWord).HasMaxLength(250);
            builder.HasOne(x => x.NhanVienPhongBan).WithOne(pc => pc.TaiKhoan).HasForeignKey<TaiKhoan>(pc=>pc.MaNhanVien);
           
           
        }
        
    }
}
