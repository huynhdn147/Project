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
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 11, 17, 36, 5, 251, DateTimeKind.Local).AddTicks(1395))
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
                    { "CP2", null, "Ve may bay" },
                    { "CP3", null, "Luu tru " },
                    { "CP4", null, "Ve tau,xe" }
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
                    { "KT002", "AQAAAAEAACcQAAAAEM/7oLXGlEdLX7qbSeMwAeDhTrsenfLlpUyMbDsPUbVCmX/+h7j5n5idDOIq4ZROKw==" },
                    { "TT004", "AQAAAAEAACcQAAAAEExb24ygB74DPKSJAAeJCJFIkZeE2qa2rZW0gFz9zPNddT9MQtLW5NV83I3Zvq6o/w==" },
                    { "TT006", "AQAAAAEAACcQAAAAENr4O/ichRv/Nw4lG51qcyyZin6k++HUCvk3Fi7wEQIG3GxIKsJmtExdoaZG/C8ERA==" },
                    { "TT002", "AQAAAAEAACcQAAAAEFHWkYjmP2kS80WNXezO+VcFJdA5Uj6C20M1wlVYkUx1fJcUXpv2CFs85HiRMmgZDQ==" },
                    { "TT005", "AQAAAAEAACcQAAAAEMA+XmRLfCynWSn3Qqo5BsQc/nIytn2Oe0NbSlCUNPfBtpuDFIfH+HH8ZXBJzz3FPA==" },
                    { "NN001", "AQAAAAEAACcQAAAAEMS+xo4r55zExDcr05pMEXMrDxHR/iPZlSFCyb+E5Ra1bC+tuY0k1Gs+NFGJXwynrg==" },
                    { "NN006", "AQAAAAEAACcQAAAAEBkqpH2fDkg9Mk6GjnnbgflKVdk/ZrzIQgMo3IHetX6MFOKFVawGM6LCNUqR16wF3Q==" },
                    { "TT003", "AQAAAAEAACcQAAAAEDohoPsBCSRDfgoSmkqyLxpBFRAk140CNKTOwvkP2+rROnbRPlw9yEVsTeeFIYkSqA==" },
                    { "NN002", "AQAAAAEAACcQAAAAEAgk6M4bBTfo5/KY4Rp9rRmFfYZBZXrG3x4DWPpMuiIVLbbWyiGNVG3KFOrn9fyAWA==" },
                    { "NN003", "AQAAAAEAACcQAAAAEJY6sAbGuLH5diwYxGJQKDFUIFxsKU3Avj8dT0rvc/b8GQqA0iKVYEXmOlVTj24XLA==" },
                    { "NN005", "AQAAAAEAACcQAAAAEKnsaECbHt/M4JSLprwJFodm8AVUcpWPIhyrxsRGKrOV6gKd9xpvJsho1YMcyNQyGg==" },
                    { "CT001", "AQAAAAEAACcQAAAAEJS8LWAc9qfDYIYnbusM7iNAh6lLBwxKLxW7/WtIUtfG2MgUih+12S5TjJHV5cr46w==" },
                    { "CT003", "AQAAAAEAACcQAAAAEHZWZH5Ivi2q6W8Lc4NjaZULIPENGRMT4QzpOYI7+/8Q8Ilkne3Cs7zxmmmDlp3pdQ==" },
                    { "CT005", "AQAAAAEAACcQAAAAEFUOh9W7wyW4IKMXeYZgDaNZrfMOh8sKqmNvjFcKQmU/eCK9+hrR5evcXNvDgWGbFg==" },
                    { "CT002", "AQAAAAEAACcQAAAAEP42Ej7H3QBH2Td4zszyV+TNCe8DL4vKLb08kKEaeKcurQVfVa9LE8HKc3+qKOFiFg==" },
                    { "NN004", "AQAAAAEAACcQAAAAEKRwIZ0NlX9F73nSqMnkFU4jskp2ioUxZuIexaOk2FVT3HZVHOWjEmuvt96uJnQmuA==" },
                    { "TT001", "AQAAAAEAACcQAAAAEPJ/LBEKXF5flooJVPtPBp095Cw7KpSu1ybWDeqbgZxhAh68M9oerQiQ3LxC/61qVQ==" },
                    { "DT004", "AQAAAAEAACcQAAAAEHqRhtoB/PBmAN9flDEv5Sv+LOCXdHCAfTmKUKX9FiS/wfAnP8MkmRh6mYBE4hraOA==" },
                    { "DT005", "AQAAAAEAACcQAAAAEGIkDP7wKRhYeRx7rk6Z08t/q8gTLfcdsrDe/xRbLCENU79U5N5U6Gn8PqV3+2hc7w==" },
                    { "KT001", "AQAAAAEAACcQAAAAEM7oRIM0ttPfee6T86WxQoqgCFmrasX8Wuqqu0d5qpfeNlx6W/a4cwmVxCwsOgneeQ==" },
                    { "KT003", "AQAAAAEAACcQAAAAEPs8jXgiXJLHVksJu12g4/eM/ibpU1T91d3XbBrCE4Jk8hvhmyoIc/t1PXDd+3IIkQ==" },
                    { "KT004", "AQAAAAEAACcQAAAAEKLZeMQGgNMXYXd7Rb9+QRMGeN75XJ0xrMGnB6uig5APHrJjtYycoMfxpTnzmBXNRQ==" },
                    { "KT006", "AQAAAAEAACcQAAAAEAEcTvaRM6goG6/qsYBhlijy/5FII9yFmF5US7dtpSUjUoyfnSCP11PZTPwLX8LK1Q==" },
                    { "KT005", "AQAAAAEAACcQAAAAEKNNpmf7eoL0e9WKL68mpOG0x6qfjy/eWGgkA0LOaonXZr6NPRhUe+2vGKQn79F3xA==" },
                    { "IT002", "AQAAAAEAACcQAAAAEKp9uuiweUu/tK138Wn8Lac1OPljjjnDhfofBplIXW66g0HXp++QWVjIH96ouVC03Q==" },
                    { "IT003", "AQAAAAEAACcQAAAAEJr8rB2FC+Cfh7wfukmu5dSZ4zjAd18H0ZfdmCBZyGN9GeMYCTnQdSDTzFoPJ0EhVA==" },
                    { "IT001", "AQAAAAEAACcQAAAAEMVNfF3VrZMY1b/B8p7ZC18BVyni/qIvHVEpvjVtYs2W4NmWmi1O8rBBDDayYK51Rw==" },
                    { "IT004", "AQAAAAEAACcQAAAAEOJ0UVaITmWQPefrGPSJXQzbpI9Bae87LYPmphMOnegioliVcT8M1vTmuOFR2SWfNw==" },
                    { "IT006", "AQAAAAEAACcQAAAAEB8ewdjZp7VZwbPWaW2PT/FqVrhIHgjs9d0BjQjQrnEUYjm5ZMoop1+QltNvvfNOWQ==" },
                    { "IT005", "AQAAAAEAACcQAAAAEASfyNPAnISNY9tseCjtWRQkCawI0Z65oPZGsWYAaOjDVZ5NsiIcnYfFxj1aCJjQtg==" },
                    { "DT001", "AQAAAAEAACcQAAAAEO70ht52liFUEI+BJrupt6czv8fpJbr9CgoUeEXLbUeAodY+BCozUElsDqyN8V/62Q==" },
                    { "DT002", "AQAAAAEAACcQAAAAEJE4LCHMYkMvEGW9yy11bHYI4w3QV3ulD3k7lUKzYkIGZlN1zkgr/YTpbRPAhxPwfQ==" },
                    { "DT003", "AQAAAAEAACcQAAAAEA/L2wZjsUAezKHFwdnZymz5nDhwO8hHpK+zxhVShql0x3MyJOgE4b2zlDo3cR5NyA==" },
                    { "DT006", "AQAAAAEAACcQAAAAEDD/ZLbRkLl3tAzAvQYm4/HFY0IOiWQ6k/BKYDszgU/c0FvaOVBkTg2Ul7XTgfSlzg==" },
                    { "CT004", "AQAAAAEAACcQAAAAEEVHy9Z3CnNxgiW97AjiJhLoqY60VOi1C5G6NBdFjzY2Gz002dRVIFh74j6GGaP+dw==" },
                    { "CT006", "AQAAAAEAACcQAAAAEE4usZs4VMh6YCm/RYD5BrGwHbsRXFeM2ziFhHNU88S4rOoj9FCs9l5n3WBzmmRb8w==" }
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
