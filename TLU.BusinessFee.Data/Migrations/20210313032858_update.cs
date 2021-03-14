using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class update : Migration
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
                    NgayBatDau = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)),
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
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 13, 10, 28, 57, 906, DateTimeKind.Local).AddTicks(1454))
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
                    { "KT002", "AQAAAAEAACcQAAAAEHkkcx87/w3clEZBn7nLPVWAiIkUNYFkubJM16Hf5SRd91loBRvrMFlBDWfXWmOXUA==" },
                    { "TT004", "AQAAAAEAACcQAAAAEIzbCrm5oDUdiT5/bDbzvNe3nx9Fh5dBvzjC8AcAcnPUqnYHxRmylZItw57e6IfyKA==" },
                    { "TT006", "AQAAAAEAACcQAAAAEATBzcqqlpCIPBJz/jbGF1OynJ5dsk64ptyCkLkGk6g8Z6K9sUq9zShP33w4Faqi9g==" },
                    { "TT002", "AQAAAAEAACcQAAAAEAu0p+IKvRhUGIpqq509wlq15b3Qki4whVjbSjCpJVgwyUdEQo63ctRUDH6RqgyPsg==" },
                    { "TT005", "AQAAAAEAACcQAAAAEAm76nbM6OazZ+Kh2VutpL2mZwjdqF47/PJp9bh0bvwc+mMAnwFqsNePRvv9YqBrWA==" },
                    { "NN001", "AQAAAAEAACcQAAAAEO94hD6xn1hjm7vudJxDMaV/+bwmxu755KD9j79QSZ+4b6xrr+Y4FJNG//rSCwao/g==" },
                    { "NN006", "AQAAAAEAACcQAAAAENj8Lwaa1KMwUfwnK+0BKDKz836LML8Ae+HyGR/Kd4rBS/1aDPfPUXc5GQKvpN1Ovg==" },
                    { "TT003", "AQAAAAEAACcQAAAAEN2bLvk1uYYkGkRM4W0h8jjaMpxZvrgJRPRSCaVjSOwvNWE2TNmvOtn0oL+dFJBOFw==" },
                    { "NN002", "AQAAAAEAACcQAAAAEG/qGC+6nLNf+mkE2YGHTsoAhfLTfLZXVFI9ee68yFlzE6yWzNXjEicDjrsU1mlnXA==" },
                    { "NN003", "AQAAAAEAACcQAAAAEFD1kOGlpp6jEpyPzTJJhjMfz04cxdjdH/3BfaUCuqn8bUIsWaSqXcpzxOyUZRtNgw==" },
                    { "NN005", "AQAAAAEAACcQAAAAEHG2ZYUALOheHfER8gmg2HhSvvcwzys3Bk1L+XrjpCoItftQCm7LnHO3hlc8xN2nbA==" },
                    { "CT001", "AQAAAAEAACcQAAAAEO7ChhCETxzKGHt36fAo/OCNosaST9tO4DX5vN1KsAyPKs7HJkw2fzQp98U9QcFm2Q==" },
                    { "CT003", "AQAAAAEAACcQAAAAEHIcvM2RgAygu4ZVlQELB/nCVDoVH4kRpoBdSvDWKusakXWZyVsztUgdortSg/uqZw==" },
                    { "CT005", "AQAAAAEAACcQAAAAEMeiQIBTMPrUagXCUZHhr36oguY9Ck4Mf7KyChawl3Ic955EjC0R++EM7+7/5yYEGQ==" },
                    { "CT002", "AQAAAAEAACcQAAAAEBNojrox29scWE5OPYvhA2r+p+a5omFlp6060VeeAFfxS2K19hz7UYX1gRWFeFjOZA==" },
                    { "NN004", "AQAAAAEAACcQAAAAEPbuxkylxGRHu3V0sIP36HiVD56RNahQBUrY5jS2DVlmmyVcGUVu7VNkv+1H64kcXA==" },
                    { "TT001", "AQAAAAEAACcQAAAAEBFr9wY4yBIj5nR3c/V9LN5nEdfA5z4bYOHhUZLixA/Hl8/LhwF0FgayQIH5hOucog==" },
                    { "DT004", "AQAAAAEAACcQAAAAEMhWk7nuk9jzNtRMI90WZRa7RTcWVl29Ex4KcHPCB6FgzwWJr1YMEW24ltvIuB3rMA==" },
                    { "DT005", "AQAAAAEAACcQAAAAECddIw09tzZGH+ectXCTMXQkwVvOSo5NrJCNrzZ1keAsEWkxs1dYu2PVHMZL+Welfw==" },
                    { "KT001", "AQAAAAEAACcQAAAAEAf9zQvNz8wJ9NlVvUBoACsBW9dHmo33e2043pfSMqPDQI2fObG2vPckHbDUCZvSRQ==" },
                    { "KT003", "AQAAAAEAACcQAAAAEKunT6W/RLYRX6HRSktr+6RmOzlUW9oCI7f7ySTWQZKqm+a64g4cd9E9BYuIOrpcUw==" },
                    { "KT004", "AQAAAAEAACcQAAAAEIlvNaa0/w/Muhtv/aRZ+AzJT95eenjOF496AZtgHcDN6l7Pts/CqmsllLNdtTESrg==" },
                    { "KT006", "AQAAAAEAACcQAAAAEFMk+8tVB7egMHHpYZKSOGRaNtYorMnmhmnFqoJeHfQhcXcY7clicKCRUVRdMt/PZA==" },
                    { "KT005", "AQAAAAEAACcQAAAAEIBNdE30i3JX0f9tPa/c90zvSPsds8DLBem/MMP5JrmrfE+MmJU/6OYGNnW8pYwL3g==" },
                    { "IT002", "AQAAAAEAACcQAAAAEM++4+zHetnJaWCSAAqG6kGBRDgTxsNXit+N4B0MjS8oMTz+IeVbh3muAQ/beOBaLA==" },
                    { "IT003", "AQAAAAEAACcQAAAAEGTOh93N7PBAtRSPBxnE0/DMI5vLnLkKvs8vT24GWbqDq7vYNVQTIv8XlH3dM02Qfw==" },
                    { "IT001", "AQAAAAEAACcQAAAAEJRUpHOOGHnuI+FtLqWUxxsQn1pcKBHykGAQ87YOylb5R1sMVgd0PS3Kk5Ph0QnDog==" },
                    { "IT004", "AQAAAAEAACcQAAAAEMr4onVq8Zm/T7qy1kbUsmeDqF42VKRQXswqnZDsTPuP72rzmP3xzLfbqXm8rzF2pg==" },
                    { "IT006", "AQAAAAEAACcQAAAAEKKwOQxM4305EKfiB6hgszzDMJKa3gi8ZjhN44oFQBuxMBim/SoZcMxc7a85zfrAGw==" },
                    { "IT005", "AQAAAAEAACcQAAAAEN7Vmbg1n7iuGlH0cyxnkAPm3xNCBKT6M1Frrpexe+PihAHLIFkavYjI7n2jydF4PQ==" },
                    { "DT001", "AQAAAAEAACcQAAAAEGOEhSkdsNHcopSHAGtL1NAefbnLdK9YmnHWimI7d4OvT5VSgN/ru+KlNggWfvtmiw==" },
                    { "DT002", "AQAAAAEAACcQAAAAEOYUYVI/Pr4gMfEPmtM9n0GtuTX/iBhjIB7dCs1A0FOht0g8iiWlxr4lgLA13BOvPA==" },
                    { "DT003", "AQAAAAEAACcQAAAAEKO8s6kRhApEofXbslDUF61H/2GO3eDx5/4s0l3LXgOCQx5Tj2YmcJkE0q1MrIBBcA==" },
                    { "DT006", "AQAAAAEAACcQAAAAEEEmkmrVY7lEGMDqIUoetpn7Mj+ypfmbngkMM3um00BwW0oQ5e6jwpG3+P0kca7YKg==" },
                    { "CT004", "AQAAAAEAACcQAAAAECcxAy9JVB3EJ+ePghC8E+E2NFvEEBJcV+TC/+99QZOPrCF0z+0SVAcf4SCviF9Dxg==" },
                    { "CT006", "AQAAAAEAACcQAAAAEGWd/QJwT3ynR0ZaySiEU93enuPVLdcKrTJvxkNHCLxv6/9+MPP6wc/sxUtspz478w==" }
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
