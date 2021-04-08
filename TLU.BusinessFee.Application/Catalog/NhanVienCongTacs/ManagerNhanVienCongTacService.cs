using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs.DTOS;
using TLU.BusinessFee.Data.EF;
using Microsoft.EntityFrameworkCore;
using TLU.BusinessFee.Utilities.Exceptions;
using System.Linq;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using  System.Collections;

namespace TLU.BusinessFee.Application.Catalog.NhanVienCongTacs
{
    public class ManagerNhanVienCongTacService : IManagerNhanVienCongTacService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagerNhanVienCongTacService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreateNhanVienCongTacRequest Request)
        {
            var ChuyenCongTac = from CTT in _context.chuyenCongTacs
                                where CTT.MaChuyenCongTac == Request.MaChuyenCongTac
                                select CTT.TrangThai;
            if (await ChuyenCongTac.FirstOrDefaultAsync() != "Chua thuc hien")
            {
                return null;
            }
            else { 
            var NhanVienCongTac = new NhanVienCongTac()
            {
                MaChuyenCongTac = Request.MaChuyenCongTac,
                MaNhanVien = Request.MaNhanVien
                
            };
            
            _context.nhanVienCongTacs.AddAsync(NhanVienCongTac);
            await _context.SaveChangesAsync();
            return NhanVienCongTac.MaChuyenCongTac +" " +NhanVienCongTac.MaNhanVien;
            }
        }
        public async Task<List<CreateNhanVienCongTacRequest>> createListAsync(List<CreateNhanVienCongTacRequest> requests)
        {
            List<CreateNhanVienCongTacRequest> result= new List<CreateNhanVienCongTacRequest>();
            foreach (CreateNhanVienCongTacRequest item in requests)
            {
                var NhanVienCongTac = new NhanVienCongTac()
                {
                    MaChuyenCongTac = item.MaChuyenCongTac,
                    MaNhanVien = item.MaNhanVien

                };
                _context.nhanVienCongTacs.AddRangeAsync(NhanVienCongTac);
               // result = item.MaChuyenCongTac + " " + item.MaNhanVien+";";
                await _context.SaveChangesAsync();
                result.Add(item);
            }
             return result;
        }
        public async Task<int> Delete(string MaChuyenCongTac,string MaNhanVien)
        {
            var nhanVienCongTac = await _context.nhanVienCongTacs.FindAsync(MaChuyenCongTac,MaNhanVien);
            if (nhanVienCongTac == null)
                throw new TLUException("Khong co chuyen cong tac hoac nhan vien nay");
            var sttChuyenCongTac =  from CTT in _context.chuyenCongTacs
                                   join NV in _context.nhanVienCongTacs on
                                   CTT.MaChuyenCongTac equals NV.MaChuyenCongTac
                                   where CTT.MaChuyenCongTac == nhanVienCongTac.MaChuyenCongTac
                                   select CTT.TrangThai;
            if (await sttChuyenCongTac.FirstOrDefaultAsync() != "Chua thuc hien")
            {
                throw new TLUException("Chuyến công tác đã diễn ra, không thể xóa nhân viên");
            }
            _context.nhanVienCongTacs.Remove(nhanVienCongTac);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(updateNhanVienCongTacRequest request)
        {
            var NhanVienCongTac = await _context.nhanVienCongTacs.FindAsync(new { request.MaChuyenCongTac, request.MaNhanVien });

            var NhanVienCongTacdf = await _context.nhanVienCongTacs.FirstOrDefaultAsync(x => x.MaChuyenCongTac == request.MaChuyenCongTac && x.MaNhanVien==request.MaNhanVien);
            if (NhanVienCongTac == null)
                throw new TLUException("Khong co chuyen cong tac nay");
            var sttChuyenCongTac = from CTT in _context.chuyenCongTacs
                                   join NV in _context.nhanVienCongTacs on
                                   CTT.MaChuyenCongTac equals NV.MaChuyenCongTac
                                   where CTT.MaChuyenCongTac == NhanVienCongTac.MaChuyenCongTac
                                   select CTT.TrangThai;
            if (await sttChuyenCongTac.FirstOrDefaultAsync()== "Chua thuc hien")
            {
                throw new TLUException("Chuyến công tác đã diễn ra, không thể xóa nhân viên");
            }
            NhanVienCongTacdf.MaChuyenCongTac = request.MaChuyenCongTac;
            NhanVienCongTacdf.MaNhanVien = request.MaNhanVien;
            return await _context.SaveChangesAsync();
        }
        public async Task<List<string>> GetAllPhongBan()
        {

            var query = from p in _context.PhongBans select p;
            var data = await query.Select(query=>query.MaPhongBan).ToListAsync();
            return data;
        }
        public async Task<List<NhanVienViewModel>> GetAllByPhongBanID(string MaPhongBan)
        {
            var query = from p in _context.NhanVienPhongs
                        join cp in _context.PhongBans on p.MaPhongBan equals cp.MaPhongBan
                        join cpp in _context.CapBacs on p.MaCapBac equals cpp.MaCapBac
                        where p.MaPhongBan == MaPhongBan
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
        public async Task<List<NhanVienCongTacViewModel>> GetNhanVienByChuyenCongTac(string MaChuyenCongTac)
        {
            var query = from CTT in _context.chuyenCongTacs
                        join NV in _context.nhanVienCongTacs
                        on CTT.MaChuyenCongTac equals NV.MaChuyenCongTac
                        where CTT.MaChuyenCongTac == MaChuyenCongTac
                        select NV;
            var data = await query.Select(x => new NhanVienCongTacViewModel()
            {
                MaChuyenCongTac = x.MaChuyenCongTac,
                MaNhanVien = x.MaNhanVien
            }
            ).ToListAsync();
            return data;
        }
        public async Task<List<NhanVienCongTacViewModel>> GetChuyenCongTacByNhanVien(string MaNhanVien)
        {
            var query = from CTT in _context.chuyenCongTacs
                        join NV in _context.nhanVienCongTacs
                        on CTT.MaChuyenCongTac equals NV.MaChuyenCongTac
                        where NV.MaNhanVien == MaNhanVien
                        select NV;
            var data = await query.Select(x => new NhanVienCongTacViewModel()
            {
                MaChuyenCongTac = x.MaChuyenCongTac,
                MaNhanVien = x.MaNhanVien
            }
            ).ToListAsync();
            return data;
        }

        public async Task<List<NhanVienCongTacViewName>> GetAll()
        {
            var query = from CTT in _context.chuyenCongTacs
                        join NV in _context.nhanVienCongTacs
                        on CTT.MaChuyenCongTac equals NV.MaChuyenCongTac
                        join NVV in _context.NhanVienPhongs on NV.MaNhanVien equals NVV.MaNhanVien
                        orderby CTT.MaChuyenCongTac ascending
                        select new {
                            CTT.MaChuyenCongTac,
                            CTT.TenChuyenCongTac,
                            NVV.TenNhanVien,
                            NVV.MaCapBac,
                            NVV.MaNhanVien,
                            CTT.TrangThai
                        };
            var data = await query.Select(x => new NhanVienCongTacViewName()
            {
                TenChuyenCongTac = x.TenChuyenCongTac,
                TenNhanVien = x.TenNhanVien,
                MaChuyenCongTac=x.MaChuyenCongTac
                ,MaNhanVien=x.MaNhanVien,
                MaCapBac=x.MaCapBac,
                TrangThai=x.TrangThai
            }
            ).ToListAsync();
            return data;
        }
    }
}
