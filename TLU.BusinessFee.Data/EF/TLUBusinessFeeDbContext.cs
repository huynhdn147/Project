
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TLU.BusinessFee.Data.Configuration;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Data.Extensions;
using System.Linq;

namespace TLU.BusinessFee.Data.EF
{
    public class TLUBusinessFeeDbContext : IdentityDbContext<User,Role,string,UserClaim,UserRole,UserLogin,RoleClaims,UserToken>
    {
        public TLUBusinessFeeDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.ApplyConfiguration(new CapBacConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienPhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new ChiPhiConfiguration());
            modelBuilder.ApplyConfiguration(new ChiPhiChucVuConfiguration());


            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimConfiguraiton());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserLoginConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserTokenConfiguratiton());
            modelBuilder.ApplyConfiguration(new ChuyenCongTacConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienCongTacConfiguration());
            modelBuilder.ApplyConfiguration(new ChiPhiCongTacConfiguration());
            modelBuilder.ApplyConfiguration(new DeXuatThanhToanConfiguration());
            modelBuilder.ApplyConfiguration(new DeXuatFileConfiguration());
            modelBuilder.ApplyConfiguration(new ThanhToanConfiguration());
            //modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim");
            //modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRole").HasKey(x=>new {x.UserId,x.RoleId });
            //modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin").HasKey(x=>x.UserId);

            //modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim");
            //modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserToken").HasKey(x => x.UserId);
            // data seeding
           modelBuilder.seed();

         //  base.OnModelCreating(modelBuilder);
        }
        public DbSet<PhongBan> PhongBans { set; get; }
        public DbSet<NhanVienPhongBan> NhanVienPhongs { set; get; }
        public DbSet<CapBac> CapBacs { set; get; }
        public DbSet<AppConfig> AppConfigs { set; get; }
        public DbSet<ChiPhi> ChiPhis { set; get; }
        public DbSet<ChiPhiChucVu> ChiPhiChucVus { set; get; }
        public DbSet<User> User { set; get; }
        public DbSet<Role> Roles { set; get; }
        //public DbSet<RoleClaims> RoleClaims { set; get; }
        //public DbSet<UserClaim> UserClaim { set; get; }
        //public DbSet<UserLogin> UserLogin { set; get; }
        public DbSet<UserRole> UserRole { set; get; }
        //public DbSet<UserToken> UserToken { set; get; }
        public DbSet<NhanVienCongTac> nhanVienCongTacs { set; get; }
        public DbSet<ChuyenCongTac> chuyenCongTacs { set; get; }
        public DbSet<DeXuatThanhToan> deXuatThanhToans { set; get; }
        public DbSet<ChiPhiCongTac> chiPhiCongTacs { set; get; }
        public DbSet<DeXuatFile> deXuatFiles { set; get; }
        public DbSet<ThanhToan> thanhToans { set; get; }

    }
}