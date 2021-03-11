using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateData_V1 : Migration
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
                    NgayBatDau = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    NgayKetThuc = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    DiaDiem = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false, defaultValue: false)
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
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 11, 17, 56, 5, 284, DateTimeKind.Local).AddTicks(3305))
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
                name: "ChiPhiCongTac",
                columns: table => new
                {
                    MaChiPhi = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SoTienChiTieu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhiCongTac", x => new { x.MaChiPhi, x.MaChuyenCongTac, x.MaNhanVien });
                    table.ForeignKey(
                        name: "FK_ChiPhiCongTac_ChiPhi_MaChiPhi",
                        column: x => x.MaChiPhi,
                        principalTable: "ChiPhi",
                        principalColumn: "MaChiPhi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhiCongTac_NhanVienCongTac_MaChuyenCongTac_MaNhanVien",
                        columns: x => new { x.MaChuyenCongTac, x.MaNhanVien },
                        principalTable: "NhanVienCongTac",
                        principalColumns: new[] { "MaChuyenCongTac", "MaNhanVien" },
                        onDelete: ReferentialAction.Cascade);
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
                    { "CP1", "Tien ở khách sạn", "Khach San" },
                    { "CP2", "Tien ở khách sạn", "Ve may bay" },
                    { "CP3", "Tien ở khách sạn", "Luu tru " },
                    { "CP4", "Tien ở khách sạn", "Ve tau,xe" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "TenPhongBan" },
                values: new object[,]
                {
                    { "a0006", "Phong ctsv" },
                    { "a0005", "Phong Ngon Ngu" },
                    { "a0004", "Phong truyen thong" },
                    { "a0001", "Phong kinh te" },
                    { "a0002", "Phong CNTT" },
                    { "a0003", "Phong dao tao" }
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
                    { "KT002", "AQAAAAEAACcQAAAAEK83H8I4Okv4kvdBS/P7Itz/f9q0bCOLeFOendAiAkKrZ9fyIbtRIc3A4Y6U+gFfvA==" },
                    { "TT004", "AQAAAAEAACcQAAAAEFo+DrsW1VlQOE5fCdTGpTLUTHWJ8EEaYkMNfDne2kzJKYr/pDZf4rzkhG+Ud/BKMw==" },
                    { "TT006", "AQAAAAEAACcQAAAAEFChzMVJPTD8NtVUddhB9i2B3yklW6RroOKxTiU/aQj6BtG5duDsP1HF+dNvC5U89Q==" },
                    { "TT002", "AQAAAAEAACcQAAAAEBlAgQeJJyETkbr0H4ETL63MleSDrVMPHSTiD7D/iLpov4XFaf+Uw/IVA+GJMXc7Ag==" },
                    { "TT005", "AQAAAAEAACcQAAAAEIffg02Yk/qABXfFQf9ydCeh3goj0UVJt3rIVBBBarPD5ttOAwgOhOCDTukJVm/fog==" },
                    { "NN001", "AQAAAAEAACcQAAAAEPQ7MLTfP5PWUOkdOKHg9wF83m2NGsOXvBnv9nx0eIHPi35J5PEurdppHbUOVXhpcg==" },
                    { "NN006", "AQAAAAEAACcQAAAAEMzu9SfjP3GBsDLNPZC+gXNSS+YZW9lOZXolBb7Hw8Y6jYPvgBgOaDRQLUHzJmEhvA==" },
                    { "TT003", "AQAAAAEAACcQAAAAEEOMDSsTRY3/eL4IOaNd+ss0Frm0Pp+ZtT6ENS9pS0bOaW9Xbfzz8vE5O2H3NQEu/g==" },
                    { "NN002", "AQAAAAEAACcQAAAAEOx31+RoTVcGO3hRQEekPSGWXzyNR07VmxU9Wca2rD4JsqObCrcSgXr/s2NjxU7iOA==" },
                    { "NN003", "AQAAAAEAACcQAAAAEGl2NuuXMvZJdoIwYkDpMpZTIlNFBTYLDuDczK2T9ni7lgzBYgwA7hcKs6bKLF74dA==" },
                    { "NN005", "AQAAAAEAACcQAAAAEGG5VoHsQ0IyRmexOKJd1BTnY3+oxM0T15buHN2Emjawri2ZmkS0FD+sxHYZmFuRRA==" },
                    { "CT001", "AQAAAAEAACcQAAAAEK39bX4haJJTX1Icc2yngWn8RUql/ewc1aYOcFwnsOIHdc9fJGaNqdFzWCyAC3ladw==" },
                    { "CT003", "AQAAAAEAACcQAAAAEC4Y6+0tVSf42cok3z0qiiduLS9EhdhKRxVfQmyIXy2ITvRHB/4MD7YxAs/VZ4+15w==" },
                    { "CT005", "AQAAAAEAACcQAAAAEECacmHKe+y/GiHgagZMzwwFfS5W2cKTgaK0I5jy0UETyrq/B4t0wNJOvcZ3BJjKFA==" },
                    { "CT002", "AQAAAAEAACcQAAAAEKizgtvSjz47YJcXgtIdOt67tjiwawBx8BXFCRIkYlUhWIy6LnFMBXRyc/s6EDi7ag==" },
                    { "NN004", "AQAAAAEAACcQAAAAEPJRCXr2X5NrEOgPF8CM2IyXG8Fbp+VeDAkbv6cI2JzS5WhDUMuUKNW+Nf74HuciTQ==" },
                    { "TT001", "AQAAAAEAACcQAAAAEEKZIsBsyCm8+SO51ExllMWEpuuYicrIhe4Da/OdppKaXWZzSlqNcortizfY6/wurA==" },
                    { "DT004", "AQAAAAEAACcQAAAAEBF6fZZpeEC/imwPFCvP7C/l2/XokEJq7KgWEAEqsNDB9LOHmuW10TSBjsDbt9du8Q==" },
                    { "DT005", "AQAAAAEAACcQAAAAEA+Y91jJ+AHzu7/5cMxLC6ua7DsB4llcqhd8B6/a0bJrePAVRMO6/9k8x3a+aBoldQ==" },
                    { "KT001", "AQAAAAEAACcQAAAAEDOu7m5sg6NPEqXyjzNOoJeVMRESGNgiVipRty/Fo41PttYi09IjjnFWZ+l9O2wuSQ==" },
                    { "KT003", "AQAAAAEAACcQAAAAEAFg+yi9zSwHyXnsGFv79zkqK4bRGfW8l4RMLJPDmF9SoTX0v//QeSTB5u6PlTz0ow==" },
                    { "KT004", "AQAAAAEAACcQAAAAEALH+OYJLB0HZECHlhvYeg0i+GDqFCou71gZXtmirEZF5oUzw5bcrYz4bf1vmCKFRg==" },
                    { "KT006", "AQAAAAEAACcQAAAAEOZVfOArG/E0ZXfO2fPKEXVT4xku0IFyr+kElq4zH+WApixciTfw1vgSqFwo0ABcyA==" },
                    { "KT005", "AQAAAAEAACcQAAAAEF653wC+Aav56KbcDwenSRCA5wVNGA20N63blBxYfTfADO6OuwsAJdkygYolFOxFtA==" },
                    { "IT002", "AQAAAAEAACcQAAAAECt1F7cVvL+ljNPB2bWKaOmxoiFSAWgEc2YnQKobk86QrsiyDLeZdc3Etn7LRAiGxg==" },
                    { "IT003", "AQAAAAEAACcQAAAAEAFvqh6Anrs0e5jr6dX8YqK55ENJuSxDCp9ftQxkmmN3BtarSL3HLqXDghf2SFJgAg==" },
                    { "IT001", "AQAAAAEAACcQAAAAEBRZ6dpavAIjO0z7ji/feHqcYLEABdBSRlD4QEBJhHiqAM+Mrln85rQP2IvcKQUDUg==" },
                    { "IT004", "AQAAAAEAACcQAAAAEItpqugJSPH4gNa7x2fivYQr+Hom3kldZKCseYfQZKkwVgk5TDkqpq8f3PfCeS4heQ==" },
                    { "IT006", "AQAAAAEAACcQAAAAEJWV4nvm0WCdanm1uHg4EL09YLp/JD93AtufKaqozM+INTEF4Dsnm+VBXb7WaT56RA==" },
                    { "IT005", "AQAAAAEAACcQAAAAECl/Ep3uH984PrKTeXqQf/FZbdVEIo/9E2O+sDYQDbZ3Kqyqv5yU2xpakQ3rgfk0gQ==" },
                    { "DT001", "AQAAAAEAACcQAAAAEMyWBRP66mhruvA1QRKJCdPmcI7kHOQ0AKOnyC6FZfElEO67dMRUisHiVUZ6OEKCcQ==" },
                    { "DT002", "AQAAAAEAACcQAAAAEKyo/HmMQ/L4ywKbPI3Z6p4cwBjV93mqe+Ll2SMLLyJHA/k2XPYwx2gim1zHQOLs0w==" },
                    { "DT003", "AQAAAAEAACcQAAAAENOuX0ir3BcDZvKcPvLBm276yS2sy0H41FBQP2pKURPkmjGFDU6DrCap88L/WiYalg==" },
                    { "DT006", "AQAAAAEAACcQAAAAEN1iwUzRth5yJI5foKSn+KcwkBmwt+pTxX1CvirzuS1foZAGMzVyss+o4NQ8titGgQ==" },
                    { "CT004", "AQAAAAEAACcQAAAAEGOHtQDXkCb6fPBFk+MQztNQudIOPTfyiFQMiXuKLr0gM2S9lcpo8VepPi41+4n4rQ==" },
                    { "CT006", "AQAAAAEAACcQAAAAEFZYvTsP+TdhAQtLeD0TkCGq+YM84nU0xzPJOZuNmBwMGJO9xlnhzA9zKJZRYEXkkA==" }
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
                name: "IX_ChiPhiCongTac_MaChuyenCongTac_MaNhanVien",
                table: "ChiPhiCongTac",
                columns: new[] { "MaChuyenCongTac", "MaNhanVien" });

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
                name: "deXuatThanhToans");

            migrationBuilder.DropTable(
                name: "DinhMuc");

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
                name: "NhanVienCongTac");

            migrationBuilder.DropTable(
                name: "ChiPhi");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ChuyenCongTac");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "CapBac");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
