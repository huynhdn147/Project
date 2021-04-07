using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class seeedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 5, 15, 2, 46, 170, DateTimeKind.Local).AddTicks(6043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 1, 20, 32, 55, 645, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "MaNhanVien" },
                values: new object[,]
                {
                    { "RL02", "KT001" },
                    { "RL03", "KT010" },
                    { "RL02", "KT011" },
                    { "RL02", "KT009" },
                    { "RL02", "KT008" },
                    { "RL02", "KT007" },
                    { "RL02", "KT012" },
                    { "RL02", "KT005" },
                    { "RL02", "KT004" },
                    { "RL02", "KT003" },
                    { "RL02", "KT002" },
                    { "RL02", "KT006" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "admin",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI80bbzX6iyrgfQpJGkFDy6qYHPjS0Vfe0LmCgA+ZzFpsAFHz5AacZnLyxh7ENrdew==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ5Zm5Z2OXuGj5rNjGMetjxjzxO4xSEJ647W0Jgsj1vDtNTqK9+4GhNZBLdg8iW0lA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDoPP53Gmr1U5N4R7tfOmtmR7/EdN8jcIBzZTas/NAblVi5jmo6z4lluvu+e46emqw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKrKWTJIzs5iB080w8ZtWxkAg+OtoXqcGu7Sxb1N/QITAIGWG9xVuaXQ8MNahG3Ulg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDU0qNANrdXyHV9Fz20pPJC5UeozYi9T7U4qqnYZc+82+XegSdL0DFHHABRDQN7itQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELHiL6CA6sJTgbdE3SVZ1lMuN2FPpTP0TaPRg3upnye4XhAcCUbi3bpaljvTFnHkcw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAEmv20TUviwoSNvTR8YaBsDjG6Hth1lP1Ecsz/uHF9rXXMw5Rbd75ahDvh+g3MjXw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBA+Ok4cnIeMxSflzyBM+V0FjES1r3LQI8yTANjk6fq/w7e85dzg6veZHal6z9OwFg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECT7nfNbHB84UuT+SdHZgyH/74HJ/vyUL+1lvwsK8nyD9jAmCm91jEXCG3QgkugkFg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAL1Ofsh9JzMdUzKtbjV/eTd9Ep0jDM2Piu8exiSVuO0Yqg7lr+W8AhqYFuPSrW/sg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAm/ZwVgRb/LyGGD2Sbdn5IaTJkjYstKzGx7iRdKwJxUzzNIKw3CGFqnohRirbB1tw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIqCr78NnzQOfZ7GJMvAB+POwAS64a/Rp5Enpye8CU51fRgeo3T/6T//6XAtn2WiIA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "CT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBxFGsEP5rpRhct0f9u8yUPQWsIK8vKHgyGHz8+1hYy7Wky1lNDPhFn5thMrvwI80w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHIJYusp6Meli5429sRgezs0xlQtqLr3cslvvh6yKJF1jiJ6MdjrpPME8ErGWQ6gJg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJZyADtwo/VfLJMWBFvPqI46Xl/fea1FzhkNZ4h3lhifTRUR0+ioVGOXgFUoQ8MqDQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPfXHyCgzj4+h9eDr24uJEALyXFheRbMsN87MZTU/FfboFbAHl6NLD+I0d6yYKBQEQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHOv9u6vVjL6GtXXtDwxCGt9ZS4XZZe23wDIbHVBx+NYOS7Ehnz05+kSCfAsw9TCkA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJzVJkVUg11d8FdfM1cOFKdYA1eXvP7gj98TqJXB28VzuUySDjonwhWa6lth0UObUQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMRiF1qcnJYyO20We2PEVtetQj9J94PmTrE1mD5uvM1iUf/OLbDwaBL140c15KdFww==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE8xc+27YopDjUXCDAjp6RosYhMJ8UfhEp9F4eLzPmQamhYbCV745MgFzarD/HEW8A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOZIp7P1al+7X2ZudJLjtpokWK8pTwvttm3UNeUzJdPxrrchueJHqtUsx0psRVuf0w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA6UtYHORaBjMTx55WUGCW08bOOVwhZLBUSm6185Fe6FWEle8Jyzajy0gQuZLT47cQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKmcfqXQ7X4X1qw3oHlHYW8Xb44gH1GSXdJd6gSJGjXSEKZyFNhGKSKGZVpPy8rJXg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJftdNz/ByGBZ8cpN7Nkt2GfJi2GpzXP+2YuOVZT7H2n/HbyYrIQGW8MbX4OQh3jdw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "DT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDYLjD+4GbWar6GSqw9vJZ/qxxHl550WlPsmoyCM+TuAhlG2K1H8kwgZgJJRJC2JPw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJA4NVd/uBjgLWdeF9zvz0o8vB6oHfOSIuDq436byw8btzuM/DlNf59GWRD0PqmZIA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKQ91oTfgG78lnh0wu36RWDht1qFudVOyLBOKSvktkjYALBHQBEOt9RV/zPwwUzuuA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHVivBOX3kxCOBwqqT2K8BOgc7Vj1VnJ48+TZTUU/Hftz93iC4Ot17enTNrrKVzCSg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHL1LRC6LAo3a5CVsThIWRU2ZPvfoBBZnUzFbOw3tTIb1/GuKT9c/9qLQddOnC54YQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELC8GGBvwnNb1X58HtJgXUJ+qxCoWbedDtofPG4F5CaTJAspYSABwQqXgbC6r222lQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA/36FVo/i6ggDHOojNuUsuEhaEj7bfggQFmbszqo3yrGguTmF0MG5GNkU2f+fRDYg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEECIx7K8u2aYdAICScN0EZaxU3EgF4KnvVCNDwBwy4TFiA/CjjwKoNWnisGMxMcSeA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENEUpFpOIul4+f3bagZQ0zmLBsZUa18LWX6VPKbPnqMJLIsvza5okbQ8ejTLl2MgnA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAuAuEJFohvbdSa+qUwdF/NWjAkxUptbS4zI/KZOLe5Pal+/rTe+AuAHIKxoN3rmMQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELMRzlNvTN3SWehWsQTdyJBXwdKlaHuRu/o/h7KR5gktVLWizOUBTtjqvNQFpHitrw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECbJqhce9KFIS+CYiXwPbY58XNnGneE6t0fg2j7wf7jI+mQcngN16zusLHm2A61ztA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "IT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEQeUSeiPpV8uYO03QqxKAkVdE2GK5B6Oip8OpibdzZvxquH3+IHHrSPo3YjlWf7uQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI0CGItabaJneF1Tkx5j0sA7fjGFUQhk7nmhYM7ESVLpMtIuo9cwPKumMwwgXva2Ow==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJF493zle5j/Lyjt8y3V+EzkxSZqlxIHxZEeo3IlUO/Ron3iObu2V8nkM+9xi+plAw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGIjPRSrcDpumXGMhWV9/ouBanZAvXJni53/1n0te67HB2LEBd4WKSk6vjLV67UUzA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIy9V044iSejKp2k51hL4e3RdjtO+LFDU4KUa5WfN0tC+v+zxq1hV3gq2SsFsAXOSg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKk1kpprTLHFo3pzItaVJfciv1xRDrTJbd/q05UrVIpmz2MbuqN5BJr4F+C2kFYhdw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOd2UrgPinJixMlIlSDcLtY33E2tQycaHVP3DciLC/KHs411mk4F8j9gFVxo/Pu+Fg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBewnXwAfo4n8QknNoMPb6I8NbZX5ggCSrY1s5HHU4qbtD8nbAILZzPYRNp4WJ0JdA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED9uQ3T3YWqgkfto1x7VcOCJx2oH2EESdtytpChkPRQ8lLY2NBlt9Cdul9XF/Vt4gQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHK5IpkiGiSVuGnX3UVafsZGT56z6TR+g8Q5Qhj/2hv0Cy4KBTJYwIlzSK5CLqIJ3w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJUWPsU5Ra5o+j6ehVj+2OJ8hgsXK/AW51m8GR84JfkTCMPzjTMCoM++lYsc0Qa76Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPQMgD9cjmD/mq8HtBcWWVNOZYU8F0rA1cpi/WaWme3Y1AM0DSst15jJsZgI6kcm7Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "KT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJzTGUHUBtMDXHnPpuI57alGAl1F6DT+F2FCzduPOoUqsZeT0/MYlw0XeTuIPuh3ZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB3HKfb4IJv7v9HejNbpD/fkFHx9Z/f0PZoEZN0Ua+ViJSMvcnaFL3wEg2aQ3Fuu8g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKElwh5JShMFVtsNfQHZzSyrQr79FBAkl7gBUxQ9pDU+kcnRWL8GtRbnnnE5ocWiUg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE1hb9EoFCSxY8F2jOsxk4uRbPtS2LNl7jUFeflLqEfsC0exX5sq17LqdKxNLirlxA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHhIbQ09nba0so5Rvl1IPkqAfGpl2XpRaupTmLoPo+Vb953euZN+R7vvaPxi1AZUAQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKPpCLXU/o7QhZy/7489SnmjAncAEAF7LmcNr6gokJU/MUl97Xg+o3wzkDgtiNJmEg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ27iFFPb/hvYdVNVcDTGwkcz3+OpAf+D3EM1ImMWA4/yNmnHXy7R2LdlUaykXZ7Rg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJ5G8XrlfWNsGW1UKIJmOIK+VXf84T1V9IStqyVnz04BogeDP/0cB9y/lZux0VrUEQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKZ718SGR0XQU0BBMFqDbYM9rFy/yHwCkbXub42J+pGNFZ1XIA7FIUCaYcP+SUaX8A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENuuN+0iZJGKyhZUllk9O50cJ+j8LZafQbGIExFbbiwfgItJAN8cE2lh6UZ40NwqJQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOuK+uIN5HbZkRu+o4h54lY2d+e4vxQmxDuBVCF9E2mbn6e2fZzEwoD1C/7ao18Kcw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAutS7noNn2BRdxLid5sv6t5t6puDKEowyr27s78pcClkHoA1fINwzTYR/fg+OaaMQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "LD012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPpR8yP0K1QnvVfXbf8c8rIfontfa/+yL0YsdB6SorJUR4ztNHoj8mLD29LNSZSHNw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDe13GdDAmz/ia2xCBRUj0uuTXmwZ+npLnPB1Maf7JRyVmi56NkEYkEdr7pItFhPEA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEL9kGqITgNF000nNVNY4zm2RaG4sBy0YjAmBC7aj0/B7El6lIICZSHQuGgHaaSCygQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDayBx9YbSCpJ+6aLxiLgpQPhnkLavKy71qVNlvQexdPHwjT6s+2DPzNEfu1ZYXlXg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEO7CUjTRq/0/D9neePiNQYVHyw+YplxiJ99RHHK2Q55qAe+ATru/PjRSUQmrUoKqQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPd5d7heb2Rpq3rKwd38X6BjyTYz41RG2swwcJiSklSuYD7xXYl5YJOlnV1B2vwSrQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDyeTbWtkbnxoyTZ9Jnwjflm7/rKQXzy5ouoDyNDk43C14Hpdf6JOAx1V6ZdVOjxqA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFYHXujI2LUxJNXP9zRbkYmYgrRb/xOZtdOYxcrFa3Zj0ppPyUgO8TgZdJuO4/GulA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENLedLMDN9Rsq9u5RsMkqs18JCp52Y0245guBgB16cUuWs2CU7OOiMgr+Baw07yhyw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAXmb5eDDXgHgdXV5kjrDewQeZOb41FZmHbCp8lpaHru9moBZbZ/jFh2i/mSywGqNg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEApApKi+vYDM9H0m4QwEKXzWLLZonEGc3UeBeJ27pr0Hhob7bkuqA30/mZ1Pe5kUjQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMQ3xciY0Rb7ApYUwxenWMqqnrCW/oHueIrzv8gQODPcywV5kDrlhuCpaD14o1Rb0A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "NN012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIuob0GVB0pwT64UEnQCnw+kr6oSHXYehI3J+RnEXo6kXv+1EusQl5aImdGajnlTHw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEODrcTWMHZHfi4a/a0/t3uHAByw6cIHjXv5dII1t3bmwhZVCebzDK9eZII+TnwUhzA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGDbDJOREEN+Ikyqf7RXXf0cwJOAhW85sz4R2d6FCAquT0BEeO7U7lsIIz3CaUiZMg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDfWTWYWLCG2MXGNtqCzfkZuvolc2Y9eduxwkoAD7/K0azSrqkPLvjF8dLZmNtPYNA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFEQePKz+5fuzXQNZ2jNtlFGY0DXmZdXHhcXUwRfu+UnM+w9F27qoGx01nWWuL6+zQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENI4HS0gkVRzMizML46Lt6tv2qz/M9Zn0hsmEbmszD1sMQVdJshSkcPOZRgrG8cgng==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBzTlVPkNov8TRwlm9J87ncxWYmty+YxFx0JCXDfQ7EaP8JMWRz69h0zuiAG1a7KWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPwNpjgUCwkEa3Y8sy7XxecFqerBuZ6sTaSwNlQ/a+qdwZtqXXFI1Cd/ZmfoZrA13w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBJar+NQYGE/FIYNvMhkPlYo8uBO9jg/SNSjmtqjyuLlMcas/hDnhtwxbrtJs9ZK6g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJayGlebMMRAXOaKanxDz9Q1qi2Pu4DZe3A/ElvdoL0zjwB3vB5yrSGlUpl/7nnO3A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEM1gyFYCOeRIbBxe5vcLmkQNUFnrt8RKBNXBluTymEJgss7wiypReowoUJ5nbFy1bQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAlrIcTCyli/JvGzLMqarazTwVlwI//r8I/uABdPrR1orzSkWQfbns68ujkHSSPK+w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TT012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFI+BiS8KblBRYdrjaoQsL5l+v/o2z8QXi/JzpUHJiAbC4s/s2oUwgIyiOkIUm0PjQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBbq1vj9VI18vgsJdKCis20SLK4LuRzYE7llAXUiwU+yGjlbkt77qcoz2lr13puTsQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEH9YCHuyyDJSoEKuTaAxkiPEykE1tOBN4l8MQcK1fN5QDZy5yrWfqtniIBSUUisadw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEH8qosc3/RQvGMl2xCiMn9VCZr6+UbrcC1RxdGZ2nXmvYlnc6xF90MucVFiMCBXMWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJiGh8RuFJDf+5q8MjAYKBDC7vxFSF9VHrJyOhdhxyXd4OOSEdWmBZCfUKNSpp8xMQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENC1g0yjPAsJGbgZqqR38HLEHAPu7Uh7GWbgkWNZo2HXsI8ZlOCJissBgjbODZ9trA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJHCr38btPFQPRlXVtEFTfjnkaD5Kwamk+gLq2O9gvgym4iajfPxEUygizdOZ+zTGg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBHwJ8YlXuuI1xFZeHDL/h8JHOv0fTtRKeDIOAvBMbdsLtfVJIljzrWTIu3QONA1TA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED8SmoqSTmNVIKYir4XesMSbBSSP39/BPC8ZzFa7MTAMQFYYYHVc3kY5UdLl60EA+w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHEBvYzZ0LTxuWjtYcq3up6hrAJ3QctCvPWSRM71ZcvzsTaG0Xzp7gvZL/4iQiwncg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEL07U512Wuwxj84gclhSPWubRL3Sat2slMrkXwz+KokSgE5ewBHcVI4QYbs3ieUXjA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJqAliMc7MFMTuTMW/huYMV1MyY0Wk5yJ9DWjhqoUmbaiMYq4ubir9ClYlbPZTwYWw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "TV012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGg9xFEjagRJmleOP5mg24NUKvsE7W5GVhCmJNuGhMc5l64axonJ5VDJhFiiwcsCBw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT001" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT002" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT003" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT004" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT005" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT006" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT007" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT008" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT009" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT011" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL02", "KT012" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "MaNhanVien" },
                keyValues: new object[] { "RL03", "KT010" });

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhLap",
                table: "PhongBans",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 1, 20, 32, 55, 645, DateTimeKind.Local).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 5, 15, 2, 46, 170, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBatDau",
                table: "ChuyenCongTac",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "MaNhanVien",
                keyValue: "admin",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIJpCR8hFleG7JZ4V/HWWjmqRSbOOA9bAGL6eagxUBOIQg9RH/S+o1yIdhmvf3WcEA==");

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
        }
    }
}
