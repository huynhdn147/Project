using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class addDb : Migration
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
                    NgayBatDau = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)),
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
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 30, 14, 15, 27, 991, DateTimeKind.Local).AddTicks(4990))
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
                name: "DeXuatThanhToan",
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
                    table.PrimaryKey("PK_DeXuatThanhToan", x => x.MaDeXuat);
                    table.ForeignKey(
                        name: "FK_DeXuatThanhToan_NhanViens_MaNhanVien",
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
                        name: "FK_DeXuatFile_DeXuatThanhToan_MaDeXuat",
                        column: x => x.MaDeXuat,
                        principalTable: "DeXuatThanhToan",
                        principalColumn: "MaDeXuat",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    { "C1", null, "CAP1" },
                    { "C2", null, "CAP2" },
                    { "C3", null, "CAP3" },
                    { "C4", null, "CAP4" },
                    { "C5", null, "CAP5" },
                    { "C6", null, "CAP6" }
                });

            migrationBuilder.InsertData(
                table: "ChiPhi",
                columns: new[] { "MaChiPhi", "MoTa", "TenChiPhi" },
                values: new object[,]
                {
                    { "CP1", "Tien ở khách sạn", "Khach San" },
                    { "CP2", "Tien ở khách sạn", "Ve may bay" },
                    { "CP3", "Tien ở khách sạn", "Luu tru" },
                    { "CP4", "Tien ở khách sạn", "Ve tau,xe" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "TenPhongBan" },
                values: new object[,]
                {
                    { "LD", "Lanh dao" },
                    { "TV", "Phong tai vu" },
                    { "CT", "Phong ctsv" },
                    { "NN", "Phong ngon ngu" },
                    { "KT", "Phong kinh te" },
                    { "DT", "Phong dao tao" },
                    { "IT", "Phong CNTT" },
                    { "TT", "Phong truyen thong" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { "RL04", "nhân viên phòng tài vụ", "Kế toán" },
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
                    { "CP1", "C1", "dem", "200000" },
                    { "CP4", "C6", "luot", "300000" },
                    { "CP4", "C4", "luot", "200000" },
                    { "CP4", "C3", "luot", "150000" },
                    { "CP4", "C2", "luot", "120000" },
                    { "CP4", "C1", "luot", "100000" },
                    { "CP3", "C6", "ngay", "400000" },
                    { "CP3", "C5", "ngay", "350000" },
                    { "CP3", "C4", "ngay", "300000" },
                    { "CP3", "C3", "ngay", "250000" },
                    { "CP3", "C2", "ngay", "200000" },
                    { "CP3", "C1", "ngay", "150000" },
                    { "CP4", "C5", "luot", "250000" },
                    { "CP2", "C5", "luot", "2600000" },
                    { "CP2", "C6", "luot", "3000000" },
                    { "CP1", "C3", "dem", "300000" },
                    { "CP1", "C4", "dem", "350000" },
                    { "CP1", "C5", "dem", "400000" },
                    { "CP1", "C2", "dem", "250000" },
                    { "CP2", "C1", "luot", "1500000" },
                    { "CP2", "C2", "luot", "1700000" },
                    { "CP2", "C3", "luot", "2000000" },
                    { "CP2", "C4", "luot", "2300000" },
                    { "CP1", "C6", "dem", "500000" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNhanVien", "MaCapBac", "MaPhongBan", "TenNhanVien" },
                values: new object[,]
                {
                    { "CT009", "C3", "CT", "Nguyen Canh Toan" },
                    { "CT001", "C1", "CT", "Vu Hong Hoa" },
                    { "CT008", "C2", "CT", "Tran Quoc Hung" },
                    { "CT007", "C1", "CT", "Nguyen Thi Hoa" },
                    { "CT006", "C6", "CT", "Do Huyen Trang" },
                    { "CT005", "C5", "CT", "Nguyen Dang Khoa" },
                    { "CT004", "C4", "CT", "Luong Xuan Truong" },
                    { "CT003", "C3", "CT", "Nguyen Van Toan" },
                    { "CT002", "C2", "CT", "Tran Huy Hung" },
                    { "NN012", "C6", "NN", "Nguyen Van Thieu" },
                    { "NN007", "C1", "NN", "Nguyen Ngoc Quang" },
                    { "NN010", "C3", "NN", "Nguyen Thi Nga" },
                    { "NN009", "C5", "NN", "Vu Tuan Tu" },
                    { "NN008", "C2", "NN", "Tran Huy Hoang" },
                    { "NN006", "C6", "NN", "Nguyen Van Manh" },
                    { "NN005", "C4", "NN", "Tran Hoang Duong" },
                    { "NN004", "C3", "NN", "Nguyen Thuy Nga" },
                    { "NN003", "C5", "NN", "Nguyen Kieu Trang" },
                    { "NN002", "C2", "NN", "Tran Huyen Trang" },
                    { "CT010", "C4", "CT", "Mai Tien Dung" },
                    { "NN011", "C4", "NN", "Tran Thuy Duong" },
                    { "CT011", "C5", "CT", "Nguyen Duc Khoa" },
                    { "TV011", "C5", "TV", "Nguyen Duc Dan" },
                    { "TV001", "C1", "TV", "Ha Linh Giang" },
                    { "LD010", "C2", "LD", "Hoang Ngoc Tung" },
                    { "LD009", "C4", "LD", "Nguyen Hong Nhung" },
                    { "LD008", "C1", "LD", "Ha Huy Khoai" },
                    { "LD007", "C3", "LD", "Nham Ngoc Tan" },
                    { "LD006", "C6", "LD", "Mai Quoc Dat" },
                    { "LD005", "C5", "LD", "Phung Viet Hoang" },
                    { "LD004", "C4", "LD", "Nguyen Dinh Huynh" },
                    { "LD003", "C3", "LD", "Pham Minh Hang" },
                    { "LD002", "C2", "LD", "Nguyen Trong Son" },
                    { "LD001", "C1", "LD", "Mai Hong Ngoc" },
                    { "TV012", "C6", "TV", "Tran Thi Hue" },
                    { "NN001", "C1", "NN", "Nguyen Duc Quang" },
                    { "TV010", "C4", "TV", "Pham Phuong Thanh" },
                    { "TV009", "C2", "TV", "Cao Kim Anh" },
                    { "TV008", "C1", "TV", "Vu Duc Thi" },
                    { "TV007", "C3", "TV", "Mai Thuy Nga" },
                    { "TV006", "C6", "TV", "Do Thi Ha" },
                    { "TV005", "C5", "TV", "Do Thi Huong" },
                    { "TV004", "C4", "TV", "Pham Thuy Tien" },
                    { "TV003", "C3", "TV", "Pham Thi Thao" },
                    { "TV002", "C2", "TV", "Bui Mai Ngoc" },
                    { "CT012", "C6", "CT", "Le Huyen Trang" },
                    { "TT012", "C5", "TT", "Nguyen Bich Tram" },
                    { "DT012", "C2", "DT", "Nguyen Bao Ngoc" },
                    { "TT010", "C1", "TT", "Mai Xuan The" },
                    { "IT008", "C1", "IT", "Ho Minh Ngoc" },
                    { "IT007", "C2", "IT", "Le Thu Minh" },
                    { "IT006", "C4", "IT", "Dang Van Khanh" },
                    { "IT005", "C3", "IT", "Nguyen Trong Quang" },
                    { "IT004", "C6", "IT", "Nguyen Quang Thang" },
                    { "IT003", "C5", "IT", "Hoang Thuy Hang" },
                    { "IT002", "C1", "IT", "Ho Thao Ngoc" },
                    { "IT001", "C2", "IT", "Le Thu Trang" },
                    { "KT012", "C4", "KT", "Ngo Kien Huy" },
                    { "IT009", "C5", "IT", "Hoang Thanh Tra" },
                    { "KT011", "C3", "KT", "Tran Thuy Dung" },
                    { "KT009", "C5", "KT", "Hoang Lan Huong" },
                    { "KT008", "C1", "KT", "Pham Thu Thuong" },
                    { "KT007", "C2", "KT", "Do Van Truong" },
                    { "KT006", "C4", "KT", "Dang Quynh Anh" },
                    { "KT005", "C3", "KT", "Nguyen Ngoc Anh" },
                    { "KT004", "C6", "KT", "Nguyen Hoang Anh" },
                    { "KT003", "C5", "KT", "Hoang Thi Huong" },
                    { "KT002", "C1", "KT", "Pham Thu Hien" },
                    { "KT001", "C2", "KT", "Nguyen Van Truong" },
                    { "KT010", "C6", "KT", "Nguyen Anh Duong " },
                    { "IT010", "C6", "IT", "Nguyen Quang Huy" },
                    { "IT011", "C3", "IT", "Nguyen Trong Hoang" },
                    { "IT012", "C4", "IT", "Dang Van Trung" },
                    { "TT009", "C6", "TT", "Tran Hoang Duong" },
                    { "TT008", "C3", "TT", "Bui Sy Thang" },
                    { "TT007", "C2", "TT", "Pham Hai Yen" },
                    { "TT006", "C5", "TT", "Nguyen Bich Thao" },
                    { "TT005", "C4", "TT", "Mai Ha" },
                    { "TT004", "C1", "TT", "Nguyen Van Tan" },
                    { "TT003", "C6", "TT", "Nguyen Hoang Duong" },
                    { "TT002", "C3", "TT", "Nguyen Trong Thang" },
                    { "TT001", "C2", "TT", "Do Hai Yen" },
                    { "LD011", "C5", "LD", "Nguyen Lam Tung" },
                    { "DT011", "C4", "DT", "Dang canh Khanh" },
                    { "DT010", "C3", "DT", "Nguyen Thi Hai" },
                    { "DT009", "C6", "DT", "Nguyen Van Lich" },
                    { "DT008", "C5", "DT", "Hoang Ngoc Ha" },
                    { "DT007", "C1", "DT", "Ho Xuan Ngoc" },
                    { "DT006", "C2", "DT", "Le Thi Quy" },
                    { "DT005", "C4", "DT", "Dang Thanh Tung" },
                    { "DT004", "C3", "DT", "Nguyen Kim Lien" },
                    { "DT003", "C6", "DT", "Nguyen Thu Bich" },
                    { "DT002", "C5", "DT", "Hoang Kim Khanh" },
                    { "DT001", "C1", "DT", "Le Thu Trang" },
                    { "TT011", "C4", "TT", "Mai Lan" },
                    { "LD012", "C6", "LD", "Nguyen Quoc Tuan" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MaNhanVien", "PasswordHash" },
                values: new object[,]
                {
                    { "KT001", "AQAAAAEAACcQAAAAED2eJ9DA2p8NTuW68sljSGyUnOUk4xUvzmBwJo3yYLtUKq5K7bQykfMRd6IZA1bdog==" },
                    { "CT010", "AQAAAAEAACcQAAAAEJM4AjFDJibva4fIoEKgpyGrhkPJEM5gSXxeCdXYr8vtuC+xLfljgIY58+9wLy+6Og==" },
                    { "CT009", "AQAAAAEAACcQAAAAEGI+kXA7tg4S1ZXVk+0KtP/JysQEkp7ryiMywI4z/IEr/cFEcScE11qIVmSkU/WJkQ==" },
                    { "CT008", "AQAAAAEAACcQAAAAENRF96MEw6e8UiiG9IQUjEL7/4UEG6dT+S7L5HWXQmIUACBEj9qiv3C99p/gdFFjoQ==" },
                    { "CT007", "AQAAAAEAACcQAAAAEPpaoW26+RFzIipGs65aS/nKZSTJCbgqunwGCmQr1Q2mRfP+K5yboedNm7mjCwum5A==" },
                    { "CT006", "AQAAAAEAACcQAAAAEM++MuYFBEArsc/Aqb53X0oLvWffnmv86V0jcZF7UAJ4Dp1NsjJsRxcMvzPBstoK7Q==" },
                    { "CT005", "AQAAAAEAACcQAAAAEF8TngZHr0xzpyL8Qu20k1Ba6r5MD2rIaBqhAMYSqTZni8GNnb+99K2Ok10yCKTW7g==" },
                    { "CT004", "AQAAAAEAACcQAAAAEGTK8K3iCEWEjKnMNaTKGLelTD1pwyowq8DbyEwNy/sUwveRrfH7lH7CxVBlkw3xtw==" },
                    { "CT003", "AQAAAAEAACcQAAAAEBNJCBjH1pnOv6v1QT6HlWPJF4eLNQ2TiOWWUc81/mEG2Lnn+WgjkkIZ5KhAhcnheg==" },
                    { "CT002", "AQAAAAEAACcQAAAAEO4MOPz0IFJimj9DZAPS9dN1oZy8G9TNX5n+k4l37UmPgzxwHey5JlN8liaOtsfC7g==" },
                    { "CT011", "AQAAAAEAACcQAAAAEBUCaYmhxBcV699y1H6y78Vsax/SAVToUG5MaIQ8fVpcDd7BqXPDACJDdvmvLE311w==" },
                    { "CT001", "AQAAAAEAACcQAAAAEE2LtsFgOHKE/MNJiz5enSDaV3WnzeBVGedA9JzWAgeH97P3bUUvyOiCLO3u4UTb7g==" },
                    { "NN011", "AQAAAAEAACcQAAAAEBMXfKRBsC4Ks15H6r0nh2xXAvkzGjdAZqqxl37sN6ev1tDU9+omQuqrYZF+d1VRkw==" },
                    { "NN010", "AQAAAAEAACcQAAAAEE47W5AvjAYhars8djkY8KTI/Ijmoy+blu04SBCvFXbK0PBNfTK3dw1KbLTbASt6dA==" },
                    { "NN009", "AQAAAAEAACcQAAAAEPl8q8iErhv4B/Prt320dhV+HgCJNXW8OJIuxvtP6vT8NA3kZ7euZ5xuXqbnit/dVA==" },
                    { "NN008", "AQAAAAEAACcQAAAAEEibET5xNO98HDcVRj9BuTzv51lDrv4qQc8Oxo0JkE1DFec6GORS+uG/Kw6+DRtRbg==" },
                    { "NN007", "AQAAAAEAACcQAAAAEIiLyPt+fA9NAkFonqXllEs6b+iyxmXKz02jM2gFeRPSpOVdQQ2gspboh6Q3ieuzCg==" },
                    { "NN006", "AQAAAAEAACcQAAAAEFbBS5XSLfIuVokDB2joZUyakR9mGZrJ7qi2gh8cxL7IrHNqoOZnc1sekq6y9++LYQ==" },
                    { "NN005", "AQAAAAEAACcQAAAAEEPmVl//UE2n/nzAtm7kLG8yj4weNfG3j6Tz8W4DuSgS3gAGFSxavM586FqFUKdBMg==" },
                    { "NN004", "AQAAAAEAACcQAAAAEPQ+KWBBdecRlByvAphZ3mQf+4unjZIV385DRYVWGfTsfO6mzeyb/6TpcfQObZv8vQ==" },
                    { "NN003", "AQAAAAEAACcQAAAAEP3Soqh3YALAbsxb8zXPfbNyD5uO/VCZJdi7mRkv49RSoQnQIUm6WNP2/5WQoG1l+g==" },
                    { "NN012", "AQAAAAEAACcQAAAAEMOz0tMwA3kciwis9I9KlPJgYN4zYUYcC/CrXHqBhpmeBQ1fB88QKQAW8ygze5J5Cw==" },
                    { "NN002", "AQAAAAEAACcQAAAAEB0hOUfqIcI07SmQC2/VzjbntAni7iB/AGokQjB5jkk70UazICYui0zYLhmKilly2Q==" },
                    { "CT012", "AQAAAAEAACcQAAAAEN3cc77YI3SoEN1oKfU8wN11SbtWjjYlqwESoAO6JR24/MJCh9dp0wJk2vtjYH14Qg==" },
                    { "TV002", "AQAAAAEAACcQAAAAEIwVO6m7iZu2jYova+4JJSKvpOBuOe8BHzCtwu9BiDLBPKL6xrv/+KgkaVHa8XqfDw==" },
                    { "LD010", "AQAAAAEAACcQAAAAECbAhg6XbRxSBRLPuYn7YjeLTIHA1sQyj2zBKS+/TGUWp06rUdYp/FXxE5gQw1RMQA==" },
                    { "LD009", "AQAAAAEAACcQAAAAEBV4sUNiyZCKOhQo8o7EWiq5olL+4/af3Jjq716eDWtBTV2Wh/fIzLYMphi3fQUtuw==" },
                    { "LD008", "AQAAAAEAACcQAAAAEFaji5I4ushwnnftwIzkask9CUzi+dTDlAEtDf0jxSij4cobo6HmzfVskkzgn9wvyw==" },
                    { "LD007", "AQAAAAEAACcQAAAAEFhuyEVOUvqtqay/ptNPsz1AA+qzZt+8gt9rJkFmffi0U/XH7Krl1N2Fz4xoeu5TNA==" },
                    { "LD006", "AQAAAAEAACcQAAAAEFXATCADTtQn0q2DO3XjYEV1GcV42+Py+7YAb+KW3b+Y1yvSjAIC/wXTB41eZ9wpbA==" },
                    { "LD005", "AQAAAAEAACcQAAAAEOOt75WWwEBF712f8lM4bZ+AS6IjVb4BUw2l2Xb/AWKc61x6LyEbFDrRamipWTO6IQ==" },
                    { "LD004", "AQAAAAEAACcQAAAAEKar1VNBhcqQTI56L8md8yzRaBLP40ocHp1H8YioMCUkGgrRqbh/fvbq7yY9O9eeHQ==" },
                    { "LD003", "AQAAAAEAACcQAAAAEKVYJqBkXNCVI+ZKdeWPWzK/gFo/bVcHsgE/Sb3z2cpr5x+VfkuiiuhcbR+JJp9rOw==" },
                    { "LD002", "AQAAAAEAACcQAAAAEJJpVKz8rLZPP4/VBkElku53BlVocJ17FCera7ZAn9WGJ6P5QkGU5rQ3ZfKnk6WI7w==" },
                    { "TV001", "AQAAAAEAACcQAAAAECwd9kGUu30kVdjQOkpHTvkDN75oIftaTA6hJAdFRABcLcDUrta/pIQYBMeprvaH6A==" },
                    { "LD001", "AQAAAAEAACcQAAAAEDqaOmu7yv6rh0lKXQiBnccd8oMUiHKqNxfOOLqzCOywAV1+1d980MzWFOr6qRJ2Fw==" },
                    { "TV011", "AQAAAAEAACcQAAAAEJfJoxHSTLn8fdWmfQBxmpps6FhCnFovz8GxvcKdohx1ETWmyt3IKAKOMykGsv53bw==" },
                    { "TV010", "AQAAAAEAACcQAAAAENN7hjHrk/U+ImsjEZCjXwttqVvSqs+o0nCDVLmCyUbnTmdbO4TsldLgw3k6iAT+4g==" },
                    { "TV009", "AQAAAAEAACcQAAAAEIoodFYIohNCDbmxYYYkNvN/Iw7MdODzUEAjJNPSrA4zca3i7Bj5SezdSC3R4gO2XA==" },
                    { "TV008", "AQAAAAEAACcQAAAAEK3k+ziA2vwDuijG6yk+Ibe1VvZPt0bgsop7CsG0BSfQB1whjrKHamQI/bKGrbZ8+w==" },
                    { "TV007", "AQAAAAEAACcQAAAAEBp+JSU9Ven9Crhg5QtTGmm4AkYZgCvrrhntpMJwPGvH3iG/yOyVBiM4qMyyKLauIw==" },
                    { "TV006", "AQAAAAEAACcQAAAAEBdT4r4YPpUzt20Ct1qJWIsXILUQCqM4+K/On840tKYQAW7WgjiDF7DRU2fd5syflw==" },
                    { "TV005", "AQAAAAEAACcQAAAAEGSMFKGaFlxrvJajWZj30exQbpFVXeFGrVf32X+Hg2AYDNoGtkZTUBPYWhM0H0rcLQ==" },
                    { "TV004", "AQAAAAEAACcQAAAAEJxnqS+hIjfSzCyKVLLpxP00lq9dPSfHpElcKJMyxElKLFSSK4fbFO0HWeor/JAkJw==" },
                    { "TV003", "AQAAAAEAACcQAAAAEIDrTIgGEYX26Rw3hqAndm5cXpGC/C7vKYgl9p7XVs4lsjHVpwppzdxKJfMf6wCKvQ==" },
                    { "TV012", "AQAAAAEAACcQAAAAEFEUwYlBMW+xxLk+KaAR5edVvWX8HPOKTwJgNWU9iAF7dxlbGAGGxP6vOp02dmf13Q==" },
                    { "NN001", "AQAAAAEAACcQAAAAEN3ex0UIL7+B0j4ItNActwrqegPAEQ8WQUHK51nxYra7+EwvobhYWV4J3Shp11RnGA==" },
                    { "TT012", "AQAAAAEAACcQAAAAEABLRLm5DamJ1xfdWZOpdeH3jNFtVt6JF/bqL3mc2kFdK7ccLu5i86yfORnPm4nCKg==" },
                    { "TT011", "AQAAAAEAACcQAAAAENJasXzXpt9AcSnxeOwHrtADax76D4LYZA2BHYKVzSmybJ0IYwDA5pmBhrpqU8xCiA==" },
                    { "IT009", "AQAAAAEAACcQAAAAENtFLV38gZxDejF4rJ5tn/r+vXTSaSKNPmtlcaXs5fTe1SfeT7PQmfgU7pJFHx/m3g==" },
                    { "IT008", "AQAAAAEAACcQAAAAEGWi9/WvPhoXvFeEkU5cJKE5WgMQtBz+Ek3RWoS1meUlNtPQdENbIwpzUGNrAm76PQ==" },
                    { "IT007", "AQAAAAEAACcQAAAAEG+/dTjqQUQbAAqhfD4QWG6RBkdvXJz2ctZpHlrfjBI+Zbug/5ZpLerpVZUQzJ6J2w==" },
                    { "IT006", "AQAAAAEAACcQAAAAELT7v2R1G+efidioMA2jIjE4vBTldLIHO88TUON8mhIM+pGNOm0jQ7DFSN5gT6rnqw==" },
                    { "IT005", "AQAAAAEAACcQAAAAEB8oAP0L6HxxOP2ag58sFkWt8/iuCPago1mhRq2rDw8T3sGVGUdtuAV1WYzxPc9IXA==" },
                    { "IT004", "AQAAAAEAACcQAAAAEErG2LEE8mdtPb6zTFdkAtbdSaqM0uDc2m2oi9EmN5G04+PZ0OKiYKbeKShkbnDhGQ==" },
                    { "IT003", "AQAAAAEAACcQAAAAEOIq9CzvHs1/1KxzWLeLG/pcnyRlYR3vmj068rPyDlcHVU+OEI6LdNr9+ZY6G9Wo2w==" },
                    { "IT002", "AQAAAAEAACcQAAAAEPj1GovgG/VAHNpAZBjJZO9u+dbsiW7HQ6hQf1GRDHGD6fSDwv1RwsHrBPu6hXHqSQ==" },
                    { "IT001", "AQAAAAEAACcQAAAAEBuRIqk5j+M0iYb7KjE+YmIqvji8DdqKfU1AZ5Gh5nqzxtMSigVldl/9GEl02A3JdQ==" },
                    { "IT010", "AQAAAAEAACcQAAAAEJr9nj4LPVxM/JXrD7kWA3PoBvCFoeIcpZrLKT/PNk4C/5LGKdDY4yZPrB2ZuC4CnA==" },
                    { "KT012", "AQAAAAEAACcQAAAAECBnx8zsP3QzaHVHpsyuUYa0MIPUJHEGmfrMyJey6vCKZQoBODF1YbQi03D6waF22w==" },
                    { "KT010", "AQAAAAEAACcQAAAAEOwpmjUy4CDjV87iag49A33YqM+9Mt4H0IwRmk8o3hIL1n0pDIxU4IZ51gkSDft5Mw==" },
                    { "KT009", "AQAAAAEAACcQAAAAEN5rSvhF89vUfHooNkbeHtZ8X0e8tle3w2o44AHj2nXiaoV0Vb4u6MrqyPBQr3PYgA==" },
                    { "KT008", "AQAAAAEAACcQAAAAEGfG1vClIcj/qheL23R1Cl+AyI1yvfU31aV2nF7ObRsv++fokEbrI5RCsdDq09UH2Q==" },
                    { "KT007", "AQAAAAEAACcQAAAAEKS6ZpH1797quDH+eF4HwLmhPYKsubKvRwFZgyDFA3XSZ28HXvrZOORGvynkgcCiWw==" },
                    { "KT006", "AQAAAAEAACcQAAAAENLtB4XDYJA4QynPCEB3c1scqoAjePvpz3qvMo9XkYja3AOD3ardhofp/iHmZsQQ3A==" },
                    { "KT005", "AQAAAAEAACcQAAAAEFzJoJ3fzgwlhjml52eAxd2ZgPj8w2vqoG1fXd3DC1jsLuaKVc2Vsgfy8tgGG1b+uA==" },
                    { "KT004", "AQAAAAEAACcQAAAAEAnxgRYkCmMQn1qW+1CXqe6zL4jI3KUcGbC1i3Ay85LK9WGYzwkoiwxodJ3W/IWrhw==" },
                    { "KT003", "AQAAAAEAACcQAAAAEOadH+Y5HQ7XMJZUdzG4lefa/GQk3iKnx/wFzolxrUYsALr49T7jpdeRmsHBhwXBlg==" },
                    { "KT002", "AQAAAAEAACcQAAAAEKzRDC+mRme/x3WqjCMQAVEa7DqjzIuCVIbaaheRhCDRyd8Vf1W0WbSVmw4ZY1s9rg==" },
                    { "KT011", "AQAAAAEAACcQAAAAEMnOHBVuh3LlLo6aEQzJJjsynak2eUB/XCvsQI0ZhzoRy8rrhoSiW7IlOcjdLbH12A==" },
                    { "IT011", "AQAAAAEAACcQAAAAEEvt+f0PuV7POTLVEYVEgToaDiOjf71AVlEaR7md0/ofeM2Nwiq1Dc5HomoeBzS+Lg==" },
                    { "IT012", "AQAAAAEAACcQAAAAEDwIGRX0lolcpRojrcQH76zjS6CytvN3rkvwYcIA2FnKY3nPr2w4wQ3FVN80WLDh2Q==" },
                    { "DT001", "AQAAAAEAACcQAAAAEIg2o6rsySss0EWrRx0UMDmvdHtaqODRIE7ZsCcmUcFDV1OLIzZgheZPDMoe1a6aNg==" },
                    { "TT010", "AQAAAAEAACcQAAAAEGVDMt+1L/sM05Z9+ei6lQKTYnH8At1BPDRIQlAnIQgjMa6UiV2qBXbleD+5yz2WZg==" },
                    { "TT009", "AQAAAAEAACcQAAAAEMalsoo39w/aLc0umKe+8sC2G6IsiT7laTqk4b7ef/GC1soltW+CmsithEdSt+cfJw==" },
                    { "TT008", "AQAAAAEAACcQAAAAEJwU0PF+5scWs215AYjBwjwgMvcveI/csiUhmYGKDcAHK3iMQE8kcxp++8eDRbdKSA==" },
                    { "TT007", "AQAAAAEAACcQAAAAEMCem/BmyBHnDodSTUAVrXnx+eBkHhQ2RNy0XkeopnWd391yMVCJ+h6Z0kH/G7qL5g==" },
                    { "TT006", "AQAAAAEAACcQAAAAEJxVSkIDMviAUlLGhzb15oYOAMaLu5TcsTiHGYZRwQq5qCv0le1jIyzlQQaLttQjeQ==" },
                    { "TT005", "AQAAAAEAACcQAAAAEFTUlx1C7siBd3KPJcEOIKBIDBjecJsoAqsqAQzsjhuUKSNDBouzRimH/JoY5sYEIQ==" },
                    { "TT004", "AQAAAAEAACcQAAAAEJTFP4YUKAwiF2imKUWu+yf5Zi1Utz4AE8MGjIWesmLk8LFCnNTd3ldHt49rHyK1iw==" },
                    { "TT003", "AQAAAAEAACcQAAAAEAZegJ/5f38WxZ8qU3IT1QbSHPRA2Xmg8w70wsIVEu9PuB8KcQZH3Sqm9V97bIksig==" },
                    { "TT002", "AQAAAAEAACcQAAAAEHCwrVmwQ3GXT2ZLLd1aT8NAEIukxn01Pnmyyun+JRtF9tlSxXvfVxdpTfo108fldA==" },
                    { "TT001", "AQAAAAEAACcQAAAAEJyr6eo1Pf1p3Cu6FF//KuOnoa0MLZPqgHoBzj8pbRXFhz4TpIHk4NcGMWARCPSeCQ==" },
                    { "DT012", "AQAAAAEAACcQAAAAEA7tBaSi0c4KlbncRSDphP7hp836t1n+4CBitaZt6z2ucteb9HpDISJqc7bjViEahg==" },
                    { "DT011", "AQAAAAEAACcQAAAAEBr5+RJY9tY+Jwiuna6JdENSd/B3pRNRnDMliePwbGwMn6uiGwJg9ZNLttJvelTC1g==" },
                    { "DT010", "AQAAAAEAACcQAAAAELH6Z38XSFRn6T29qC74+ubk6f2/WiO+w3ZHmEkhB+ZNdFBY0lB+opyVgMCwkEb0JQ==" },
                    { "DT009", "AQAAAAEAACcQAAAAEFQVUVgptwW52ZV3fkr7Rn0GBnCQ01T0FCOUoEJuyXkXt/84cr7UUHvOPxfT2NUHbQ==" },
                    { "DT008", "AQAAAAEAACcQAAAAEGfC+da6NSpiq9aPKbU6ZQz5IWgxmfibtYPKEbBKvlto65qM1l+nYdBCi4rUnWp2HQ==" },
                    { "DT007", "AQAAAAEAACcQAAAAEFBx9cgn93s44Zgj3aVBrJ16uZxf1vbNQRvmUeif0Xu3fwvE+eoTJNjE/EKdhn8t7g==" },
                    { "DT006", "AQAAAAEAACcQAAAAEGk8WVIQKUpKrs6NKtb3AoP/dxBV6FoMZt6KlBdTDWbEwh64BOLVuAia6Ah6YSg7Ww==" },
                    { "DT005", "AQAAAAEAACcQAAAAEDF3mCV29wXeHTuHbJtJTK5dzydX0CI8lQh5f0WI359AvB6EqTGPGfsG+UcEn24J6w==" },
                    { "DT004", "AQAAAAEAACcQAAAAEEBGfQPRBWSko5N+E2yvUDaFX5wlN39GB+bVj9ThoqkWJ8BN/Rzyq0cUwvcWukxAfg==" },
                    { "DT003", "AQAAAAEAACcQAAAAEKoIOayEw46m35MgrvtoqHITUYkBbImel9GZMQguA8siaUCvEOz2+TxSN2ZSEEAPCQ==" },
                    { "DT002", "AQAAAAEAACcQAAAAEHMsklq2BObr1+3afgbub0VcjYYWZn6Ct5VniHPl7jDU0Fy//eU4CQ89UbtHy8+blg==" },
                    { "LD011", "AQAAAAEAACcQAAAAENsvfc+URjNfn2HArYfLIc3Dny/bmVgjBY3sY5/Nyf+PlKo5e1l/VTscZ2WW2gW6Aw==" },
                    { "LD012", "AQAAAAEAACcQAAAAEDyrZzIuxDnXU7X3ofyZZgBMnS0gwAF0MEgr524bGVIyywZK7SKo0bVzN4zYlgLTsw==" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "MaNhanVien" },
                values: new object[,]
                {
                    { "RL02", "IT001" },
                    { "RL02", "CT012" },
                    { "RL02", "CT011" },
                    { "RL03", "CT010" },
                    { "RL02", "CT009" },
                    { "RL02", "CT008" },
                    { "RL02", "CT007" },
                    { "RL02", "CT006" },
                    { "RL02", "CT005" },
                    { "RL02", "CT004" },
                    { "RL02", "CT003" },
                    { "RL02", "CT002" },
                    { "RL02", "CT001" },
                    { "RL02", "NN012" },
                    { "RL02", "NN011" },
                    { "RL03", "NN010" },
                    { "RL02", "NN009" },
                    { "RL02", "NN008" },
                    { "RL04", "TV001" },
                    { "RL02", "NN007" },
                    { "RL04", "TV002" },
                    { "RL04", "TV004" },
                    { "RL05", "LD010" },
                    { "RL05", "LD009" },
                    { "RL05", "LD008" },
                    { "RL05", "LD007" },
                    { "RL05", "LD006" },
                    { "RL05", "LD005" },
                    { "RL05", "LD004" },
                    { "RL05", "LD003" },
                    { "RL05", "LD002" },
                    { "RL05", "LD001" },
                    { "RL04", "TV012" },
                    { "RL02", "TV011" },
                    { "RL04", "TV009" },
                    { "RL04", "TV008" },
                    { "RL04", "TV007" },
                    { "RL04", "TV006" },
                    { "RL04", "TV005" },
                    { "RL04", "TV003" },
                    { "RL05", "LD011" },
                    { "RL02", "NN006" },
                    { "RL02", "NN004" },
                    { "RL02", "DT006" },
                    { "RL02", "DT005" },
                    { "RL02", "DT004" },
                    { "RL02", "DT003" },
                    { "RL02", "DT002" },
                    { "RL02", "DT001" },
                    { "RL02", "IT012" },
                    { "RL02", "IT011" },
                    { "RL03", "IT010" },
                    { "RL02", "IT009" },
                    { "RL02", "IT008" },
                    { "RL02", "IT007" },
                    { "RL02", "IT006" },
                    { "RL02", "IT005" },
                    { "RL02", "IT004" },
                    { "RL02", "IT003" },
                    { "RL02", "IT002" },
                    { "RL02", "DT007" },
                    { "RL02", "NN005" },
                    { "RL02", "DT008" },
                    { "RL03", "DT010" },
                    { "RL02", "NN003" },
                    { "RL02", "NN002" },
                    { "RL02", "NN001" },
                    { "RL02", "TT012" },
                    { "RL02", "TT011" },
                    { "RL03", "TT010" },
                    { "RL02", "TT009" },
                    { "RL02", "TT008" },
                    { "RL02", "TT007" },
                    { "RL02", "TT006" },
                    { "RL02", "TT005" },
                    { "RL02", "TT004" },
                    { "RL02", "TT003" },
                    { "RL02", "TT002" },
                    { "RL02", "TT001" },
                    { "RL02", "DT012" },
                    { "RL02", "DT011" },
                    { "RL02", "DT009" },
                    { "RL05", "LD012" }
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
                name: "IX_DeXuatThanhToan_MaNhanVien",
                table: "DeXuatThanhToan",
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
                name: "IX_ThanhToan_MaDeXuat",
                table: "ThanhToan",
                column: "MaDeXuat",
                unique: true);

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
                name: "ThanhToan");

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
                name: "DeXuatThanhToan");

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
