using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateDinhMuc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 1, 25, 0, 25, 29, 843, DateTimeKind.Local).AddTicks(3208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 1, 23, 12, 21, 49, 430, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.AddColumn<string>(
                name: "DonVi",
                table: "DinhMuc",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonVi",
                table: "DinhMuc");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 1, 23, 12, 21, 49, 430, DateTimeKind.Local).AddTicks(8605),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 1, 25, 0, 25, 29, 843, DateTimeKind.Local).AddTicks(3208));
        }
    }
}
