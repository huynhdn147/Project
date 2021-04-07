using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs.DTOS;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using System.Linq;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System;

namespace TLU.BusinessFee.Application.Catalog.ChuyenCongTacs
{
    public class ChuyenCongTacSerVice : IChuyenCongTacSerVice
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ChuyenCongTacSerVice(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreateChuyenCongTacRequest Request)
        {
            DateTime ngaytemp;
            if(Request.NgayBatDau>Request.NgayKetThuc)
            {
                ngaytemp = Request.NgayBatDau;
                Request.NgayBatDau = Request.NgayKetThuc;
                Request.NgayKetThuc = ngaytemp;

            }
            var chuyenCongTacs = from CCT in _context.chuyenCongTacs
                         select CCT;
            string SoLuongChuyenCongTac = chuyenCongTacs.Count().ToString();
            do
            {
                SoLuongChuyenCongTac = (Convert.ToInt32(SoLuongChuyenCongTac) + 1).ToString();

            }
            while (_context.chuyenCongTacs.Find("CT" + SoLuongChuyenCongTac) != null);
            var ChuyenCongTac = new ChuyenCongTac()
            {
                MaChuyenCongTac= "CT" + SoLuongChuyenCongTac,
                TenChuyenCongTac=Request.TenChuyenCongTac,
                NgayBatDau=Request.NgayBatDau,
                NgayKetThuc=Request.NgayKetThuc,
                MoTa=Request.MoTa,
                DiaDiem=Request.DiaDiem,
                TrangThai="Chua thuc hien"
            };
            _context.chuyenCongTacs.Add(ChuyenCongTac);
            await _context.SaveChangesAsync();
            return ChuyenCongTac.MaChuyenCongTac;

        }
        public async Task<int> Update(UpdateChuyenCongTacRequest request)
        {
            var ChuyenCongTac = await _context.chuyenCongTacs.FindAsync(request.MaChuyenCongTac);
            if(ChuyenCongTac.TrangThai != "Chua thuc hien")
            {
                throw new TLUException("Chuyến Công tác đã diễn ra, không thể sửa thông tin chuyến công tác");
            }
            var ChuyenCongTacdf = await _context.chuyenCongTacs.FirstOrDefaultAsync(x => x.MaChuyenCongTac == request.MaChuyenCongTac);
            if (ChuyenCongTac == null)
                throw new TLUException("Khong co chuyen cong tac nay");
            ChuyenCongTacdf.TenChuyenCongTac =request.TenChuyenCongTac;
            ChuyenCongTacdf.NgayBatDau = request.NgayBatDau;
            ChuyenCongTacdf.NgayKetThuc = request.NgayKetThuc;
            ChuyenCongTacdf.TrangThai = "Chua thuc hien";
            ChuyenCongTacdf.DiaDiem = request.DiaDiem;
            ChuyenCongTacdf.MoTa = request.MoTa;
            return await _context.SaveChangesAsync();

        }
        public async Task<int> Delete(string MaChuyenCongTac)
        {
            var ChuyenCongTac = await _context.chuyenCongTacs.FindAsync(MaChuyenCongTac);
            if (ChuyenCongTac == null)
                throw new TLUException("Khong co chuyen cong tac nay");
            if (ChuyenCongTac.TrangThai != "Chua thuc hien")
            {
                throw new TLUException("Chuyến Công tác đã diễn ra, không thể xóa thông tin chuyến công tác");
            }
            _context.chuyenCongTacs.Remove(ChuyenCongTac);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ChuyenCongTacViewModel>> GetAll()
        {
            

            var query = from CCT in _context.chuyenCongTacs
                        orderby CCT.TrangThai ascending
                        select CCT;
                        
            var checkday= await query.Select( x=> new ChuyenCongTacViewModel()
            {
                MaChuyenCongTac = x.MaChuyenCongTac,
                TenChuyenCongTac = x.TenChuyenCongTac,
                NgayBatDau = x.NgayBatDau.ToShortDateString(),
                NgayKetThuc = x.NgayKetThuc.ToShortDateString()
                ,
                DiaDiem = x.DiaDiem,
                MoTa = x.MoTa,
                TrangThai = x.TrangThai,
            }).ToListAsync();
            foreach(var item in checkday)
            {
                var ChuyenCongTacdf = await _context.chuyenCongTacs.FirstOrDefaultAsync(x => x.MaChuyenCongTac == item.MaChuyenCongTac);
                if (ChuyenCongTacdf.NgayKetThuc<DateTime.Now)
                {
                    ChuyenCongTacdf.TrangThai = "Da thuc hien";
                    await _context.SaveChangesAsync();
                }    
            };

            var query1 = from CCT in _context.chuyenCongTacs
                         orderby CCT.TrangThai ascending
                         select CCT;
            var data = await query1.Select(x => new ChuyenCongTacViewModel()
            {
                MaChuyenCongTac = x.MaChuyenCongTac,
                TenChuyenCongTac = x.TenChuyenCongTac,
                NgayBatDau = x.NgayBatDau.ToShortDateString(),
                NgayKetThuc = x.NgayKetThuc.ToShortDateString()
                ,
                DiaDiem=x.DiaDiem,
                MoTa = x.MoTa,
                TrangThai = x.TrangThai,
            }).ToListAsync();
            
            return data;
        }

        public async Task<ChuyenCongTacViewModel> GetByChuyenCongTacID(string MaChuyenCongTac)
        {
            var ChuyenCongTac = await _context.chuyenCongTacs.FindAsync(MaChuyenCongTac);
            var ChuyenCongTacViewModel = new ChuyenCongTacViewModel()
            {

                MaChuyenCongTac = ChuyenCongTac.MaChuyenCongTac,
                TenChuyenCongTac = ChuyenCongTac.TenChuyenCongTac,
                NgayBatDau = ChuyenCongTac.NgayBatDau.Date.ToShortDateString(),
                NgayKetThuc = ChuyenCongTac.NgayKetThuc.Date.ToShortDateString()
                ,
                DiaDiem=ChuyenCongTac.DiaDiem,
                MoTa = ChuyenCongTac.MoTa,
                TrangThai = ChuyenCongTac.TrangThai
            };
            return ChuyenCongTacViewModel;
        }

        public async Task<List<ChuyenCongTacViewModel>> GetAllByNhanVien(string MaNhanVien)
        {
            var query = from CCT in _context.chuyenCongTacs
                        select CCT;

            var data = await query.Select(x => new ChuyenCongTacViewModel()
            {
                MaChuyenCongTac = x.MaChuyenCongTac,
                TenChuyenCongTac = x.TenChuyenCongTac,

                NgayBatDau = x.NgayBatDau.ToShortDateString(),
                NgayKetThuc = x.NgayKetThuc.ToShortDateString()
                ,
                DiaDiem = x.DiaDiem,
                MoTa = x.MoTa,
                TrangThai = x.TrangThai,

            }).ToListAsync();

            return data;
        }

        public Task<List<ChuyenCongTacViewModel>> GetAllByTruongBoPhan(string MaPhongBan)
        {
            //var CTT= from CCT in _context.chuyenCongTacs join NVCT in _context.nhanVienCongTacs 
            //         on CCT.MaChuyenCongTac equals NVCT.MaChuyenCongTac
            //         join NV in _context.NhanVienPhongs on NVCT.MaNhanVien equals NV.MaNhanVien
            //         where MaNhanVien==NV.MaNhanVien
            //         select CCT;
            throw new NotImplementedException();
        }
    }
}
