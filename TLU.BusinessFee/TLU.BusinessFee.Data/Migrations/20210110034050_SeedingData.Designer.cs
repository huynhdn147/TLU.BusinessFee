﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.Data.Migrations
{
    [DbContext(typeof(TLUBusinessFeeDbContext))]
    [Migration("20210110034050_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "home title",
                            Value = "this is home page"
                        });
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");

                    b.HasData(
                        new
                        {
                            MaChucVu = "QL",
                            TenChucVu = "Quan ly"
                        },
                        new
                        {
                            MaChucVu = "NV",
                            TenChucVu = "Nhan Vien"
                        });
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienPhongBan", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaChucVu")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaPhongBan")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MaNhanVien");

                    b.HasIndex("MaChucVu");

                    b.HasIndex("MaPhongBan");

                    b.ToTable("NhanVienPhongBans");

                    b.HasData(
                        new
                        {
                            MaNhanVien = "TT002",
                            MaChucVu = "NV",
                            MaPhongBan = "a0002",
                            TenNhanVien = "Mai Thuy Nga"
                        },
                        new
                        {
                            MaNhanVien = "TT001",
                            MaChucVu = "QL",
                            MaPhongBan = "a0002",
                            TenNhanVien = "Cao Kim Anh"
                        },
                        new
                        {
                            MaNhanVien = "KT002",
                            MaChucVu = "NV",
                            MaPhongBan = "a0001",
                            TenNhanVien = "Nham Ngoc Tan"
                        },
                        new
                        {
                            MaNhanVien = "KT001",
                            MaChucVu = "QL",
                            MaPhongBan = "a0001",
                            TenNhanVien = "Ha Huy Khoai"
                        });
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.PhongBan", b =>
                {
                    b.Property<string>("MaPhongBan")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenPhongBan")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("MaPhongBan");

                    b.ToTable("PhongBans");

                    b.HasData(
                        new
                        {
                            MaPhongBan = "a0001",
                            TenPhongBan = "Phong kinh te"
                        },
                        new
                        {
                            MaPhongBan = "a0002",
                            TenPhongBan = "Phong CNTT"
                        });
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienPhongBan", b =>
                {
                    b.HasOne("TLU.BusinessFee.Data.Entities.ChucVu", "ChucVu")
                        .WithMany("NhanVienPhongBans")
                        .HasForeignKey("MaChucVu");

                    b.HasOne("TLU.BusinessFee.Data.Entities.PhongBan", "PhongBan")
                        .WithMany("NhanVienPhongBans")
                        .HasForeignKey("MaPhongBan");
                });
#pragma warning restore 612, 618
        }
    }
}
