using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 1, 20, 32, 55, 645, DateTimeKind.Local).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 30, 14, 15, 27, 991, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNhanVien", "MaCapBac", "MaPhongBan", "TenNhanVien" },
                values: new object[] { "admin", "C1", null, "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC2x+RlRG4F5OT+A3vB3D3c3zWCbGzr3ev7V3dkM5OjelOMqpONhw8wYZ0k4Qu++VA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOLCWxTVLTIJuI4jSRsZg6DScUSek7Q1zTjZgG92SddKSbyGGbzR2O5hhAW5qJAGsA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEG0X5Y0AGaqNATPYsuMUVnfoyRghemGNdmcfGRmlYIQ4iP+6FdDjejvDUBwDNJhkOg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGRMG8bQlieltzNNOxroI6BKPiNT2wgraZQPA5zeFM8Buv3ALvL2QGqJBbQ4hCLB6A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMi5jlqfpGgZ1tNZa/xJxq3zLgHvJKt1+DrZh946mj1LExf0KMnVYFtBCJuZVCIP+w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEpX7jM9OC1KAOdsUAjNtpk4Pqyr7LhsmAMO2d2KchL/mYWSL4NJEV6Kh1XAsPivEA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAfMuuFKFeFsUGljKAAIXTxMKQUpAJc2RpqyamtOVHCewC9JWk6G56WrJsAGGvmyaA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEExtngJKTI28eDkD8CX49okLwPRgwehdPPFxm0l6hGcVj3lyjD+mudvph5i/weFEqg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPwZM5cSvwMAJCwBoHIJd2EDKN53ctDLpGjoEqBXtfdMoqD4jyGVjkhkF4T4iH1pIA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEM4WmQmIiy4PaW2A1kyEa12xLUn7hR5cBEdNMn3D8x4I4wxvaa1HcikPrxlts4vqgw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDpRL1+cL60dENU9/FX/moF8cotZm7vCeCaf7q2fhlVjFT+NOWW4qv61G1mVmnkZEg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOomSd1JM/Pwpcj51bIwaNzhx8L8yuvR5iF2l5tdScOo0VomxM2rENrfo56Wx78kag==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKiuCziaCoK+iO3A5VCZXJtf2IBifHmbbuOntxiPaPFjTCQ5jiKjv3Rt/lfrXA5BgA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF0nZTvFHCxORir3sYMOs4TmiQyyH7Utgyd2aOZq3T6+WT4W9fFDPEn76k+vtsWOVQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEQ5vc5XDiWXBryoPsIpO0vxjZKnGmKZpkRtwwk+/clTIQq++XGh+JaP9n98e/p8Mg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKFiDnSeMI4KPBVRz0S9gfZmjb/ytQI8uPlzgxI1bGUTYAw/oteqCCuVDjSLf7/vSQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHwHAHPnEFWi3g8Wy6zNMnSN+Q4DXHPMdA3hH1fF1Vs7UYV4dUbGDlEKYjIuJJ5IaQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECxxFKKzBijM3TDnXgPJn7xqyNHeu+mknqyrns7/KzNKNGC130xy/iH9DkC2T/9GqA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOVNJGnNJsp4EQj7kDVc1cn8qBRyeE8P8JJljrYTyj3scI62aUWe5PgqaDyGokPfHA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMX2c77pGhCogx3fiUu9GziwD6p7w5b/fV2G5walaqsV70M1U3I+ZYW2j08MR+mhcA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJrL+9EAPnNPHtSCYS36pFxPtef4FXMO1S7vNlyZpGTvwURERly77++mRLXrYUan1Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI5Rrc51LZE4VQZzeLYlOgEg/E10+V2Na9U49T11sbsnQVcaqK4WmEcBd61uUGSIvg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF4PauWueKdVIWRvk7V1eHtq6w9s1dKZxJot3ydRrdk9JkQVoXuSKLU9/eHqxx8ckQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECjcEKpTHmTKtaiuww4iy5GYTih8HwG+eR6nuTdQugdwOjFP5WHVUK6ueqQ8ujjA5Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEH6mGAm03/8+SxSRAPj8NWz0f7dPAYCCKk7JrrFQX5U+ePb7VuShs1PYUehVd5nhpQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEORbnEC7fn6OIvUrxVYbrL2N3P4jbSxWWTnDYuWTTTABeSwxW1i5Yu397GX3UMk4Vg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPYrxSAmFZkI1w3blVIhMB7m7ps+Jw7tapnahUK45kZ7psnU26DyqnyrbI2Kl8BY7w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGAlIhrj0zF0rPXYl6MHFPmLCzZC1BnKMvqcit96XzBLQrOZ7DgiTCkjeotSgElW1Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKpnQK9FOPdT+5+c9wKXqV3bDGijadv/1fzgAO5kzeNUvG5Nc+zYF0VWLwq99LrsYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGMb1TwyM8jOvv5sPycgCRjp/cHu9vmiaGM9XccJpl5MNtotL+a8qBcyVTFLdCgR+g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFMKwwZgwpqkLelX77y4kpgI+s2Zb0xrfzLRopuVlu5m43iXwNX46PJto5++1DZV2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKJMJVld3VOt8VZIOwjHR2//nnsg8YKYWXHPRj3EYi+aaEKVGczzFHTKZ/ySiEi40w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGF22qbh9yBOHW+rWRUEOXo1gZ3mMiGE3h445jL129VWPNKU9CivjSXTYYOdBRsEbg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEABowkkFONxj6GvB72GHj46Nw2JTX8q9rHWIUuVMeFf8aSImLUvPHnnOitJiOMsPwg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE4YeunfKyo3zynlU43GLmtV/bsQDrOcfDzMjnTCqbDQZL+2l8lsOFl3UjywwDJy5w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJGCcbGRVaHF+tlfNP1JuHK250Dy/3i7XoAACeQtk65iIEPY6V9GCsGOvzwYrtZt2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK/HUvKAmDInRAUSJ7RkyhED1tFDMPoO2B3aEyozesy5ZkTHsmatFphdmpNhB+O1Nw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK/y0Jx5ypjYXf14u0grfzWkDoB3K+dIYAiio9oAO47a6ZRNRYA9+yETIo7Rp3V5hQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELgY6oU/hOn7AOUkEg49oj/7NZbLqNgbF+eF+jmg2NSGppjueO/jdhTnl8XUX8HmqQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHWkRUEHt2B0mcIkVCFT7DcgG3q+ngel2s/TE1arHLCA6LsDwuy6OCgzymUm6iU8Ow==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB/OYHO17scywlV3KS9EYXcUjoNc9D4e2fbWw/ozyS/NdL6cjkbdsRuai5xDFYPj+g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENQUtN/I2/UTTXhLKSCyWXWxm+CmVpTmBNtwRR9lnkJBkLS2Az4apAHp7rvcYFfz2A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFD/xcd89d1KknlvxEdljFVw9eXODfwAeoY/abXhVKPk7NIswm5XsSaEWYRy3BaO/w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC9i3toCjQqBf7fvLaSqGtfCzfYma8ZhYCkIC2detTi63Qo0285uaaDAEyruLpM1pQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMVLn/5gz4BzZ4XZ4CKm0LZtnGPe+CmC4TtZWDqff3PsMEQ3/FW2PO83fLcFNo93Qg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGQttwDv5OWqQ/1rDEeq5ZVZ/V3kVbS0W+cHdZKQR1Fjq1DoP19BhTePSiiq1ijoMg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAk2wu/BlOYHUnqXCzhc4nMKrWac7edffEjU2WYMf6H6YuCldYgoMoD1o671x1ITMg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEP775aL2EIk8h6H3E+PP0EM+LM6xzgqDwQciVEXmKTPQCp/BE0B30T91h/jpMLGhHw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC27LhYBJAHrYzM/q1k1V8/LTEjwtaHrKhy/gZkM7ps9u08TCRg/TUpfCfUush9FQQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIg8Agz60wYCnncj9RHrD6zVyD/r/rtjz732qmGPWmXkUTOO06Ob+pQhJ7C1nMMfEQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELZDHT0G9tKgcVlAACDCort44UkEdh2A8ct//QcSgXJp7G++pWuRZCKpxDF0IvDeVA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENS++rN3GLINUNaDr/m1EdQ9ogZd1xpMALUqqIMLBI+9aQaIAhBEpIZoWPqBCFyQrA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENADhOOdgMN3uRdXPFc+dsFsR+lV5q0xv8p0IcduyZTyT9sIGnL/L219v1SfsK9P5g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENrlcMg6Tm+mNFeVOksfXuthAD427CtbkNHVlEAGljqz1JXHHDfaMjnFwt0DXWSGww==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEADitUasXxGQYvhXKvcMb6Pa2sc0at1ZlpMfn636K9Pty8HTqM2yBWeNHWz949Zd0Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF3E+WBwiBZKCbjuBSCp1aQyTEXAcmv3wTClJ6kIv+PkQoEn0yy6USesmGYbgiWgQw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI/fN2iNwD87imN487NLhKHQ7q8hJK21ClA95RsvagFsqTJnc8UvQw4sCeh6kNK5VA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENR92OVcxJdxw7m3v9xmdFsjOblDRIJncWn09fy7ojqgD4vz/HgGhajPhzr+6AozQQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOP24lYgPNaDrtYQG6mOqRNIiUK5aWysugY242JLA0wX46SAW1w3Gj8bKQsdXmzZiQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF+mlPXb4mxnl/UmTfzcMRKGiPLOb394L6vE0C9PDDG812fq4Y6VMDWqNEGfOooRhQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJrhkIKu1z+CBtRbp7QjjceONXl48PY7QFHAS57W9B8IH74xqMA0BH5SO629cyRB9w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKk39PP8LETtDry7D5IYbQHKG9CqjSaWl3OJEyfbZqeyn24RtUFaOWEdq0488ByOOw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEtBD4ahKB6A/j7ObdnNEHNmpLa0ofNaZXVnhQ9B6+3x9QrKfIM5XcO/kRI/IUmz9w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDxBVfiAvFDTBuoP4V/WoDpR+ZQfOL5HI4fb3NRX1SPlwIOi5nD3zaJ7168tNpmHow==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI1Xv+n0oqKZmGicDdsSTnqTu8GYCqZN6PIenpMVMd8w4UlY1kZ4Q2DiOSQPQb0+4w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPCkWg3zfFrtPANYT536Gpe9u7tPyKVvIYil5f7EFiNWHN35WsS0JPnzpwpE0FO1LQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGv+NXPJBKwlvnFC0SfEg0e4Pga7HOCRGaq20MTbjPUfrPOKmAca3g8NHFwy6JRyCw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELUWSxZiNC3QENSpFfq1aWL0XzwJvhsTHnXYcykzO1GZ7/FfLzn7DTJRYJmIldTNOQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIxdv83P1VENWJUxktIW61aC+XUo4E86x5dPHrvSHQzmtAqs5ipCGGwB/ZZZ6bsF4Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGbqCkn0EstKO1jrG9VIWq7YPtTSGcqmZc2uD3PJsum85FRLMoUAmZQcFhnFttj1nw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKW6yEdmYashtd/U1T2EgREmd9SOyT2tPiUtWeFPhRi2AIKO7QS+LHKRpq1cK+WGEw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENu8gHFJzk4BtWVAZIyd3PrJZCHPBrJrhK2DAtotefCIcOVyn4hBvJTOUaS4uT304A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBDhU/qZ+HIOMsSOstXxBJzmkqejbLEN7bIkeW/IIF36lUoMpJDgiI/xNfepWqRxuQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAc1tdJsO4628GRQUtV3xJiN1YSys1TY1GwJz9V4NyQEyAPVkDc2glFzdRfk9yvIXw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELV65hSeY5s/rpDojVjtf+0hiUpHXwUZoREWR0ejPpoMvMZhd4kIiBvNCnO6oduTMA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDT+G9ZLaInWkMESDmRnxjYn8pVilkvUFmb23lPgWlUcn8aMJHAmlEBnrNrv7KXRkQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKJedskcCu1vRuJD21iP/YInN7FTxs4DLXSMVgqqmbyXQ29Q2u5kJdf2okWZRyUxYg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGj2sZkzulu40H4g+/t+IfU0J39EgaCpKdaqdCp4PXLePaKNm55KXVyLnc0sD/NE9Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA/j3DDsLpoPdPkOM21H7Obxh1Vu+CAWd4bHHBGKww/ECgKJwcqSh4bIBwi1wScRNA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHsrIctzRF79pmEJ5kY+OcWN+PtlgQn9mpgtVI5zbT6/q1nwmyLmIu/nUDWiIbb3eA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOEzyIJmMHNOR9/gulGELZJrU7jMV8hoTOk1nn9X9wbY4SdGp9B+7VuykW7KPs6JOQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPXgHvC1fF0ud3d+n9lUCJsAu5q3p0lA3UsYJLs41gbBOy6zA4MRk+iNaWxfm9BeBQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEETfEo9M89yH3r7qxTK9dEciyp3Eq8ADCsKUSjOZWnh2to0tsmsQHMLRDEVRS9JRUQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELgJwPVVdEOVMCN9lhY7mrl9VGuhpEsKXoe0rbn1vzSYwemncK9n6sdSOSSgicCC6w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEfV9U7cArSSuxGw15RC/qe3R+Cz7TY+eOIK6O9AWveGm0SWxx0lPRFe3crVa9KooA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFzgs8czTEVf9q4mAFifqM1mH3W9XJjU+NRsLpnUo9T0QHomSF73d46KUBXuHV/77Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOBxtCvWPFRv+BZtc1GZWh7OuIatC0hAFIMtjedORgU8TPpcVkqY8m1GgIlVWBLVhQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI77nAaP3Z44dHW2LfQZFk471N11uH6BR/diXwNPyu35+HnfSAihkXrVO5QI33760Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKRn2n6Dt0S330AiqTkbE+uQilsbAQVeQcNuiw8DIs57zyLg8eVMFds0fJTqSAclog==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIpUwGjSf08c0WifZS7lmarNGlUz1B+DFryMLUJeTCqO08fQK6gxI0ERrk8DyBHF/g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELQUV6ZJLUuyUFQYxLyegu+qB4rMDcZOX0fQqgeNoSECP05dKP/ykf3dnovoP5Qr8A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED+/zAK4rV16/rXIecmxR/BXZvm1Wj188QnxSlz2xsuDI55xY2WsxqALz4jY1wKkqw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELMYG4A+uwpKPCqpInjIzPh1UFPvcq3kwy65/pOMsQ9hOuELV0bjIPjITEpkiSf3Mg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAqGUuuIPFMndO94Bz4effmxRzjgTdLRDn8xiyq+2iU2clz2eszqsMODFMqBkHzD/A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOJiSZF200i0qyqX6kZZ2G+Y66+fIy2WkT0wVtIqPePCIDN/WQpr/6Jyucj6X81TSw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBmE9e73e1Ba4SVaP1GxZzw1CqfIIBxmiVu3BWuh1HwPlbqJk9UxooXpzKFj6TNCsA==");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MaNhanVien", "PasswordHash" },
                values: new object[] { "admin", "AQAAAAEAACcQAAAAEIJpCR8hFleG7JZ4V/HWWjmqRSbOOA9bAGL6eagxUBOIQg9RH/S+o1yIdhmvf3WcEA==" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "MaNhanVien" },
                values: new object[] { "RL01", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL01", "admin" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "MaNhanVien",
                keyValue: "admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 30, 14, 15, 27, 991, DateTimeKind.Local).AddTicks(4990),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 1, 20, 32, 55, 645, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE2LtsFgOHKE/MNJiz5enSDaV3WnzeBVGedA9JzWAgeH97P3bUUvyOiCLO3u4UTb7g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEO4MOPz0IFJimj9DZAPS9dN1oZy8G9TNX5n+k4l37UmPgzxwHey5JlN8liaOtsfC7g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBNJCBjH1pnOv6v1QT6HlWPJF4eLNQ2TiOWWUc81/mEG2Lnn+WgjkkIZ5KhAhcnheg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGTK8K3iCEWEjKnMNaTKGLelTD1pwyowq8DbyEwNy/sUwveRrfH7lH7CxVBlkw3xtw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF8TngZHr0xzpyL8Qu20k1Ba6r5MD2rIaBqhAMYSqTZni8GNnb+99K2Ok10yCKTW7g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEM++MuYFBEArsc/Aqb53X0oLvWffnmv86V0jcZF7UAJ4Dp1NsjJsRxcMvzPBstoK7Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPpaoW26+RFzIipGs65aS/nKZSTJCbgqunwGCmQr1Q2mRfP+K5yboedNm7mjCwum5A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENRF96MEw6e8UiiG9IQUjEL7/4UEG6dT+S7L5HWXQmIUACBEj9qiv3C99p/gdFFjoQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGI+kXA7tg4S1ZXVk+0KtP/JysQEkp7ryiMywI4z/IEr/cFEcScE11qIVmSkU/WJkQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJM4AjFDJibva4fIoEKgpyGrhkPJEM5gSXxeCdXYr8vtuC+xLfljgIY58+9wLy+6Og==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBUCaYmhxBcV699y1H6y78Vsax/SAVToUG5MaIQ8fVpcDd7BqXPDACJDdvmvLE311w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN3cc77YI3SoEN1oKfU8wN11SbtWjjYlqwESoAO6JR24/MJCh9dp0wJk2vtjYH14Qg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIg2o6rsySss0EWrRx0UMDmvdHtaqODRIE7ZsCcmUcFDV1OLIzZgheZPDMoe1a6aNg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHMsklq2BObr1+3afgbub0VcjYYWZn6Ct5VniHPl7jDU0Fy//eU4CQ89UbtHy8+blg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKoIOayEw46m35MgrvtoqHITUYkBbImel9GZMQguA8siaUCvEOz2+TxSN2ZSEEAPCQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEBGfQPRBWSko5N+E2yvUDaFX5wlN39GB+bVj9ThoqkWJ8BN/Rzyq0cUwvcWukxAfg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDF3mCV29wXeHTuHbJtJTK5dzydX0CI8lQh5f0WI359AvB6EqTGPGfsG+UcEn24J6w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGk8WVIQKUpKrs6NKtb3AoP/dxBV6FoMZt6KlBdTDWbEwh64BOLVuAia6Ah6YSg7Ww==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFBx9cgn93s44Zgj3aVBrJ16uZxf1vbNQRvmUeif0Xu3fwvE+eoTJNjE/EKdhn8t7g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGfC+da6NSpiq9aPKbU6ZQz5IWgxmfibtYPKEbBKvlto65qM1l+nYdBCi4rUnWp2HQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFQVUVgptwW52ZV3fkr7Rn0GBnCQ01T0FCOUoEJuyXkXt/84cr7UUHvOPxfT2NUHbQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELH6Z38XSFRn6T29qC74+ubk6f2/WiO+w3ZHmEkhB+ZNdFBY0lB+opyVgMCwkEb0JQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBr5+RJY9tY+Jwiuna6JdENSd/B3pRNRnDMliePwbGwMn6uiGwJg9ZNLttJvelTC1g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA7tBaSi0c4KlbncRSDphP7hp836t1n+4CBitaZt6z2ucteb9HpDISJqc7bjViEahg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBuRIqk5j+M0iYb7KjE+YmIqvji8DdqKfU1AZ5Gh5nqzxtMSigVldl/9GEl02A3JdQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPj1GovgG/VAHNpAZBjJZO9u+dbsiW7HQ6hQf1GRDHGD6fSDwv1RwsHrBPu6hXHqSQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOIq9CzvHs1/1KxzWLeLG/pcnyRlYR3vmj068rPyDlcHVU+OEI6LdNr9+ZY6G9Wo2w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEErG2LEE8mdtPb6zTFdkAtbdSaqM0uDc2m2oi9EmN5G04+PZ0OKiYKbeKShkbnDhGQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB8oAP0L6HxxOP2ag58sFkWt8/iuCPago1mhRq2rDw8T3sGVGUdtuAV1WYzxPc9IXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELT7v2R1G+efidioMA2jIjE4vBTldLIHO88TUON8mhIM+pGNOm0jQ7DFSN5gT6rnqw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEG+/dTjqQUQbAAqhfD4QWG6RBkdvXJz2ctZpHlrfjBI+Zbug/5ZpLerpVZUQzJ6J2w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGWi9/WvPhoXvFeEkU5cJKE5WgMQtBz+Ek3RWoS1meUlNtPQdENbIwpzUGNrAm76PQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENtFLV38gZxDejF4rJ5tn/r+vXTSaSKNPmtlcaXs5fTe1SfeT7PQmfgU7pJFHx/m3g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJr9nj4LPVxM/JXrD7kWA3PoBvCFoeIcpZrLKT/PNk4C/5LGKdDY4yZPrB2ZuC4CnA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEvt+f0PuV7POTLVEYVEgToaDiOjf71AVlEaR7md0/ofeM2Nwiq1Dc5HomoeBzS+Lg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDwIGRX0lolcpRojrcQH76zjS6CytvN3rkvwYcIA2FnKY3nPr2w4wQ3FVN80WLDh2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED2eJ9DA2p8NTuW68sljSGyUnOUk4xUvzmBwJo3yYLtUKq5K7bQykfMRd6IZA1bdog==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKzRDC+mRme/x3WqjCMQAVEa7DqjzIuCVIbaaheRhCDRyd8Vf1W0WbSVmw4ZY1s9rg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOadH+Y5HQ7XMJZUdzG4lefa/GQk3iKnx/wFzolxrUYsALr49T7jpdeRmsHBhwXBlg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAnxgRYkCmMQn1qW+1CXqe6zL4jI3KUcGbC1i3Ay85LK9WGYzwkoiwxodJ3W/IWrhw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFzJoJ3fzgwlhjml52eAxd2ZgPj8w2vqoG1fXd3DC1jsLuaKVc2Vsgfy8tgGG1b+uA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENLtB4XDYJA4QynPCEB3c1scqoAjePvpz3qvMo9XkYja3AOD3ardhofp/iHmZsQQ3A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKS6ZpH1797quDH+eF4HwLmhPYKsubKvRwFZgyDFA3XSZ28HXvrZOORGvynkgcCiWw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGfG1vClIcj/qheL23R1Cl+AyI1yvfU31aV2nF7ObRsv++fokEbrI5RCsdDq09UH2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN5rSvhF89vUfHooNkbeHtZ8X0e8tle3w2o44AHj2nXiaoV0Vb4u6MrqyPBQr3PYgA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOwpmjUy4CDjV87iag49A33YqM+9Mt4H0IwRmk8o3hIL1n0pDIxU4IZ51gkSDft5Mw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMnOHBVuh3LlLo6aEQzJJjsynak2eUB/XCvsQI0ZhzoRy8rrhoSiW7IlOcjdLbH12A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECBnx8zsP3QzaHVHpsyuUYa0MIPUJHEGmfrMyJey6vCKZQoBODF1YbQi03D6waF22w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDqaOmu7yv6rh0lKXQiBnccd8oMUiHKqNxfOOLqzCOywAV1+1d980MzWFOr6qRJ2Fw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJJpVKz8rLZPP4/VBkElku53BlVocJ17FCera7ZAn9WGJ6P5QkGU5rQ3ZfKnk6WI7w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKVYJqBkXNCVI+ZKdeWPWzK/gFo/bVcHsgE/Sb3z2cpr5x+VfkuiiuhcbR+JJp9rOw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKar1VNBhcqQTI56L8md8yzRaBLP40ocHp1H8YioMCUkGgrRqbh/fvbq7yY9O9eeHQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOOt75WWwEBF712f8lM4bZ+AS6IjVb4BUw2l2Xb/AWKc61x6LyEbFDrRamipWTO6IQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFXATCADTtQn0q2DO3XjYEV1GcV42+Py+7YAb+KW3b+Y1yvSjAIC/wXTB41eZ9wpbA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFhuyEVOUvqtqay/ptNPsz1AA+qzZt+8gt9rJkFmffi0U/XH7Krl1N2Fz4xoeu5TNA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFaji5I4ushwnnftwIzkask9CUzi+dTDlAEtDf0jxSij4cobo6HmzfVskkzgn9wvyw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBV4sUNiyZCKOhQo8o7EWiq5olL+4/af3Jjq716eDWtBTV2Wh/fIzLYMphi3fQUtuw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECbAhg6XbRxSBRLPuYn7YjeLTIHA1sQyj2zBKS+/TGUWp06rUdYp/FXxE5gQw1RMQA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENsvfc+URjNfn2HArYfLIc3Dny/bmVgjBY3sY5/Nyf+PlKo5e1l/VTscZ2WW2gW6Aw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDyrZzIuxDnXU7X3ofyZZgBMnS0gwAF0MEgr524bGVIyywZK7SKo0bVzN4zYlgLTsw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN3ex0UIL7+B0j4ItNActwrqegPAEQ8WQUHK51nxYra7+EwvobhYWV4J3Shp11RnGA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB0hOUfqIcI07SmQC2/VzjbntAni7iB/AGokQjB5jkk70UazICYui0zYLhmKilly2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEP3Soqh3YALAbsxb8zXPfbNyD5uO/VCZJdi7mRkv49RSoQnQIUm6WNP2/5WQoG1l+g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPQ+KWBBdecRlByvAphZ3mQf+4unjZIV385DRYVWGfTsfO6mzeyb/6TpcfQObZv8vQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEPmVl//UE2n/nzAtm7kLG8yj4weNfG3j6Tz8W4DuSgS3gAGFSxavM586FqFUKdBMg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFbBS5XSLfIuVokDB2joZUyakR9mGZrJ7qi2gh8cxL7IrHNqoOZnc1sekq6y9++LYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIiLyPt+fA9NAkFonqXllEs6b+iyxmXKz02jM2gFeRPSpOVdQQ2gspboh6Q3ieuzCg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEibET5xNO98HDcVRj9BuTzv51lDrv4qQc8Oxo0JkE1DFec6GORS+uG/Kw6+DRtRbg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPl8q8iErhv4B/Prt320dhV+HgCJNXW8OJIuxvtP6vT8NA3kZ7euZ5xuXqbnit/dVA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE47W5AvjAYhars8djkY8KTI/Ijmoy+blu04SBCvFXbK0PBNfTK3dw1KbLTbASt6dA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBMXfKRBsC4Ks15H6r0nh2xXAvkzGjdAZqqxl37sN6ev1tDU9+omQuqrYZF+d1VRkw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMOz0tMwA3kciwis9I9KlPJgYN4zYUYcC/CrXHqBhpmeBQ1fB88QKQAW8ygze5J5Cw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJyr6eo1Pf1p3Cu6FF//KuOnoa0MLZPqgHoBzj8pbRXFhz4TpIHk4NcGMWARCPSeCQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHCwrVmwQ3GXT2ZLLd1aT8NAEIukxn01Pnmyyun+JRtF9tlSxXvfVxdpTfo108fldA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAZegJ/5f38WxZ8qU3IT1QbSHPRA2Xmg8w70wsIVEu9PuB8KcQZH3Sqm9V97bIksig==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJTFP4YUKAwiF2imKUWu+yf5Zi1Utz4AE8MGjIWesmLk8LFCnNTd3ldHt49rHyK1iw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFTUlx1C7siBd3KPJcEOIKBIDBjecJsoAqsqAQzsjhuUKSNDBouzRimH/JoY5sYEIQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJxVSkIDMviAUlLGhzb15oYOAMaLu5TcsTiHGYZRwQq5qCv0le1jIyzlQQaLttQjeQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMCem/BmyBHnDodSTUAVrXnx+eBkHhQ2RNy0XkeopnWd391yMVCJ+h6Z0kH/G7qL5g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJwU0PF+5scWs215AYjBwjwgMvcveI/csiUhmYGKDcAHK3iMQE8kcxp++8eDRbdKSA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMalsoo39w/aLc0umKe+8sC2G6IsiT7laTqk4b7ef/GC1soltW+CmsithEdSt+cfJw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGVDMt+1L/sM05Z9+ei6lQKTYnH8At1BPDRIQlAnIQgjMa6UiV2qBXbleD+5yz2WZg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENJasXzXpt9AcSnxeOwHrtADax76D4LYZA2BHYKVzSmybJ0IYwDA5pmBhrpqU8xCiA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEABLRLm5DamJ1xfdWZOpdeH3jNFtVt6JF/bqL3mc2kFdK7ccLu5i86yfORnPm4nCKg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECwd9kGUu30kVdjQOkpHTvkDN75oIftaTA6hJAdFRABcLcDUrta/pIQYBMeprvaH6A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIwVO6m7iZu2jYova+4JJSKvpOBuOe8BHzCtwu9BiDLBPKL6xrv/+KgkaVHa8XqfDw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIDrTIgGEYX26Rw3hqAndm5cXpGC/C7vKYgl9p7XVs4lsjHVpwppzdxKJfMf6wCKvQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJxnqS+hIjfSzCyKVLLpxP00lq9dPSfHpElcKJMyxElKLFSSK4fbFO0HWeor/JAkJw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGSMFKGaFlxrvJajWZj30exQbpFVXeFGrVf32X+Hg2AYDNoGtkZTUBPYWhM0H0rcLQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBdT4r4YPpUzt20Ct1qJWIsXILUQCqM4+K/On840tKYQAW7WgjiDF7DRU2fd5syflw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBp+JSU9Ven9Crhg5QtTGmm4AkYZgCvrrhntpMJwPGvH3iG/yOyVBiM4qMyyKLauIw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK3k+ziA2vwDuijG6yk+Ibe1VvZPt0bgsop7CsG0BSfQB1whjrKHamQI/bKGrbZ8+w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIoodFYIohNCDbmxYYYkNvN/Iw7MdODzUEAjJNPSrA4zca3i7Bj5SezdSC3R4gO2XA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENN7hjHrk/U+ImsjEZCjXwttqVvSqs+o0nCDVLmCyUbnTmdbO4TsldLgw3k6iAT+4g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJfJoxHSTLn8fdWmfQBxmpps6FhCnFovz8GxvcKdohx1ETWmyt3IKAKOMykGsv53bw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFEUwYlBMW+xxLk+KaAR5edVvWX8HPOKTwJgNWU9iAF7dxlbGAGGxP6vOp02dmf13Q==");
        }
    }
}
