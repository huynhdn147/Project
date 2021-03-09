using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLU.BusinessFee.Data.Migrations
{
    public partial class updateD_chiPhiCongTac : Migration
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
                    TenChiPhi = table.Column<string>(maxLength: 25, nullable: false)
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
                    NgayBatDau = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)),
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
                    NgayThanhLap = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 7, 18, 17, 44, 273, DateTimeKind.Local).AddTicks(4893))
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
                name: "NhanVienCongTac",
                columns: table => new
                {
                    MaChuyenCongTac = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    MaNhanVien = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    
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
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[] { "home title", "this is home page" });

            migrationBuilder.InsertData(
                table: "CapBac",
                columns: new[] { "MaCapBac", "MoTa", "TenCapBac" },
                values: new object[,]
                {
                    { "QL", null, "Quan ly" },
                    { "NV", null, "Nhan Vien" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "TenPhongBan" },
                values: new object[,]
                {
                    { "a0001", "Phong kinh te" },
                    { "a0002", "Phong CNTT" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { "1", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNhanVien", "MaCapBac", "MaPhongBan", "TenNhanVien" },
                values: new object[,]
                {
                    { "KT002", "NV", "a0001", "Nham Ngoc Tan" },
                    { "KT001", "QL", "a0001", "Ha Huy Khoai" },
                    { "TT002", "NV", "a0002", "Mai Thuy Nga" },
                    { "TT001", "QL", "a0002", "Cao Kim Anh" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MaNhanVien", "PasswordHash" },
                values: new object[] { "TT001", "AQAAAAEAACcQAAAAEIP7W1jWXwmIEVFZEYL2+uiHYBHUNogyGmvoL2hLcdpYnVabzaLN0YdGydE7ZuNUZw==" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "MaNhanVien" },
                values: new object[] { "1", "TT001" });

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhiCongTac_MaChuyenCongTac_MaNhanVien",
                table: "ChiPhiCongTac",
                columns: new[] { "MaChuyenCongTac", "MaNhanVien" });

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
