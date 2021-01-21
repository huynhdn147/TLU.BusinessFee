﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.Data.Migrations
{
    [DbContext(typeof(TLUBusinessFeeDbContext))]
    partial class TLUBusinessFeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.CapBac", b =>
                {
                    b.Property<string>("MaCapBac")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenCapBac")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MaCapBac");

                    b.ToTable("CapBac");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.ChiPhi", b =>
                {
                    b.Property<string>("MaChiPhi")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenChiPhi")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(true);

                    b.HasKey("MaChiPhi");

                    b.ToTable("ChiPhi");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.ChiPhiChucVu", b =>
                {
                    b.Property<string>("MaCapBac")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaChiPhi")
                        .HasColumnType("varchar(5)");

                    b.Property<int>("SoTienDinhMuc")
                        .HasColumnType("int");

                    b.HasKey("MaCapBac", "MaChiPhi");

                    b.HasIndex("MaChiPhi");

                    b.ToTable("DinhMuc");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienPhongBan", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaCapBac")
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

                    b.HasIndex("MaCapBac");

                    b.HasIndex("MaPhongBan");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.PhongBan", b =>
                {
                    b.Property<string>("MaPhongBan")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayThanhLap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 1, 21, 15, 31, 55, 529, DateTimeKind.Local).AddTicks(8189));

                    b.Property<string>("TenPhongBan")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("MaPhongBan");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.ChiPhiChucVu", b =>
                {
                    b.HasOne("TLU.BusinessFee.Data.Entities.ChiPhi", "chiPhi")
                        .WithMany("chiPhiChucVus")
                        .HasForeignKey("MaCapBac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TLU.BusinessFee.Data.Entities.CapBac", "CapBac")
                        .WithMany("chiPhiChucVus")
                        .HasForeignKey("MaChiPhi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienPhongBan", b =>
                {
                    b.HasOne("TLU.BusinessFee.Data.Entities.CapBac", "CapBac")
                        .WithMany("NhanVienPhongBans")
                        .HasForeignKey("MaCapBac");

                    b.HasOne("TLU.BusinessFee.Data.Entities.PhongBan", "PhongBan")
                        .WithMany("NhanVienPhongBans")
                        .HasForeignKey("MaPhongBan");
                });
#pragma warning restore 612, 618
        }
    }
}
