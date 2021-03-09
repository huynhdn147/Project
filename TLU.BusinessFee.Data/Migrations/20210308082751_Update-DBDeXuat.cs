using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class UpdateDBDeXuat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 8, 15, 27, 51, 47, DateTimeKind.Local).AddTicks(9777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 7, 18, 17, 44, 273, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "deXuatThanhToans",
                columns: table => new
                {
                    MaDeXuat = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenDeXuat = table.Column<string>(nullable: true),
                    Lydo = table.Column<string>(nullable: true),
                    TongTien = table.Column<int>(nullable: false),
                    ThoiGianDeXuat = table.Column<DateTime>(nullable: false),
                    TinhTrang = table.Column<int>(nullable: false),
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deXuatThanhToans", x => x.MaDeXuat);
                    table.ForeignKey(
                        name: "FK_deXuatThanhToans_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAQYn+GM2HDuq1qx3nsTGBammaTH9qZnf8AJTB0hZlBrq8Inzv+fAHdotuiocwJFfQ==");

            migrationBuilder.CreateIndex(
                name: "IX_deXuatThanhToans_MaNhanVien",
                table: "deXuatThanhToans",
                column: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deXuatThanhToans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 7, 18, 17, 44, 273, DateTimeKind.Local).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 8, 15, 27, 51, 47, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIP7W1jWXwmIEVFZEYL2+uiHYBHUNogyGmvoL2hLcdpYnVabzaLN0YdGydE7ZuNUZw==");
        }
    }
}
