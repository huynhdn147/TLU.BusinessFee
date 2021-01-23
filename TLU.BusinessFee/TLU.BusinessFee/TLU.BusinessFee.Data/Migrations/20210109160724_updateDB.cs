using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVienBoMon");

            migrationBuilder.DropTable(
                name: "BoMon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoMon",
                columns: table => new
                {
                    MaBoMon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MaPhongBan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TenBoMon = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
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
                name: "NhanVienBoMon",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MaBoMon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MaChucVu = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TenNhanVien = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
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
        }
    }
}
