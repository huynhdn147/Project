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
            var nhanvien = new NhanVienPhongBan()
            {
                MaNhanVien = request.MaNhanVien,
                TenNhanVien = request.TenNhanVien,
                MaCapBac = request.MaCapBac,
                MaPhongBan = request.MaPhongBan


            };
            _context.NhanVienPhongs.Add(nhanvien);
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
                        select new { p, cp, cpp };
                        
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien=x.p.MaNhanVien,
                TenNhanVien=x.p.TenNhanVien,
                TenCapBac=x.cpp.TenCapBac
               ,TenPhongBan=x.cp.TenPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVienViewModel>> GetAllByChucVuID(string MaChucVu)
        {

            var query = from p in _context.NhanVienPhongs
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac

                        where MaChucVu == MaChucVu
                        select new { p, cp, cpp };
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.p.MaNhanVien,
                TenNhanVien = x.p.TenNhanVien,
                TenCapBac = x.cpp.TenCapBac,
                TenPhongBan = x.cp.TenPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<List<NhanVienViewModel>> GetAllByPhongBanID(string MaPhongBan)
        {
            var query = from p in _context.NhanVienPhongs
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac
                        where p.MaPhongBan == MaPhongBan
                        select new { p, cp, cpp };
            ;
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.p.MaNhanVien,
                TenNhanVien = x.p.TenNhanVien,
                TenCapBac = x.cpp.TenCapBac,
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

        
    }
}
