using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class update_DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 15, 23, 33, 13, 578, DateTimeKind.Local).AddTicks(3547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 13, 10, 28, 57, 906, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDngwtg89QbgZODkOYV3YvYkfTKgCRifPmx8EBarC5Zofz74/EWQidhyqe1Oud5rlg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMOw4OXHPuo3T0Z8EPG+91ckHl495m6XJHQU2JS48C7fRtejIioy2Nn56nDShecd3w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOoY8zhiBk6jTifdrEb93giC1PT3eR5GpivLpVaYrp/iIfUzGiyO3EeEJVWJyesULQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC5aJIja6vB8yZ13pSN7rle9fTAg02LohCWasKpHlifEfP4valDGeKx1aIq6oTIcsQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKbbkjI3cJkS6SwRxKtt2pC7U/Fb6rugfx9bCQNbjlQCCvwd84V+0nDJS4QsqZ0s/w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEzc5iXAEhY10XgcIth6fTGghu0COJdNN9TzGby3gLrwMFx5cSNddl1JhfIPBVuong==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIksoDk75Mb6OUd7Y7bOyY+var2SDflMc0RaDeNb56xgirLq5K7LzK+CI420mCXq+w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC1HLZmDCRc+fs136eoMs1bxpL0T3w/KhYB4BveBpMj4Rkrl4lnRUXAFgC0ynMIRsg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI8FH0rFYm/ERGsXZLJbbKs7e6RpxjwwgSngDIWX2LVYHzyTWaJrNWN+jQW8dYsZBw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBt+L1/h/epzhRdaebxUTVjcygvPhiowcItuboWK9CzJRF+ER6vIdKtWs7gtv5tv1w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELaGjmjePK7XBBjz9FRaCBEUBx8G/Kg+wGYy5yFNUXnEZJt7vXDJNXf5zoaAIhMvuQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAPq7ih4TaIGFXjV0V66KNRWUqa+iuAB3GbrdgiuqxyXaXKt4BkEcFcjmm7PWkR1VQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBFnI9n9wrzWi+Zz5PkfI8mlcIbY/Y0yO/NELw/JHuP6VUNtIKPEjSaLYje90dI55A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIyXS/X1k2VV1axp63wBsuSElgL1mY0soecgxUhK54kC+j8m9Svt2K9+SMuHXNNMyw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA3JyuOCv/OSAJuhuXObFD5a/lBjzPGFjGQ5yKfcFUWxBB6oWrG/4ON80qrNNI2/LA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEAyJ8ziF5vUEzU/l9Fd3vQ/ZnM2djzDjsxRZzeuOLt6O/jUIC+4ClM9WOiLcPx2KQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBBQDUkIVsKyHqvOnxg0FUKIeHsOk8WdonKfpOAXGtd1d5EpwFZa9uXuzk8FPNuGdw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHxeT/e0T20Ngx2d4wsmy5xd8cpigE87tjYsws4vVg5fbAvg3/nKkeF/5oMULdHEvg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKQ0ndERe2sxLag3TaN72+FFe1SEMFf//Ap6Gmc+PlLpajP8igD2xcv1XjE1OZk2IQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECAn4uTM89bvZAbWz7JRK+DTUo0vQcor0EwrlKIZv0YxX20c1soYv44h+8b2tIduSg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJI04bong7Oin/MkIxsN4QqfONjiDmn5q7fVDoO7Tmww4I9lJSW8uQ8kVHWx4FH6wA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKMdinbBb3dX+qVZfNlhAkehwIptkKNSz7BAigPlVchKCPg/GsESGibeonNYCQY3KA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKtgUE2zXub8B0G0R7/da95gtHmMEFvGup7ijj0Ha5+lFEqKrtnO0WqJ2LnJhUgmJg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAPNsfJPKFVVE8gLB+6w55b9cyOu+2JuRe4MRwJexpz8D4KmBQwApCphxQC7M/d50g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIM/8ChpmUsdYhs16iuQvbhL702H4Obw9eM74761XK6CcB1AEgZuvuzCCgzCdxLoJw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDy3UgBCnJCYRrBDE47iSStsR+5rzd8H08D3DlwQ9RcQNZwYCZd4RYXHpSb5KCgE/w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGXHbpFAZ8Z0hP22CeNJODyMKIYfh2B3WM1VedWnXjhMtMz873aIrTLMr3GGNuPifQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFzt7ercTDueT0DyxQ99LgYKpFLjkfj/GlysgFnLk1OdJvo6sxRlxopGiDZnheIgxw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPuWKhxOtJTDVkbGc9aVGnxg+AzWBK6T7k9xG4FCQ98HapEKnqPKCxLNdNwdHcdHQQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB7vJbbn6fuVIogDICUB3fQVDvPNCNYcXcnXnM3ny5eGTTtQgheaQetD1H46YUZ/iA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIT+p21cteEP7NuJH62vn/eL21LAa7F8ejR6+s2ZnnAiZjgm627NuSX6Yu2Zr5AOsA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFu1a85y6Q1PgTTltZzUnjf+X7ZyAmm144tvAhdwJVue7/LS6sFvYpKrP3UP85rWYw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA4iFSa3CmMX9wQwH5494D/Mw6sMW05hTVqbSdgLyraagykTysdW6WbCGLe0LAjVBA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELn16PEnUP0ZqjNv10MDP73C2dBLhi/HqPyR0R/2I5CbKW0Wjqu85NZzQIbjRPterw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJheKTEQSf7Evir5+xw6umV3TINIfNAqdK9QOCKWEb4A0WEU0r9CrmWFwhAvdVINKg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFOhgB2ZLFaO7809E8SicqXohzv4RkG3s34z3BiBCwuuXRc/ymLqFzX3GorR4cSy6w==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 13, 10, 28, 57, 906, DateTimeKind.Local).AddTicks(1454),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 15, 23, 33, 13, 578, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEO7ChhCETxzKGHt36fAo/OCNosaST9tO4DX5vN1KsAyPKs7HJkw2fzQp98U9QcFm2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBNojrox29scWE5OPYvhA2r+p+a5omFlp6060VeeAFfxS2K19hz7UYX1gRWFeFjOZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHIcvM2RgAygu4ZVlQELB/nCVDoVH4kRpoBdSvDWKusakXWZyVsztUgdortSg/uqZw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECcxAy9JVB3EJ+ePghC8E+E2NFvEEBJcV+TC/+99QZOPrCF0z+0SVAcf4SCviF9Dxg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMeiQIBTMPrUagXCUZHhr36oguY9Ck4Mf7KyChawl3Ic955EjC0R++EM7+7/5yYEGQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGWd/QJwT3ynR0ZaySiEU93enuPVLdcKrTJvxkNHCLxv6/9+MPP6wc/sxUtspz478w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGOEhSkdsNHcopSHAGtL1NAefbnLdK9YmnHWimI7d4OvT5VSgN/ru+KlNggWfvtmiw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOYUYVI/Pr4gMfEPmtM9n0GtuTX/iBhjIB7dCs1A0FOht0g8iiWlxr4lgLA13BOvPA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKO8s6kRhApEofXbslDUF61H/2GO3eDx5/4s0l3LXgOCQx5Tj2YmcJkE0q1MrIBBcA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMhWk7nuk9jzNtRMI90WZRa7RTcWVl29Ex4KcHPCB6FgzwWJr1YMEW24ltvIuB3rMA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECddIw09tzZGH+ectXCTMXQkwVvOSo5NrJCNrzZ1keAsEWkxs1dYu2PVHMZL+Welfw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEEmkmrVY7lEGMDqIUoetpn7Mj+ypfmbngkMM3um00BwW0oQ5e6jwpG3+P0kca7YKg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJRUpHOOGHnuI+FtLqWUxxsQn1pcKBHykGAQ87YOylb5R1sMVgd0PS3Kk5Ph0QnDog==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEM++4+zHetnJaWCSAAqG6kGBRDgTxsNXit+N4B0MjS8oMTz+IeVbh3muAQ/beOBaLA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGTOh93N7PBAtRSPBxnE0/DMI5vLnLkKvs8vT24GWbqDq7vYNVQTIv8XlH3dM02Qfw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMr4onVq8Zm/T7qy1kbUsmeDqF42VKRQXswqnZDsTPuP72rzmP3xzLfbqXm8rzF2pg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN7Vmbg1n7iuGlH0cyxnkAPm3xNCBKT6M1Frrpexe+PihAHLIFkavYjI7n2jydF4PQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKKwOQxM4305EKfiB6hgszzDMJKa3gi8ZjhN44oFQBuxMBim/SoZcMxc7a85zfrAGw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAf9zQvNz8wJ9NlVvUBoACsBW9dHmo33e2043pfSMqPDQI2fObG2vPckHbDUCZvSRQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHkkcx87/w3clEZBn7nLPVWAiIkUNYFkubJM16Hf5SRd91loBRvrMFlBDWfXWmOXUA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKunT6W/RLYRX6HRSktr+6RmOzlUW9oCI7f7ySTWQZKqm+a64g4cd9E9BYuIOrpcUw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIlvNaa0/w/Muhtv/aRZ+AzJT95eenjOF496AZtgHcDN6l7Pts/CqmsllLNdtTESrg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIBNdE30i3JX0f9tPa/c90zvSPsds8DLBem/MMP5JrmrfE+MmJU/6OYGNnW8pYwL3g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFMk+8tVB7egMHHpYZKSOGRaNtYorMnmhmnFqoJeHfQhcXcY7clicKCRUVRdMt/PZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEO94hD6xn1hjm7vudJxDMaV/+bwmxu755KD9j79QSZ+4b6xrr+Y4FJNG//rSCwao/g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEG/qGC+6nLNf+mkE2YGHTsoAhfLTfLZXVFI9ee68yFlzE6yWzNXjEicDjrsU1mlnXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFD1kOGlpp6jEpyPzTJJhjMfz04cxdjdH/3BfaUCuqn8bUIsWaSqXcpzxOyUZRtNgw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPbuxkylxGRHu3V0sIP36HiVD56RNahQBUrY5jS2DVlmmyVcGUVu7VNkv+1H64kcXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHG2ZYUALOheHfER8gmg2HhSvvcwzys3Bk1L+XrjpCoItftQCm7LnHO3hlc8xN2nbA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENj8Lwaa1KMwUfwnK+0BKDKz836LML8Ae+HyGR/Kd4rBS/1aDPfPUXc5GQKvpN1Ovg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBFr9wY4yBIj5nR3c/V9LN5nEdfA5z4bYOHhUZLixA/Hl8/LhwF0FgayQIH5hOucog==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAu0p+IKvRhUGIpqq509wlq15b3Qki4whVjbSjCpJVgwyUdEQo63ctRUDH6RqgyPsg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN2bLvk1uYYkGkRM4W0h8jjaMpxZvrgJRPRSCaVjSOwvNWE2TNmvOtn0oL+dFJBOFw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIzbCrm5oDUdiT5/bDbzvNe3nx9Fh5dBvzjC8AcAcnPUqnYHxRmylZItw57e6IfyKA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAm76nbM6OazZ+Kh2VutpL2mZwjdqF47/PJp9bh0bvwc+mMAnwFqsNePRvv9YqBrWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEATBzcqqlpCIPBJz/jbGF1OynJ5dsk64ptyCkLkGk6g8Z6K9sUq9zShP33w4Faqi9g==");
        }
    }
}
