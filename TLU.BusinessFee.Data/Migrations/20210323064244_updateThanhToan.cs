using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateThanhToan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeXuatFile_deXuatThanhToans_MaDeXuat",
                table: "DeXuatFile");

            migrationBuilder.DropForeignKey(
                name: "FK_deXuatThanhToans_NhanViens_MaNhanVien",
                table: "deXuatThanhToans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_deXuatThanhToans",
                table: "deXuatThanhToans");

            migrationBuilder.RenameTable(
                name: "deXuatThanhToans",
                newName: "DeXuatThanhToan");

            migrationBuilder.RenameIndex(
                name: "IX_deXuatThanhToans_MaNhanVien",
                table: "DeXuatThanhToan",
                newName: "IX_DeXuatThanhToan_MaNhanVien");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 23, 13, 42, 44, 112, DateTimeKind.Local).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 16, 23, 46, 11, 968, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeXuatThanhToan",
                table: "DeXuatThanhToan",
                column: "MaDeXuat");

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaDeXuat = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    ThoiGianDeXuat = table.Column<DateTime>(nullable: false),
                    TongChiPhi = table.Column<int>(nullable: false),
                    TinhTrang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => new { x.MaHoaDon, x.MaDeXuat });
                    table.ForeignKey(
                        name: "FK_ThanhToan_DeXuatThanhToan_MaDeXuat",
                        column: x => x.MaDeXuat,
                        principalTable: "DeXuatThanhToan",
                        principalColumn: "MaDeXuat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGCKFlurBJs7qvjHubeSep7uKyGRbrT0mCRNCjMd6nvMXQD9oW4D7bBb1PgCCO96og==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEALZmcX5fN2xal8mw2HX6vrFWEYBlraLX+cdEk6H+5xe+4Ad0/ztySKgJwq8cb697g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKsVUp06ClE3VA11RqgOAFm3USNBcc0bdF/P9VHqv00wb2Liu91vArw6x6izOzw0BQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB7BPsRjuHPPCWU6U1zkkZ9AcLEuuGPqszuxmyjW59Lric/tlgewqsPcnvFtpwO0fA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBVJ1NC8QK9GGOwsKyJbLKDQZ987zlgchzql7wX2H4iz4oX5IsnpHfiazNok9+DBaQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF45bQLXxEQ4UZIpzF9b8pn51lHiXcuZXMI58K3kR33cKVFTzcBsgKw8OqdaPRR/tA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPPPLDv8/Mj784QGaXrC7O9p9f3h8/3gqTWEZj2c++5hXvmZGL/B6bhPFWtO/hhf7Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIi6QbJ35yl9dTTp3M9ekYNej6Oih8nH6j2xWzHksgujy0Hq1firDJ+ysSaK3r+j2A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECMdPkM4J78nWFW9KjwfZqS1U9hjqm1dT+kPsxSkbimreXqhP7WkrcTMpkZ9iiK5qA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELP0SghEeUat+gra1oez+n4wbHx9FdSkjP2EwzlDtfZBNbvRrZ/NyPSo3hmRTTgp1Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN4X6sRzLpHTWpLcpDloQElTJpLigV3ztrpL6EL8HpH7G2BnkLc8d77grZ5Kn90exQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBjFyQVhZUkSL39c46bVoGlWiAl2vkAyI8rcj4rRovXWyGp2JUzzWuNmn7hde4ISzw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN/jhNuJOmD+yu2IDMK03IaSNAL09C5g4i8Ez7U74SmsBB0F0XW1gSFZVAsrfr2btg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIvDJA4945IC6VbgGZmaHcT7LcPP7IIXqQiVdkfka5KSSRLiXzJ2TTuqyHnnZWPtHw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECg1WsA6GiKsaidy6E45p9o6Y+gGXOcw4R1Qfes/M1+H+d3BvOtMCDB3Ub/3Q/eTEA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAov7Wj/uQyMZcvL51EDBTWfhdVzaBrZXrTP/mH1owzxZ1hDIlhWxrLyuT3atz1eKQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJTg15XIIi9OcBXglRzd3fkTB64Zhy7uPpgFAdBNh1GzkdQRifnj/q1wPYOidTQ6Gw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDgDOQAUiguWaksQZ8RKaJvr6NT17cvB7mKhx9lpGq9W1/UG291M+ssJGxaMZnfwsQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBGYPYdEeTsuA27AI47kTI1MEQAI/OdyTDIMcjxj3cm+J8huy6QxncooJzgbJgEnIw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF27z4NMqV+z47VvKiIKeVFugwktJY1UNyY8F9aRRovO0OcdglswNvZ78aA8RAwsrA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPW9zkmEbtmberNtTryjnWsY7eRrwJk+FoogF8a0DrrhBbIl16ficq9Jzw18UTI6IA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPFDIL4BXvEhbfVc8o2hxg+nIWx03GYM48sXofwpkXgO9WqiblGeAP9HIkkpjt13aw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHu8iuxZ6fO+m3eVLyXDeMTRs54BzzvAjSsKQYvd8jXhO1e85N8guQiEpDdJcyGCfw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE16zC5HfTYVPTuwk5T4Yls5UrVgHM7X9aVXs3pLttZtkJHskO+yRF+pOg+IB20T9Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE10eU6t3jAI7N/bYxF3hzP39x2gI55bsJ6XlD2H6QEojBQ4I91KwsgbRKYWZbrC9w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIe4Tr0QlLW0rLmOS4sFhthbxCrFjaY+YxsCjXCLTkS7tbVOcGIivEOs94nbMdt/cA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMdXOVLSDOL4p/AWNZBpzb7qo7w1SIKtkInwiNtY3jUjKXtJf25ihq16+TXm57oXkw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB7tsPlPs7ib30By1e/it66ADTubaBB2Vw/wadpDHNQsJuJ0aNYbxNyMKznLQQnWIg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECBRELXX5UfONtx6iCfxKhG+/W1tJ4pS7658jowwxP0znn2ERHkIPOXQ9lnSaIO+SA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE7rkqVtkc5f9wzMsjF1rKjHNls8Zgsa48SBeOzCIqlXeSeOTs5yTQdwrL/fbiPStA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKPREFUQCDzIJezI/A/j7YDX2/mKcB1Agj/DajIavdd2CeNendPw8ZQXlVYskNWe3g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENai20afNFtCOoiO8IAL4fS/PVY/6H1jDVpzgcqy4rjC+DHu3cJ9sa6HhGnmTwxSeg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ4xQiMIcnDgjdxtqtVpvHt62PhN8KzFuO04oS4sdV396g8Pz8TAdW+QHPKifTgoJA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEP/mhRnTa2vZpZijY1OuXYFyOVTKr+0pmG8mvoBFzvszwvRkBCd/AiXH4Gxc9db/9Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPOQtCSL8OS0uE0oKrsfV2/Zd8akQuqTC5ViirhdyOl4imKfPLfUZ4SmI9wl1Em8YA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKT59FME38HWmzn5t2tnJoPXRzaqhsGdIqamx//tvYGg+ceAe6wJw3OG3OMCep9RLQ==");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_MaDeXuat",
                table: "ThanhToan",
                column: "MaDeXuat",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeXuatFile_DeXuatThanhToan_MaDeXuat",
                table: "DeXuatFile",
                column: "MaDeXuat",
                principalTable: "DeXuatThanhToan",
                principalColumn: "MaDeXuat",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeXuatThanhToan_NhanViens_MaNhanVien",
                table: "DeXuatThanhToan",
                column: "MaNhanVien",
                principalTable: "NhanViens",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeXuatFile_DeXuatThanhToan_MaDeXuat",
                table: "DeXuatFile");

            migrationBuilder.DropForeignKey(
                name: "FK_DeXuatThanhToan_NhanViens_MaNhanVien",
                table: "DeXuatThanhToan");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeXuatThanhToan",
                table: "DeXuatThanhToan");

            migrationBuilder.RenameTable(
                name: "DeXuatThanhToan",
                newName: "deXuatThanhToans");

            migrationBuilder.RenameIndex(
                name: "IX_DeXuatThanhToan_MaNhanVien",
                table: "deXuatThanhToans",
                newName: "IX_deXuatThanhToans_MaNhanVien");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 16, 23, 46, 11, 968, DateTimeKind.Local).AddTicks(1685),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 23, 13, 42, 44, 112, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_deXuatThanhToans",
                table: "deXuatThanhToans",
                column: "MaDeXuat");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPY+nfThNzOvjsYlQdkpdC+GAj8CFNeZZrdHxbgZ0f9T02V2GWrDvGvTLpKAz4NeXg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHJVpagEspSQ0p42jpsuuAJfCEYgzKqCJtfRn9UbK+dlz1s24PcxDrTPVjh7T9D6XQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELHbzmloXVxUwSu0rvLJgAamTQ2hiNIS4RtKqPdn0SxyweMwfajWxtgIpW+WRwgClQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAPY03OUIrvvvd4gF7LnCvSWYHRhOIquEkUV61GUtj0QsryHGFTjSgsIknVKkj1UDg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBL10ijydyldjyn3W2miUJdl1PrckFpx5aj1c/eGT2AbTPewyTuMQpouTL7JfivKmA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAQ/FXNacGOXbhaskhMYnzgksokXOfaTsKlyKbkljCc7XMKcikjJbgiIMQKmrD+kRw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPXt9SAo3kJ1EFgfMxobx3Fb3lSHWeLx1toFnm+JjAuuWP7ULMIiAFq92RkcckaUsg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGD7bs7Rrf7I/Vu4TPP/f2ddXCNJ18lDn4v0wrllF2LlaGb5JS9s08IgZJNzI6mUgg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKl15I2fUMKBWyvvEaIf6WUJ5+CQcpDEpoo05lDQnVm+GzG/Usls4WTm9hBQAdQ1ZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOvFWchC/mUfvSV4TlaF2lr9r/NJe0XIsBLJZuHPngT9tgv0xcG80nSzbps56g256w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHH8nw/9rFbN5EZSlbLt9+dC7OJuBUQjulzzGQ+BhBYGaYg8oVPXfaAG7tyJCPGlbA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDrlDp7vIpupwTvZEjExEowRFstOvnZN8n/LGdAUs5ZeciAJZ+5tQAQfeEUxjjotGw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ9+868NqhU4oKEGoSdeWIP5DdVugzxjBjJPUjQ1ZynMgNnsJmIlWVKou4ZGAXmWMA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOCOAJoXkl+MS6qL0NTIYQYK3WVQN9jqilsyXWvZeeWqS0Ukj1ip3FXXa0eZN/etRQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI0OtooXYfy2ZA7JUA7F+vFiUt7hopQZy5/1EpDlJb/VyK5cSu71XdJfEUowClCrRQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMJcNAGd95tM39lp6K5ju7YaoB7HlNr2fOcMbXBEakB/Ibxy8qdj6hUqWVASAiU8Hg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOBv69DuAurDYN0ITcBs4cM0ny2kiIIEmBDryVNclKgH5z8aT+AybUZzCTmUSI3Shw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ1ml5HjGjRXDtrVdsWwZKWbN3X1bhS9MglzH4p2QMt82/9wV3H28XumroiWzhsoHQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELr1QdcGwX9xwUxhdif5DGfoZ/IoyTrUEBiVXJtjUFzjSvLEyozN6pipyKJHb5wxMA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMFM+j5PdUpv8gI2XV3fAx67suR1LwlOD5uEFANYv0gn4wTqxsCo2KORoYIOpLx1VQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBLiQXXFpopaq09kl1TktW5HOcUm+s5eOhdqphpMK1CHGrqb21R4d1fLWhbDfXrkyA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOkS7cBxvnxwlBpEkDwU7MwNuO4KJrE32LpKWoFWShvD1qQrZJjvTNISVDvPpCOfqg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN8RtilXSOp9hL8SiTAeiymsZLbrd++n2y8vSVllm0quqdiPB5u+6nzhXvUiittxxg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEM7y9878EqXRKm9eswN7wOQbZkBqCFcqqbwA/0JLTGkKZvfkWEL2DJthQERSTGs9mw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEG+z5ltsORE7McMMA0yWg0lkBhNZ/Nr9wEf5ye98HwY/DAcUuuymtZJX8Azsuv5XaQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKWbo6POK16nGnady36H3nuaerIpuGqdjRL3htzzHsnXpgQQR/Uh7pHs8tQqT7ffoQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHPI5G/O5+2Ee+4vtw31faucVPCb1eM6X6NxydN7P7CjFdBMgD6UvvY6fKGKeb3NkQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELAm64AZsmu7rtHBX82v7QjgJzgDpt4Zjs5VuWFZK7E5tlV2JB/hX3h3sy+o56/9LQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAthp/+VjGosuJWAoubMW1XuDmyWUKwxILt2a+v8ASwpAsPWR9SH3CVSMPuLWIRSdw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIf0oSOmkpjgZzyX/M5JGgF/rYNZXbtWxBqBPAAOZt59eEDMhxjdDGhymtLzR3y3bQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPOJIbI2I9ZSDUDUIez1FqpvXFg4BvzAXe234h1d+drf4SvcYW6sPMEnkAgR9/g+Ng==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAb6+5L7ReZE+1vnHyMY7+bKxfgbXbOMaPUISSp35moskw3YlbANCTQhKz9/NOFBbg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBsiAahewEu+apjYa34JAaTU0CCDI602ck5q99q1vadvu48EJllIpXlKXlFx3mC1Tw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGJeLT4mERV5ocemnMGPeV4WiXZkgoVy6/fDHm9kzoPTdgmK6jKs5LzWkhrAmUeXaA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMLlL/H1FXZCZZ5QrtHCMtZDY9XkiU4QkJtjCE4md2BegPPyh7LG9VF8pRqeLHXlVg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPMlFIUL6aCTpf750czcaZrqg5SEryvnbRtn3bCTEEehXZQyu0rA278J1Qco/FmqpA==");

            migrationBuilder.AddForeignKey(
                name: "FK_DeXuatFile_deXuatThanhToans_MaDeXuat",
                table: "DeXuatFile",
                column: "MaDeXuat",
                principalTable: "deXuatThanhToans",
                principalColumn: "MaDeXuat",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deXuatThanhToans_NhanViens_MaNhanVien",
                table: "deXuatThanhToans",
                column: "MaNhanVien",
                principalTable: "NhanViens",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
