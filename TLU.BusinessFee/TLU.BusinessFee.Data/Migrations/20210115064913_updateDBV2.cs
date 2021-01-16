using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateDBV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true);

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
                name: "ChiPhiChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SoTienDinhMuc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiChucVu", x => new { x.MaChiPhi, x.MaChucVu });
                    table.ForeignKey(
                        name: "FK_ChiPhiChucVu_ChiPhi_MaChiPhi",
                        column: x => x.MaChiPhi,
                        principalTable: "ChiPhi",
                        principalColumn: "MaChiPhi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhiChucVu_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhiChucVu_MaChucVu",
                table: "ChiPhiChucVu",
                column: "MaChucVu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiPhiChucVu");

            migrationBuilder.DropTable(
                name: "ChiPhi");

            migrationBuilder.DropColumn(
                name: "NgayThanhLap",
                table: "PhongBans");
        }
    }
}
