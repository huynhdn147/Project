using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CapBac",
                columns: table => new
                {
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenCapBac = table.Column<string>(maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapBac", x => x.MaCapBac);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhi",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenChiPhi = table.Column<string>(maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhi", x => x.MaChiPhi);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenCongTac",
                columns: table => new
                {
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenChuyenCongTac = table.Column<string>(nullable: true),
                    NgayBatDau = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    NgayKetThuc = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    DiaDiem = table.Column<string>(nullable: true),
                    TrangThai = table.Column<string>(nullable: true, defaultValue: "chua thuc hien")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenCongTac", x => x.MaChuyenCongTac);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenPhongBan = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 16, 23, 46, 11, 968, DateTimeKind.Local).AddTicks(1685))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinhMuc",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SoTienDinhMuc = table.Column<string>(nullable: true),
                    DonVi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinhMuc", x => new { x.MaChiPhi, x.MaCapBac });
                    table.ForeignKey(
                        name: "FK_DinhMuc_CapBac_MaCapBac",
                        column: x => x.MaCapBac,
                        principalTable: "CapBac",
                        principalColumn: "MaCapBac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DinhMuc_ChiPhi_MaChiPhi",
                        column: x => x.MaChiPhi,
                        principalTable: "ChiPhi",
                        principalColumn: "MaChiPhi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhiCongTac",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SoTienChiTieu = table.Column<int>(nullable: false),
                    TongThanhToan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiCongTac", x => new { x.MaChiPhi, x.MaChuyenCongTac });
                    table.ForeignKey(
                        name: "FK_ChiPhiCongTac_ChiPhi_MaChiPhi",
                        column: x => x.MaChiPhi,
                        principalTable: "ChiPhi",
                        principalColumn: "MaChiPhi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhiCongTac_ChuyenCongTac_MaChuyenCongTac",
                        column: x => x.MaChuyenCongTac,
                        principalTable: "ChuyenCongTac",
                        principalColumn: "MaChuyenCongTac",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 25, nullable: false),
                    MaCapBac = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MaPhongBan = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_CapBac_MaCapBac",
                        column: x => x.MaCapBac,
                        principalTable: "CapBac",
                        principalColumn: "MaCapBac",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "deXuatThanhToans",
                columns: table => new
                {
                    MaDeXuat = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Lydo = table.Column<string>(nullable: true),
                    TongTien = table.Column<int>(nullable: false),
                    ThoiGianDeXuat = table.Column<DateTime>(nullable: false),
                    SoNhanVien = table.Column<int>(nullable: false),
                    TinhTrang = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "NhanVienCongTac",
                columns: table => new
                {
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienCongTac", x => new { x.MaChuyenCongTac, x.MaNhanVien });
                    table.ForeignKey(
                        name: "FK_NhanVienCongTac_ChuyenCongTac_MaChuyenCongTac",
                        column: x => x.MaChuyenCongTac,
                        principalTable: "ChuyenCongTac",
                        principalColumn: "MaChuyenCongTac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVienCongTac_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_Users_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeXuatFile",
                columns: table => new
                {
                    FileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDeXuat = table.Column<string>(unicode: false, nullable: true, defaultValue: "5"),
                    FilePath = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeXuatFile", x => x.FileID);
                    table.ForeignKey(
                        name: "FK_DeXuatFile_deXuatThanhToans_MaDeXuat",
                        column: x => x.MaDeXuat,
                        principalTable: "deXuatThanhToans",
                        principalColumn: "MaDeXuat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Id = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_UserClaim_Users_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Users",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.MaNhanVien, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Users",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.RoleId, x.MaNhanVien });
                    table.ForeignKey(
                        name: "FK_UserRole_Users_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Users",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.MaNhanVien, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Users",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[] { "home titleee", "this is home page" });

            migrationBuilder.InsertData(
                table: "CapBac",
                columns: new[] { "MaCapBac", "MoTa", "TenCapBac" },
                values: new object[,]
                {
                    { "c1", null, "CAP1" },
                    { "c2", null, "CAP2" },
                    { "c3", null, "CAP3" },
                    { "c4", null, "CAP4" },
                    { "c5", null, "CAP5" },
                    { "c6", null, "CAP6" }
                });

            migrationBuilder.InsertData(
                table: "ChiPhi",
                columns: new[] { "MaChiPhi", "MoTa", "TenChiPhi" },
                values: new object[,]
                {
                    { "CP3", "Tien ở khách sạn", "Luu tru " },
                    { "CP4", "Tien ở khách sạn", "Ve tau,xe" },
                    { "CP1", "Tien ở khách sạn", "Khach San" },
                    { "CP2", "Tien ở khách sạn", "Ve may bay" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "TenPhongBan" },
                values: new object[,]
                {
                    { "a0001", "Phong kinh te" },
                    { "a0002", "Phong CNTT" },
                    { "a0003", "Phong dao tao" },
                    { "a0004", "Phong truyen thong" },
                    { "a0005", "Phong Ngon Ngu" },
                    { "a0006", "Phong ctsv" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { "RL04", "nhân viên phòng kế toán", "Phòng kế toán" },
                    { "RL01", "Quản trị hệ thống", "admin" },
                    { "RL02", "nhân viên trong một phòng ban", "Nhân viên" },
                    { "RL03", "trưởng bộ phận của một phòng ban", "Trưởng bộ phận" },
                    { "RL05", "lãnh đạo nhà trường", "Lãnh đạo nhà trường" }
                });

            migrationBuilder.InsertData(
                table: "DinhMuc",
                columns: new[] { "MaChiPhi", "MaCapBac", "DonVi", "SoTienDinhMuc" },
                values: new object[,]
                {
                    { "CP1", "c1", "dem", "200000" },
                    { "CP4", "c6", "luot", "300000" },
                    { "CP4", "c5", "luot", "250000" },
                    { "CP4", "c4", "luot", "200000" },
                    { "CP4", "c2", "luot", "120000" },
                    { "CP4", "c1", "luot", "100000" },
                    { "CP3", "c6", "ngay", "400000" },
                    { "CP3", "c5", "ngay", "350000" },
                    { "CP3", "c4", "ngay", "300000" },
                    { "CP3", "c3", "ngay", "250000" },
                    { "CP3", "c2", "ngay", "200000" },
                    { "CP3", "c1", "ngay", "150000" },
                    { "CP4", "c3", "luot", "150000" },
                    { "CP2", "c5", "luot", "2600000" },
                    { "CP2", "c6", "luot", "3000000" },
                    { "CP1", "c2", "dem", "250000" },
                    { "CP1", "c3", "dem", "300000" },
                    { "CP1", "c5", "dem", "400000" },
                    { "CP1", "c4", "dem", "350000" },
                    { "CP2", "c1", "luot", "1500000" },
                    { "CP2", "c2", "luot", "1700000" },
                    { "CP2", "c3", "luot", "2000000" },
                    { "CP2", "c4", "luot", "2300000" },
                    { "CP1", "c6", "dem", "500000" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNhanVien", "MaCapBac", "MaPhongBan", "TenNhanVien" },
                values: new object[,]
                {
                    { "TT003", "c2", "a0004", "Tran Huy Hoang" },
                    { "NN001", "c2", "a0005", "Pham Hai Yen" },
                    { "TT004", "c5", "a0004", "Vu Tuan Tu" },
                    { "TT006", "c3", "a0004", "Nguyen Thi Nga" },
                    { "TT002", "c4", "a0004", "Tran Thuy Duong" },
                    { "TT005", "c6", "a0004", "Nguyen Van Thieu" },
                    { "NN006", "c3", "a0005", "Bui Sy Thang" },
                    { "CT003", "c1", "a0006", "Ho Xuan Ngoc" },
                    { "NN004", "c1", "a0005", "Mai Xuan The" },
                    { "NN003", "c4", "a0005", "Mai Lan" },
                    { "NN005", "c5", "a0005", "Nguyen Bich Tram" },
                    { "CT001", "c2", "a0006", "Le Thi Quy" },
                    { "CT005", "c5", "a0006", "Hoang Ngoc Ha" },
                    { "CT002", "c6", "a0006", "Nguyen Van Lich" },
                    { "TT001", "c1", "a0004", "Nguyen Ngoc Quang" },
                    { "NN002", "c6", "a0005", "Tran Hoang Duong" },
                    { "DT004", "c6", "a0003", "Le Huyen Trang" },
                    { "KT005", "c6", "a0001", "Nguyen Quoc Tuan" },
                    { "DT006", "c4", "a0003", "Mai Tien Dung" },
                    { "KT002", "c3", "a0001", "Nham Ngoc Tan" },
                    { "KT001", "c1", "a0001", "Ha Huy Khoai" },
                    { "KT003", "c4", "a0001", "Nguyen Hong Nhung" },
                    { "KT004", "c2", "a0001", "Hoang Ngoc Tung" },
                    { "KT006", "c5", "a0001", "Nguyen Lam Tung" },
                    { "CT004", "c3", "a0006", "Nguyen Thi Hai" },
                    { "IT002", "c3", "a0002", "Mai Thuy Nga" },
                    { "IT003", "c1", "a0002", "Vu Duc Thi" },
                    { "IT001", "c2", "a0002", "Cao Kim Anh" },
                    { "IT004", "c4", "a0002", "Pham Phuong Thanh" },
                    { "IT006", "c5", "a0002", "Nguyen Duc Dan" },
                    { "IT005", "c6", "a0002", "Tran Thi Hue" },
                    { "DT001", "c1", "a0003", "Nguyen Thi Hoa" },
                    { "DT002", "c2", "a0003", "Tran Quoc Hung" },
                    { "DT003", "c3", "a0003", "Nguyen Canh Toan" },
                    { "DT005", "c5", "a0003", "Nguyen Duc Khoa" },
                    { "CT006", "c4", "a0006", "Dang canh Khanh" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MaNhanVien", "PasswordHash" },
                values: new object[,]
                {
                    { "KT002", "AQAAAAEAACcQAAAAEMFM+j5PdUpv8gI2XV3fAx67suR1LwlOD5uEFANYv0gn4wTqxsCo2KORoYIOpLx1VQ==" },
                    { "TT004", "AQAAAAEAACcQAAAAEGJeLT4mERV5ocemnMGPeV4WiXZkgoVy6/fDHm9kzoPTdgmK6jKs5LzWkhrAmUeXaA==" },
                    { "TT006", "AQAAAAEAACcQAAAAEPMlFIUL6aCTpf750czcaZrqg5SEryvnbRtn3bCTEEehXZQyu0rA278J1Qco/FmqpA==" },
                    { "TT002", "AQAAAAEAACcQAAAAEAb6+5L7ReZE+1vnHyMY7+bKxfgbXbOMaPUISSp35moskw3YlbANCTQhKz9/NOFBbg==" },
                    { "TT005", "AQAAAAEAACcQAAAAEMLlL/H1FXZCZZ5QrtHCMtZDY9XkiU4QkJtjCE4md2BegPPyh7LG9VF8pRqeLHXlVg==" },
                    { "NN001", "AQAAAAEAACcQAAAAEG+z5ltsORE7McMMA0yWg0lkBhNZ/Nr9wEf5ye98HwY/DAcUuuymtZJX8Azsuv5XaQ==" },
                    { "NN006", "AQAAAAEAACcQAAAAEIf0oSOmkpjgZzyX/M5JGgF/rYNZXbtWxBqBPAAOZt59eEDMhxjdDGhymtLzR3y3bQ==" },
                    { "TT003", "AQAAAAEAACcQAAAAEBsiAahewEu+apjYa34JAaTU0CCDI602ck5q99q1vadvu48EJllIpXlKXlFx3mC1Tw==" },
                    { "NN002", "AQAAAAEAACcQAAAAEKWbo6POK16nGnady36H3nuaerIpuGqdjRL3htzzHsnXpgQQR/Uh7pHs8tQqT7ffoQ==" },
                    { "NN003", "AQAAAAEAACcQAAAAEHPI5G/O5+2Ee+4vtw31faucVPCb1eM6X6NxydN7P7CjFdBMgD6UvvY6fKGKeb3NkQ==" },
                    { "NN005", "AQAAAAEAACcQAAAAEAthp/+VjGosuJWAoubMW1XuDmyWUKwxILt2a+v8ASwpAsPWR9SH3CVSMPuLWIRSdw==" },
                    { "CT001", "AQAAAAEAACcQAAAAEPY+nfThNzOvjsYlQdkpdC+GAj8CFNeZZrdHxbgZ0f9T02V2GWrDvGvTLpKAz4NeXg==" },
                    { "CT003", "AQAAAAEAACcQAAAAELHbzmloXVxUwSu0rvLJgAamTQ2hiNIS4RtKqPdn0SxyweMwfajWxtgIpW+WRwgClQ==" },
                    { "CT005", "AQAAAAEAACcQAAAAEBL10ijydyldjyn3W2miUJdl1PrckFpx5aj1c/eGT2AbTPewyTuMQpouTL7JfivKmA==" },
                    { "CT002", "AQAAAAEAACcQAAAAEHJVpagEspSQ0p42jpsuuAJfCEYgzKqCJtfRn9UbK+dlz1s24PcxDrTPVjh7T9D6XQ==" },
                    { "NN004", "AQAAAAEAACcQAAAAELAm64AZsmu7rtHBX82v7QjgJzgDpt4Zjs5VuWFZK7E5tlV2JB/hX3h3sy+o56/9LQ==" },
                    { "TT001", "AQAAAAEAACcQAAAAEPOJIbI2I9ZSDUDUIez1FqpvXFg4BvzAXe234h1d+drf4SvcYW6sPMEnkAgR9/g+Ng==" },
                    { "DT004", "AQAAAAEAACcQAAAAEOvFWchC/mUfvSV4TlaF2lr9r/NJe0XIsBLJZuHPngT9tgv0xcG80nSzbps56g256w==" },
                    { "DT005", "AQAAAAEAACcQAAAAEHH8nw/9rFbN5EZSlbLt9+dC7OJuBUQjulzzGQ+BhBYGaYg8oVPXfaAG7tyJCPGlbA==" },
                    { "KT001", "AQAAAAEAACcQAAAAELr1QdcGwX9xwUxhdif5DGfoZ/IoyTrUEBiVXJtjUFzjSvLEyozN6pipyKJHb5wxMA==" },
                    { "KT003", "AQAAAAEAACcQAAAAEBLiQXXFpopaq09kl1TktW5HOcUm+s5eOhdqphpMK1CHGrqb21R4d1fLWhbDfXrkyA==" },
                    { "KT004", "AQAAAAEAACcQAAAAEOkS7cBxvnxwlBpEkDwU7MwNuO4KJrE32LpKWoFWShvD1qQrZJjvTNISVDvPpCOfqg==" },
                    { "KT006", "AQAAAAEAACcQAAAAEM7y9878EqXRKm9eswN7wOQbZkBqCFcqqbwA/0JLTGkKZvfkWEL2DJthQERSTGs9mw==" },
                    { "KT005", "AQAAAAEAACcQAAAAEN8RtilXSOp9hL8SiTAeiymsZLbrd++n2y8vSVllm0quqdiPB5u+6nzhXvUiittxxg==" },
                    { "IT002", "AQAAAAEAACcQAAAAEOCOAJoXkl+MS6qL0NTIYQYK3WVQN9jqilsyXWvZeeWqS0Ukj1ip3FXXa0eZN/etRQ==" },
                    { "IT003", "AQAAAAEAACcQAAAAEI0OtooXYfy2ZA7JUA7F+vFiUt7hopQZy5/1EpDlJb/VyK5cSu71XdJfEUowClCrRQ==" },
                    { "IT001", "AQAAAAEAACcQAAAAEJ9+868NqhU4oKEGoSdeWIP5DdVugzxjBjJPUjQ1ZynMgNnsJmIlWVKou4ZGAXmWMA==" },
                    { "IT004", "AQAAAAEAACcQAAAAEMJcNAGd95tM39lp6K5ju7YaoB7HlNr2fOcMbXBEakB/Ibxy8qdj6hUqWVASAiU8Hg==" },
                    { "IT006", "AQAAAAEAACcQAAAAEJ1ml5HjGjRXDtrVdsWwZKWbN3X1bhS9MglzH4p2QMt82/9wV3H28XumroiWzhsoHQ==" },
                    { "IT005", "AQAAAAEAACcQAAAAEOBv69DuAurDYN0ITcBs4cM0ny2kiIIEmBDryVNclKgH5z8aT+AybUZzCTmUSI3Shw==" },
                    { "DT001", "AQAAAAEAACcQAAAAEPXt9SAo3kJ1EFgfMxobx3Fb3lSHWeLx1toFnm+JjAuuWP7ULMIiAFq92RkcckaUsg==" },
                    { "DT002", "AQAAAAEAACcQAAAAEGD7bs7Rrf7I/Vu4TPP/f2ddXCNJ18lDn4v0wrllF2LlaGb5JS9s08IgZJNzI6mUgg==" },
                    { "DT003", "AQAAAAEAACcQAAAAEKl15I2fUMKBWyvvEaIf6WUJ5+CQcpDEpoo05lDQnVm+GzG/Usls4WTm9hBQAdQ1ZA==" },
                    { "DT006", "AQAAAAEAACcQAAAAEDrlDp7vIpupwTvZEjExEowRFstOvnZN8n/LGdAUs5ZeciAJZ+5tQAQfeEUxjjotGw==" },
                    { "CT004", "AQAAAAEAACcQAAAAEAPY03OUIrvvvd4gF7LnCvSWYHRhOIquEkUV61GUtj0QsryHGFTjSgsIknVKkj1UDg==" },
                    { "CT006", "AQAAAAEAACcQAAAAEAQ/FXNacGOXbhaskhMYnzgksokXOfaTsKlyKbkljCc7XMKcikjJbgiIMQKmrD+kRw==" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "MaNhanVien" },
                values: new object[,]
                {
                    { "RL01", "KT001" },
                    { "RL01", "IT001" },
                    { "RL01", "DT001" },
                    { "RL01", "TT001" },
                    { "RL01", "NN001" },
                    { "RL01", "CT001" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhiCongTac_MaChuyenCongTac",
                table: "ChiPhiCongTac",
                column: "MaChuyenCongTac");

            migrationBuilder.CreateIndex(
                name: "IX_DeXuatFile_MaDeXuat",
                table: "DeXuatFile",
                column: "MaDeXuat");

            migrationBuilder.CreateIndex(
                name: "IX_deXuatThanhToans_MaNhanVien",
                table: "deXuatThanhToans",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DinhMuc_MaCapBac",
                table: "DinhMuc",
                column: "MaCapBac");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVienCongTac_MaNhanVien",
                table: "NhanVienCongTac",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaCapBac",
                table: "NhanViens",
                column: "MaCapBac");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_MaPhongBan",
                table: "NhanViens",
                column: "MaPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_MaNhanVien",
                table: "UserRole",
                column: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "ChiPhiCongTac");

            migrationBuilder.DropTable(
                name: "DeXuatFile");

            migrationBuilder.DropTable(
                name: "DinhMuc");

            migrationBuilder.DropTable(
                name: "NhanVienCongTac");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "deXuatThanhToans");

            migrationBuilder.DropTable(
                name: "ChiPhi");

            migrationBuilder.DropTable(
                name: "ChuyenCongTac");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "CapBac");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
