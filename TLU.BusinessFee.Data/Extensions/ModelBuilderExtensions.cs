using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;
using System.Linq;

namespace TLU.BusinessFee.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AppConfig>().HasData(
            //    new AppConfig() { Key = "home titleee", Value = "this is home page" }
            //);
            modelBuilder.Entity<PhongBan>().HasData(
                new PhongBan() { MaPhongBan = "a0001", TenPhongBan = "Phong kinh te" },
                new PhongBan() { MaPhongBan = "a0002", TenPhongBan = "Phong CNTT" },
                new PhongBan() { MaPhongBan = "a0003", TenPhongBan = "Phong dao tao" },
                new PhongBan() { MaPhongBan = "a0004", TenPhongBan = "Phong truyen thong" },
                new PhongBan() { MaPhongBan = "a0005", TenPhongBan = "Phong Ngon Ngu" },
                new PhongBan() { MaPhongBan = "a0006", TenPhongBan = "Phong ctsv" }
                );
            modelBuilder.Entity<CapBac>().HasData(
                new CapBac() { MaCapBac = "c1", TenCapBac = "CAP1" },
                new CapBac() { MaCapBac = "c2", TenCapBac = "CAP2" },
                new CapBac() { MaCapBac = "c3", TenCapBac = "CAP3" },
                new CapBac() { MaCapBac = "c4", TenCapBac = "CAP4" },
                new CapBac() { MaCapBac = "c5", TenCapBac = "CAP5" },
                new CapBac() { MaCapBac = "c6", TenCapBac = "CAP6" }
                );
            modelBuilder.Entity<NhanVienPhongBan>().HasData(
                new NhanVienPhongBan() { MaNhanVien = "IT002", TenNhanVien = "Mai Thuy Nga", MaCapBac = "c3", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "IT003", TenNhanVien = "Vu Duc Thi", MaCapBac = "c1", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "IT001", TenNhanVien = "Cao Kim Anh", MaCapBac = "c2", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "IT004", TenNhanVien = "Pham Phuong Thanh", MaCapBac = "c4", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "IT006", TenNhanVien = "Nguyen Duc Dan", MaCapBac = "c5", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "IT005", TenNhanVien = "Tran Thi Hue", MaCapBac = "c6", MaPhongBan = "a0002" },
                new NhanVienPhongBan() { MaNhanVien = "KT002", TenNhanVien = "Nham Ngoc Tan", MaCapBac = "c3", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT001", TenNhanVien = "Ha Huy Khoai", MaCapBac = "c1", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT003", TenNhanVien = "Nguyen Hong Nhung", MaCapBac = "c4", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT004", TenNhanVien = "Hoang Ngoc Tung", MaCapBac = "c2", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT006", TenNhanVien = "Nguyen Lam Tung", MaCapBac = "c5", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT005", TenNhanVien = "Nguyen Quoc Tuan", MaCapBac = "c6", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "DT001", TenNhanVien = "Nguyen Thi Hoa", MaCapBac = "c1", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "DT002", TenNhanVien = "Tran Quoc Hung", MaCapBac = "c2", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "DT003", TenNhanVien = "Nguyen Canh Toan", MaCapBac = "c3", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "DT006", TenNhanVien = "Mai Tien Dung", MaCapBac = "c4", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "DT005", TenNhanVien = "Nguyen Duc Khoa", MaCapBac = "c5", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "DT004", TenNhanVien = "Le Huyen Trang", MaCapBac = "c6", MaPhongBan = "a0003" },
                new NhanVienPhongBan() { MaNhanVien = "TT001", TenNhanVien = "Nguyen Ngoc Quang", MaCapBac = "c1", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "TT003", TenNhanVien = "Tran Huy Hoang", MaCapBac = "c2", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "TT004", TenNhanVien = "Vu Tuan Tu", MaCapBac = "c5", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "TT006", TenNhanVien = "Nguyen Thi Nga", MaCapBac = "c3", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "TT002", TenNhanVien = "Tran Thuy Duong", MaCapBac = "c4", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "TT005", TenNhanVien = "Nguyen Van Thieu", MaCapBac = "c6", MaPhongBan = "a0004" },
                new NhanVienPhongBan() { MaNhanVien = "NN001", TenNhanVien = "Pham Hai Yen", MaCapBac = "c2", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "NN006", TenNhanVien = "Bui Sy Thang", MaCapBac = "c3", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "NN002", TenNhanVien = "Tran Hoang Duong", MaCapBac = "c6", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "NN004", TenNhanVien = "Mai Xuan The", MaCapBac = "c1", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "NN003", TenNhanVien = "Mai Lan", MaCapBac = "c4", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "NN005", TenNhanVien = "Nguyen Bich Tram", MaCapBac = "c5", MaPhongBan = "a0005" },
                new NhanVienPhongBan() { MaNhanVien = "CT001", TenNhanVien = "Le Thi Quy", MaCapBac = "c2", MaPhongBan = "a0006" },
                new NhanVienPhongBan() { MaNhanVien = "CT003", TenNhanVien = "Ho Xuan Ngoc", MaCapBac = "c1", MaPhongBan = "a0006" },
                new NhanVienPhongBan() { MaNhanVien = "CT005", TenNhanVien = "Hoang Ngoc Ha", MaCapBac = "c5", MaPhongBan = "a0006" },
                new NhanVienPhongBan() { MaNhanVien = "CT002", TenNhanVien = "Nguyen Van Lich", MaCapBac = "c6", MaPhongBan = "a0006" },
                new NhanVienPhongBan() { MaNhanVien = "CT004", TenNhanVien = "Nguyen Thi Hai", MaCapBac = "c3", MaPhongBan = "a0006" },
                new NhanVienPhongBan() { MaNhanVien = "CT006", TenNhanVien = "Dang canh Khanh", MaCapBac = "c4", MaPhongBan = "a0006" }
                );
            modelBuilder.Entity<ChiPhi>().HasData(
                new ChiPhi() { MaChiPhi = "CP1", TenChiPhi = "Khach San",MoTa="Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP2", TenChiPhi = "Ve may bay", MoTa = "Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP3", TenChiPhi = "Luu tru ", MoTa = "Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP4", TenChiPhi = "Ve tau,xe", MoTa = "Tien ở khách sạn" }
                );
            modelBuilder.Entity<ChiPhiChucVu>().HasData(
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c1", SoTienDinhMuc = "200000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c2", SoTienDinhMuc = "250000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c3", SoTienDinhMuc = "300000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c4", SoTienDinhMuc = "350000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c5", SoTienDinhMuc = "400000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "c6", SoTienDinhMuc = "500000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c1", SoTienDinhMuc = "1500000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c2", SoTienDinhMuc = "1700000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c3", SoTienDinhMuc = "2000000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c4", SoTienDinhMuc = "2300000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c5", SoTienDinhMuc = "2600000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "c6", SoTienDinhMuc = "3000000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c1", SoTienDinhMuc = "150000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c2", SoTienDinhMuc = "200000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c3", SoTienDinhMuc = "250000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c4", SoTienDinhMuc = "300000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c5", SoTienDinhMuc = "350000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "c6", SoTienDinhMuc = "400000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c1", SoTienDinhMuc = "100000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c2", SoTienDinhMuc = "120000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c3", SoTienDinhMuc = "150000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c4", SoTienDinhMuc = "200000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c5", SoTienDinhMuc = "250000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "c6", SoTienDinhMuc = "300000", DonVi = "luot" }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = "RL01", Name = "admin", Description = "Quản trị hệ thống" },
                new Role {Id="RL02", Name="Nhân viên",Description="nhân viên trong một phòng ban" },
                new Role {Id = "RL03", Name = "Trưởng bộ phận", Description = "trưởng bộ phận của một phòng ban" },
                new Role { Id = "RL04", Name = "Phòng kế toán", Description = "nhân viên phòng kế toán" },
                new Role { Id = "RL05", Name = "Lãnh đạo nhà trường", Description = "lãnh đạo nhà trường" }

            );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null,"123") },
                new User { MaNhanVien = "IT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT006", PasswordHash = hasher.HashPassword(null, "123") }
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                //new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") }
                );
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole{ 
                 RoleId= "RL01"
                ,MaNhanVien= "IT001" },
                new UserRole
                {
                    RoleId = "RL01",
                    MaNhanVien = "KT001"
                },
                new UserRole
                {
                    RoleId = "RL01",
                    MaNhanVien = "DT001"
                },
                new UserRole
                {
                    RoleId = "RL01",
                    MaNhanVien = "TT001"
                },
                new UserRole
                {
                    RoleId = "RL01",
                    MaNhanVien = "NN001"
                },
                new UserRole
                {
                    RoleId = "RL01",
                    MaNhanVien = "CT001"
                }
                );
               
        
        
        }
    }
}
