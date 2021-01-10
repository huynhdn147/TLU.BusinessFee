using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "MaPhongBan", "TenPhongBan" },
                values: new object[,]
                {
                    { "a0001", "Phong kinh te" },
                    { "a0002", "Phong CNTT" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: "NV");

            migrationBuilder.DeleteData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: "QL");

            migrationBuilder.DeleteData(
                table: "PhongBans",
                keyColumn: "MaPhongBan",
                keyValue: "a0001");

            migrationBuilder.DeleteData(
                table: "PhongBans",
                keyColumn: "MaPhongBan",
                keyValue: "a0002");
        }
    }
}
