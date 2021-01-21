using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class changeTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CapBac",
                columns: table => new
                {
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenCapBac = table.Column<string>(maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapBac", x => x.MaCapBac);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhi",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenChiPhi = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhi", x => x.MaChiPhi);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenPhongBan = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 1, 21, 16, 51, 32, 942, DateTimeKind.Local).AddTicks(2632))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "DinhMuc",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SoTienDinhMuc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinhMuc", x => new { x.MaChiPhi, x.MaCapBac });
                    table.ForeignKey(
                        name: "FK_DinhMuc_CapBac_MaCapBac",
                        column: x => x.MaCapBac,
                        principalTable: "CapBac",
                        principalColumn: "MaCapBac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DinhMuc_ChiPhi_MaChiPhi",
                        column: x => x.MaChiPhi,
                        principalTable: "ChiPhi",
                        principalColumn: "MaChiPhi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 25, nullable: false),
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_CapBac_MaCapBac",
                        column: x => x.MaCapBac,
                        principalTable: "CapBac",
                        principalColumn: "MaCapBac",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DinhMuc_MaCapBac",
                table: "DinhMuc",
                column: "MaCapBac");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaCapBac",
                table: "NhanViens",
                column: "MaCapBac");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaPhongBan",
                table: "NhanViens",
                column: "MaPhongBan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "DinhMuc");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "ChiPhi");

            migrationBuilder.DropTable(
                name: "CapBac");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
