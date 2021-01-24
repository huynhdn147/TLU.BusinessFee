using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class QuyenTaiKhoanConfiguration:IEntityTypeConfiguration<QuyenTaiKhoan>
    {
        public void Configure(EntityTypeBuilder<QuyenTaiKhoan> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(x => new { x.RoleID, x.MaNhanVien });
            builder.Property(x => x.MaNhanVien).IsUnicode(false).HasMaxLength(5).IsRequired();
            builder.Property(x => x.RoleID).HasMaxLength(5).IsRequired().IsUnicode(true);

            builder.HasOne(x => x.nhomQuyen).WithMany(pc => pc.quyenTaiKhoans).HasForeignKey(pc => pc.RoleID);

            builder.HasOne(x => x.taiKhoan).WithMany(pc => pc.QuyenTaiKhoan).HasForeignKey(pc => pc.MaNhanVien);
        }
    
    }
}
