using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 9, 16, 41, 21, 772, DateTimeKind.Local).AddTicks(5643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 8, 15, 27, 51, 47, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE5uA/+ylklu3QJma4goU9GVWpAilItQoV13yG6XwrNreiyC3Mg5hEkhRM8BNOEomA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 8, 15, 27, 51, 47, DateTimeKind.Local).AddTicks(9777),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 9, 16, 41, 21, 772, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAQYn+GM2HDuq1qx3nsTGBammaTH9qZnf8AJTB0hZlBrq8Inzv+fAHdotuiocwJFfQ==");
        }
    }
}
