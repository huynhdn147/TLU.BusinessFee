﻿// <auto-generated />
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

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.BoMon", b =>
                {
                    b.Property<string>("MaBoMon")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaPhongBan")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenBoMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MaBoMon");

                    b.HasIndex("MaPhongBan");

                    b.ToTable("BoMon");
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
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienBoMon", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaBoMon")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("MaChucVu")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MaNhanVien");

                    b.HasIndex("MaBoMon");

                    b.HasIndex("MaChucVu");

                    b.ToTable("NhanVienBoMon");
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
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.BoMon", b =>
                {
                    b.HasOne("TLU.BusinessFee.Data.Entities.PhongBan", "PhongBan")
                        .WithMany("BoMons")
                        .HasForeignKey("MaPhongBan");
                });

            modelBuilder.Entity("TLU.BusinessFee.Data.Entities.NhanVienBoMon", b =>
                {
                    b.HasOne("TLU.BusinessFee.Data.Entities.BoMon", "BoMon")
                        .WithMany("nhanVienBoMons")
                        .HasForeignKey("MaBoMon");

                    b.HasOne("TLU.BusinessFee.Data.Entities.ChucVu", "ChucVu")
                        .WithMany("NhanVienBoMon")
                        .HasForeignKey("MaChucVu");
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
