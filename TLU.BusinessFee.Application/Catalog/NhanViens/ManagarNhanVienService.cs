using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TLU.BusinessFee.Application.Catalog.NhanViens
{
    public class ManagarNhanVienService : IManagerNhanVienService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagarNhanVienService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }

        public async Task<string> Create(CreateNhanVienRequest request)
        {
            //lay ra phong ban
            var NhanVienTrongPhongBan = from NV in _context.NhanVienPhongs
                                        where NV.MaPhongBan == request.MaPhongBan
                                        select NV;
            string SoLuongNhanVien = NhanVienTrongPhongBan.Count().ToString();
            //dem so nhan vien trong phong ban
            //su dung thuat toan
            do
            {
                SoLuongNhanVien = (Convert.ToInt32(SoLuongNhanVien) + 1).ToString();

            }
            while (_context.CapBacs.Find( request.MaPhongBan+ SoLuongNhanVien) != null);
            //gan vao` tng phong ban
            var nhanvien = new NhanVienPhongBan()
            {
                MaNhanVien = request.MaPhongBan + SoLuongNhanVien,
                TenNhanVien = request.TenNhanVien,

                MaCapBac = request.MaCapBac,
                MaPhongBan = request.MaPhongBan
            };
            

            //await _context.SaveChangesAsync();
            var hasher = new PasswordHasher<User>();
            var User = new User()
            {
                MaNhanVien = nhanvien.MaNhanVien,
                PasswordHash = hasher.HashPassword(null, request.PassWord)
            };
            
            var UserRole = new UserRole()
            {
                MaNhanVien = User.MaNhanVien,
                RoleId = request.Roleid
            };
            if(UserRole.RoleId=="RL05")
            {
                nhanvien.MaPhongBan = "LD";
                nhanvien.MaNhanVien = nhanvien.MaPhongBan + SoLuongNhanVien;
            }    
            _context.User.Add(User);
            _context.NhanVienPhongs.Add(nhanvien);
            _context.UserRole.Add(UserRole);
            await _context.SaveChangesAsync();
            return nhanvien.MaNhanVien;
        }
        public Task Create(List<NhanVienPhongBan> nhanvien)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(string MaNhanVien)
        {
            var nhanvien = await _context.NhanVienPhongs.FindAsync(MaNhanVien);
            if (nhanvien == null) throw new TLUException("Khong co nhan vien");
            _context.NhanVienPhongs.Remove(nhanvien);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<NhanVienViewModel>> GetAll()
        {
            var query = from p in _context.NhanVienPhongs 
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan 
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac
                        join us in _context.User on p.MaNhanVien equals us.MaNhanVien
                        join roleus in _context.UserRole on us.MaNhanVien equals roleus.MaNhanVien
                        join role in _context.Roles on roleus.RoleId equals role.Id
                        
                        select new { p, cp, cpp,role};

            //var query2= from US in _context.User join 
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien=x.p.MaNhanVien,
                TenNhanVien=x.p.TenNhanVien,
                TenCapBac=x.cpp.TenCapBac,
                TenChucVu=x.role.Name
               ,
                TenPhongBan=x.cp.TenPhongBan
            }).ToListAsync();
            return data;
         }
        //public async Task<ChucVuViewModel> GetChucVu()
        //{
        //    var query = from R in _context.Roles
        //                select R;
        //    var chucvu = await query.Select(x => ChucVuViewModel(){

        //    });

        //}

        public async Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVienViewModel>> GetAllByChucVuID(string MaCapBac)
        {

            var query = from p in _context.NhanVienPhongs
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac
                        join us in _context.User on p.MaNhanVien equals us.MaNhanVien
                        join roleus in _context.UserRole on us.MaNhanVien equals roleus.MaNhanVien
                        join role in _context.Roles on roleus.RoleId equals role.Id

                        where p.MaCapBac == MaCapBac
                        select new { p, cp, cpp, role };
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.p.MaNhanVien,
                TenNhanVien = x.p.TenNhanVien,
                TenCapBac = x.cpp.TenCapBac,
                TenChucVu = x.role.Name
               ,
                TenPhongBan = x.cp.TenPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<List<NhanVienViewModel>> GetAllByPhongBanID(string MaPhongBan)
        {
            var query = from p in _context.NhanVienPhongs
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac
                        join us in _context.User on p.MaNhanVien equals us.MaNhanVien
                        join roleus in _context.UserRole on us.MaNhanVien equals roleus.MaNhanVien
                        join role in _context.Roles on roleus.RoleId equals role.Id
                        where p.MaPhongBan == MaPhongBan
                        select new { p, cp, cpp,role };
            ;
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.p.MaNhanVien,
                TenNhanVien = x.p.TenNhanVien,
                TenCapBac = x.cpp.TenCapBac,
                TenChucVu = x.role.Name
               ,
                TenPhongBan = x.cp.TenPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<int> Update(UpdateNhanVienRequest request)
        {
            var nhanvien = await _context.NhanVienPhongs.FindAsync(request.MaNhanVien);
            var nhanviendf = await _context.NhanVienPhongs.FirstOrDefaultAsync(x => x.MaNhanVien == request.MaNhanVien);
            if (nhanvien == null) throw new TLUException("khong tim thay nhan vien");

            nhanviendf.MaNhanVien = request.MaNhanVien;
            nhanviendf.TenNhanVien = request.TenNhanVien;
            nhanviendf.MaPhongBan = request.MaPhongBan;
            nhanviendf.MaCapBac = request.MaCapBac;
            return await _context.SaveChangesAsync();
        }

        public async Task<NhanVienViewModel> GetByID(string MaNhanVien)
        {
            var query = await _context.NhanVienPhongs.FindAsync(MaNhanVien);
            var nhanvien =  new NhanVienViewModel()
            {
                MaNhanVien = query.MaNhanVien,
                TenNhanVien = query.TenNhanVien,
                //MaChucVu = query.MaCapBac,
                //MaPhongBan = query.MaPhongBan
            };
            return nhanvien;
        }

        public Task<List<NhanVienViewModel>> GetAllByPhongBan()
        {
            throw new NotImplementedException();
        }
    }
}
