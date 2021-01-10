using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "home title", Value = "this is home page" }
            );
            modelBuilder.Entity<PhongBan>().HasData(
                new PhongBan() { MaPhongBan="a0001", TenPhongBan="Phong kinh te"},
                new PhongBan() { MaPhongBan="a0002",TenPhongBan="Phong CNTT"}
                );
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu() { MaChucVu="QL", TenChucVu="Quan ly"},
                new ChucVu() { TenChucVu="Nhan Vien", MaChucVu="NV"}
                );
            modelBuilder.Entity<NhanVienPhongBan>().HasData(
                new NhanVienPhongBan() { MaNhanVien="TT002", TenNhanVien="Mai Thuy Nga",MaChucVu="NV",MaPhongBan="a0002"},

                new NhanVienPhongBan() { MaNhanVien = "TT001", TenNhanVien = "Cao Kim Anh", MaChucVu = "QL", MaPhongBan = "a0002" },

                new NhanVienPhongBan() { MaNhanVien = "KT002", TenNhanVien = "Nham Ngoc Tan", MaChucVu = "NV", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT001", TenNhanVien = "Ha Huy Khoai", MaChucVu = "QL", MaPhongBan = "a0001" }


                );
        }
    }
}
