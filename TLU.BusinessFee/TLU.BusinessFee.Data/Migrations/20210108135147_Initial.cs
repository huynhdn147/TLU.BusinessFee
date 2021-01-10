using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class Initial : Migration
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
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenChucVu = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenPhongBan = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "BoMon",
                columns: table => new
                {
                    MaBoMon = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenBoMon = table.Column<string>(maxLength: 25, nullable: false),
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoMon", x => x.MaBoMon);
                    table.ForeignKey(
                        name: "FK_BoMon_PhongBans_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienPhongBans",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 25, nullable: false),
                    MaChucVu = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienPhongBans", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVienPhongBans_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVienPhongBans_PhongBans_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVienBoMon",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 25, nullable: false),
                    MaBoMon = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MaChucVu = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienBoMon", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVienBoMon_BoMon_MaBoMon",
                        column: x => x.MaBoMon,
                        principalTable: "BoMon",
                        principalColumn: "MaBoMon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVienBoMon_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoMon_MaPhongBan",
                table: "BoMon",
                column: "MaPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienBoMon_MaBoMon",
                table: "NhanVienBoMon",
                column: "MaBoMon");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienBoMon_MaChucVu",
                table: "NhanVienBoMon",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienPhongBans_MaChucVu",
                table: "NhanVienPhongBans",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienPhongBans_MaPhongBan",
                table: "NhanVienPhongBans",
                column: "MaPhongBan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "NhanVienBoMon");

            migrationBuilder.DropTable(
                name: "NhanVienPhongBans");

            migrationBuilder.DropTable(
                name: "BoMon");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
