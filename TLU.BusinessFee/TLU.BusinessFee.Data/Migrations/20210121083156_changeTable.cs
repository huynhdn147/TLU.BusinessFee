using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class changeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiPhiChucVu_ChiPhi_MaChiPhi",
                table: "ChiPhiChucVu");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiPhiChucVu_ChucVu_MaChucVu",
                table: "ChiPhiChucVu");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVienPhongBans_ChucVu_MaChucVu",
                table: "NhanVienPhongBans");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVienPhongBans_PhongBans_MaPhongBan",
                table: "NhanVienPhongBans");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVienPhongBans",
                table: "NhanVienPhongBans");

            migrationBuilder.DropIndex(
                name: "IX_NhanVienPhongBans_MaChucVu",
                table: "NhanVienPhongBans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiPhiChucVu",
                table: "ChiPhiChucVu");

            migrationBuilder.DropIndex(
                name: "IX_ChiPhiChucVu_MaChucVu",
                table: "ChiPhiChucVu");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "home title");

            migrationBuilder.DeleteData(
                table: "NhanVienPhongBans",
                keyColumn: "MaNhanVien",
                keyValue: "KT001");

            migrationBuilder.DeleteData(
                table: "NhanVienPhongBans",
                keyColumn: "MaNhanVien",
                keyValue: "KT002");

            migrationBuilder.DeleteData(
                table: "NhanVienPhongBans",
                keyColumn: "MaNhanVien",
                keyValue: "TT001");

            migrationBuilder.DeleteData(
                table: "NhanVienPhongBans",
                keyColumn: "MaNhanVien",
                keyValue: "TT002");

            migrationBuilder.DeleteData(
                table: "PhongBans",
                keyColumn: "MaPhongBan",
                keyValue: "a0001");

            migrationBuilder.DeleteData(
                table: "PhongBans",
                keyColumn: "MaPhongBan",
                keyValue: "a0002");

            migrationBuilder.DropColumn(
                name: "MaChucVu",
                table: "NhanVienPhongBans");

            migrationBuilder.DropColumn(
                name: "MaChucVu",
                table: "ChiPhiChucVu");

            migrationBuilder.RenameTable(
                name: "NhanVienPhongBans",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "ChiPhiChucVu",
                newName: "DinhMuc");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVienPhongBans_MaPhongBan",
                table: "NhanViens",
                newName: "IX_NhanViens_MaPhongBan");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 1, 21, 15, 31, 55, 529, DateTimeKind.Local).AddTicks(8189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaCapBac",
                table: "NhanViens",
                unicode: false,
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaCapBac",
                table: "DinhMuc",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "MaNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DinhMuc",
                table: "DinhMuc",
                columns: new[] { "MaCapBac", "MaChiPhi" });

            migrationBuilder.CreateTable(
                name: "CapBac",
                columns: table => new
                {
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenCapBac = table.Column<string>(maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapBac", x => x.MaCapBac);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaCapBac",
                table: "NhanViens",
                column: "MaCapBac");

            migrationBuilder.CreateIndex(
                name: "IX_DinhMuc_MaChiPhi",
                table: "DinhMuc",
                column: "MaChiPhi");

            migrationBuilder.AddForeignKey(
                name: "FK_DinhMuc_ChiPhi_MaCapBac",
                table: "DinhMuc",
                column: "MaCapBac",
                principalTable: "ChiPhi",
                principalColumn: "MaChiPhi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DinhMuc_CapBac_MaChiPhi",
                table: "DinhMuc",
                column: "MaChiPhi",
                principalTable: "CapBac",
                principalColumn: "MaCapBac",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_CapBac_MaCapBac",
                table: "NhanViens",
                column: "MaCapBac",
                principalTable: "CapBac",
                principalColumn: "MaCapBac",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_MaPhongBan",
                table: "NhanViens",
                column: "MaPhongBan",
                principalTable: "PhongBans",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DinhMuc_ChiPhi_MaCapBac",
                table: "DinhMuc");

            migrationBuilder.DropForeignKey(
                name: "FK_DinhMuc_CapBac_MaChiPhi",
                table: "DinhMuc");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_CapBac_MaCapBac",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_MaPhongBan",
                table: "NhanViens");

            migrationBuilder.DropTable(
                name: "CapBac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_MaCapBac",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DinhMuc",
                table: "DinhMuc");

            migrationBuilder.DropIndex(
                name: "IX_DinhMuc_MaChiPhi",
                table: "DinhMuc");

            migrationBuilder.DropColumn(
                name: "MaCapBac",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "MaCapBac",
                table: "DinhMuc");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVienPhongBans");

            migrationBuilder.RenameTable(
                name: "DinhMuc",
                newName: "ChiPhiChucVu");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_MaPhongBan",
                table: "NhanVienPhongBans",
                newName: "IX_NhanVienPhongBans_MaPhongBan");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 1, 21, 15, 31, 55, 529, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.AddColumn<string>(
                name: "MaChucVu",
                table: "NhanVienPhongBans",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaChucVu",
                table: "ChiPhiChucVu",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVienPhongBans",
                table: "NhanVienPhongBans",
                column: "MaNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiPhiChucVu",
                table: "ChiPhiChucVu",
                columns: new[] { "MaChiPhi", "MaChucVu" });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[] { "home title", "this is home page" });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "MaChucVu", "TenChucVu" },
                values: new object[,]
                {
                    { "QL", "Quan ly" },
                    { "NV", "Nhan Vien" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "NgayThanhLap", "TenPhongBan" },
                values: new object[,]
                {
                    { "a0001", null, "Phong kinh te" },
                    { "a0002", null, "Phong CNTT" }
                });

            migrationBuilder.InsertData(
                table: "NhanVienPhongBans",
                columns: new[] { "MaNhanVien", "MaChucVu", "MaPhongBan", "TenNhanVien" },
                values: new object[,]
                {
                    { "KT002", "NV", "a0001", "Nham Ngoc Tan" },
                    { "KT001", "QL", "a0001", "Ha Huy Khoai" },
                    { "TT002", "NV", "a0002", "Mai Thuy Nga" },
                    { "TT001", "QL", "a0002", "Cao Kim Anh" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienPhongBans_MaChucVu",
                table: "NhanVienPhongBans",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhiChucVu_MaChucVu",
                table: "ChiPhiChucVu",
                column: "MaChucVu");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiPhiChucVu_ChiPhi_MaChiPhi",
                table: "ChiPhiChucVu",
                column: "MaChiPhi",
                principalTable: "ChiPhi",
                principalColumn: "MaChiPhi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiPhiChucVu_ChucVu_MaChucVu",
                table: "ChiPhiChucVu",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVienPhongBans_ChucVu_MaChucVu",
                table: "NhanVienPhongBans",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVienPhongBans_PhongBans_MaPhongBan",
                table: "NhanVienPhongBans",
                column: "MaPhongBan",
                principalTable: "PhongBans",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
