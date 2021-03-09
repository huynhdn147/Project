using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "home title", Value = "this is home page" }
            );
            modelBuilder.Entity<PhongBan>().HasData(
                new PhongBan() { MaPhongBan = "a0001", TenPhongBan = "Phong kinh te" },
                new PhongBan() { MaPhongBan = "a0002", TenPhongBan = "Phong CNTT" }
                );
            modelBuilder.Entity<CapBac>().HasData(
                new CapBac() { MaCapBac = "QL", TenCapBac = "Quan ly" },
                new CapBac() { TenCapBac = "Nhan Vien", MaCapBac = "NV" }
                );
            modelBuilder.Entity<NhanVienPhongBan>().HasData(
                new NhanVienPhongBan() { MaNhanVien = "TT002", TenNhanVien = "Mai Thuy Nga", MaCapBac = "NV", MaPhongBan = "a0002" },

                new NhanVienPhongBan() { MaNhanVien = "TT001", TenNhanVien = "Cao Kim Anh", MaCapBac = "QL", MaPhongBan = "a0002" },

                new NhanVienPhongBan() { MaNhanVien = "KT002", TenNhanVien = "Nham Ngoc Tan", MaCapBac = "NV", MaPhongBan = "a0001" },
                new NhanVienPhongBan() { MaNhanVien = "KT001", TenNhanVien = "Ha Huy Khoai", MaCapBac = "QL", MaPhongBan = "a0001" }


                );
            
            modelBuilder.Entity<Role>().HasData(new Role {Id="1", Name="admin",Description="admin" });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
               // Id=ADMIN_ID,
                MaNhanVien= "TT001",
                PasswordHash=hasher.HashPassword(null,"123")
            }
                );
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            { 
                 RoleId= "1"
                ,MaNhanVien="TT001"
        });
               
        
        
        }
    }
}
