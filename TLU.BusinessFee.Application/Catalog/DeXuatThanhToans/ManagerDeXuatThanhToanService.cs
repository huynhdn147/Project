using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhis.DTOS;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans.DTOS;
using TLU.BusinessFee.Application.Common;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;

namespace TLU.BusinessFee.Application.Catalog.DeXuatThanhToans
{
    public  class ManagerDeXuatThanhToanService : IManagerDeXuatThanhToanService
    {
        private readonly TLUBusinessFeeDbContext _context;
        private readonly IStorageService _storageService;
        public ManagerDeXuatThanhToanService(TLUBusinessFeeDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        
        //public Task<string> CreateDeXuat(CreateDeXuatRequest request)
        //{
            
        //}

        public async Task<string> CreateDeXuat(CreateDeXuatRequest request)
        {
            var SoLuongNhanVien = from NV in _context.nhanVienCongTacs
                                  where NV.MaChuyenCongTac == request.MaChuyenCongTac
                                  select NV.MaNhanVien;
            var SoluongHoaDon = from HD in _context.thanhToans
                                select HD.MaHoaDon;
            var SoDeXuat= from HD in _context.deXuatThanhToans
                              select HD.MaDeXuat;
            var chuyenCongTac = await _context.chuyenCongTacs.FindAsync(request.MaChuyenCongTac);
            var checkCCT = from DX in _context.deXuatThanhToans
                           select DX;
            foreach(var item in checkCCT)
            {
                if(item.MaChuyenCongTac==request.MaChuyenCongTac)
                {
                    return null;
                }
            }
            if (chuyenCongTac.TrangThai == "Chua thuc hien")
            {
                throw new TLUException("Chuyến Công tác chua xong  không thể de xuat thanh toan");
            }

            string soLuongDeXuat= SoDeXuat.Count().ToString();
            do
            {
                soLuongDeXuat = (Convert.ToInt32(soLuongDeXuat) + 1).ToString();

            }
            while (_context.deXuatThanhToans.Find("DX" + soLuongDeXuat) != null);
            var DeXuat = new DeXuatThanhToan()
            {
                MaDeXuat = "DX" + soLuongDeXuat,
                MaChuyenCongTac = request.MaChuyenCongTac,
                SoNhanVien = SoLuongNhanVien.Count(),
                TinhTrang = "Chua xet duyet",
                MaNhanVien=request.NhanVienDeXuat,
                TongTien=request.TongTien,
                ThoiGianDeXuat=DateTime.Now
            };
            //var ChuyenCongTacdf = await _context.chuyenCongTacs.FirstOrDefaultAsync
            //    (x => x.MaChuyenCongTac == request.MaChuyenCongTac);
            //ChuyenCongTacdf.TrangThai = "Da thuc hien";
            string soLuongHoaDon = SoluongHoaDon.Count().ToString();
            do
            {
                soLuongHoaDon = (Convert.ToInt32(soLuongHoaDon) + 1).ToString();

            }
            while (_context.deXuatThanhToans.Find("HD" + soLuongHoaDon) != null);
             var ThanhToan = new ThanhToan()
            {
                MaHoaDon = "HD" + soLuongHoaDon,
                MaDeXuat=DeXuat.MaDeXuat,
                ThoiGianDeXuat=DeXuat.ThoiGianDeXuat,
                TinhTrang= "Chua xet duyet",
                TongChiPhi=request.TongTien
            };
            //if (FileHoaDon != null)
            //{
            //    DeXuat.deXuatFiles = new List<DeXuatFile>()
            //    {
            //        new DeXuatFile()
            //        {
            //            FilePath= await this.SaveFile(FileHoaDon)

            //        }
            //    };
            //}
            await _context.deXuatThanhToans.AddAsync(DeXuat);
            await _context.thanhToans.AddAsync(ThanhToan);
            await _context.SaveChangesAsync();
            return DeXuat.MaDeXuat;
        }

            public async Task<List<DeXuatThanhToanViewModel>> GetallDeXuat(string MaNhanVien)
        {
            var query = from p in _context.deXuatThanhToans
                        join NV in _context.NhanVienPhongs
                        on p.MaNhanVien equals NV.MaNhanVien
                        join CCT in _context.chuyenCongTacs on p.MaChuyenCongTac equals CCT.MaChuyenCongTac
                        where p.MaNhanVien == MaNhanVien
                        orderby p.TinhTrang
                        select new { p, NV, CCT };

            var DeXuat = await query.Select(x => new DeXuatThanhToanViewModel()
            {
                MaDeXuat = x.p.MaDeXuat,
                TenNhanVien = x.NV.TenNhanVien,
                TenChuyenCongTac = x.CCT.TenChuyenCongTac,
                SoNhanVien = x.p.SoNhanVien,
                ThoiGianDeXuat = x.p.ThoiGianDeXuat.ToShortDateString(),
                TongTien = x.p.TongTien,
                TinhTrang = x.p.TinhTrang,
                Lydo = x.p.Lydo,
                MaChuyenCongTac = x.CCT.MaChuyenCongTac,
                NgayBatDau = x.CCT.NgayBatDau.ToShortDateString(),
                NgayKetThuc = x.CCT.NgayKetThuc.ToShortDateString()
            }).ToListAsync();
            List<DeXuatThanhToanViewModel> duyetDeXuats = new List<DeXuatThanhToanViewModel>();
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Chua xet duyet")
                {
                    duyetDeXuats.Add(item);
                }
            }

            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Truong bo phan da duyet")
                {
                    duyetDeXuats.Add(item);
                }
            }

            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Phong ke toan da xet duyet")
                {
                    duyetDeXuats.Add(item);
                }
            }
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Ban lanh dao da xet duyet")
                {
                    duyetDeXuats.Add(item);
                }
            }
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Da Thanh Toan")
                {
                    duyetDeXuats.Add(item);
                }
            }
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Truong bo phan tu choi")
                {
                    duyetDeXuats.Add(item);
                }
            }
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Phong ke toan tu choi")
                {
                    duyetDeXuats.Add(item);
                }
            }
            foreach (var item in DeXuat)
            {
                if (item.TinhTrang == "Ban lanh dao tu choi")
                {
                    duyetDeXuats.Add(item);
                }
            }

            return duyetDeXuats;
        }

        public async Task<List<ChiPhiThanhToanViewModel>> GetChiTieu(string MaChuyenCongTac)
        {
            var query = from CPCT in _context.chiPhiCongTacs
                        join CP in _context.ChiPhis
                        on CPCT.MaChiPhi equals CP.MaChiPhi
                        where CPCT.MaChuyenCongTac ==MaChuyenCongTac
                        select new { CPCT, CP };
            var chiPhiThanhToan = await query.Select(x => new ChiPhiThanhToanViewModel()
            {
                MaChiPhi = x.CPCT.MaChiPhi,
                SoTienChiTieu = x.CPCT.SoTienChiTieu,
                TongThanhToan=x.CPCT.TongThanhToan
                ,TenChiPhi=x.CP.TenChiPhi,
                MaChuyenCongTac= x.CPCT.MaChuyenCongTac

                //thuat toans de tinh
            }).ToListAsync() ;
            return chiPhiThanhToan;

        }
        public async Task<string> postChiPhiThanhToan(createChiPhiThanhToanRequest request)
        {
            //var ChuyenCongTac = from CTT in _context.chuyenCongTacs
            //                    join
            //                DX in _context.deXuatThanhToans on CTT.MaChuyenCongTac equals
            //                DX.MaChuyenCongTac
            //                where CTT.MaChuyenCongTac==request.MaChuyenCongTac
            //               select CTT.TrangThai;
            var chuyenCongTac = await _context.chuyenCongTacs.FindAsync(request.MaChuyenCongTac);
            var dexuat = from dx in _context.deXuatThanhToans
                         where dx.MaChuyenCongTac == request.MaChuyenCongTac
                         select dx;
            if(dexuat.Count()!=0)
            {
                return null;
            }    
            if (chuyenCongTac.TrangThai == "Chua thuc hien")
                return null;
            var chiPhiThanhToan = new ChiPhiCongTac()
            {
                MaChiPhi = request.MaChiPhi,
                MaChuyenCongTac = request.MaChuyenCongTac,
                SoTienChiTieu = request.SoTienChiTieu,
                TongThanhToan = request.TongThanhToan
            };
            await _context.chiPhiCongTacs.AddAsync(chiPhiThanhToan);
            await _context.SaveChangesAsync();
            return chiPhiThanhToan.MaChiPhi + " " + chiPhiThanhToan.MaChuyenCongTac;


           
        }
        public Task<int> UpdateDeXuat()
        {
            throw new NotImplementedException();
        }
        public async Task<DonViViewModel> GetDonViByMaChiPhi(string MaChiPhi)
        {
            var query =  from DM in _context.ChiPhiChucVus
                        where DM.MaChiPhi == MaChiPhi
                        select DM;
            var chiphi = await query.Select(x => new DonViViewModel()
            {
               DonVi=x.DonVi

            }).ToListAsync();
           
            return chiphi.FirstOrDefault();

        }
        public async Task<int> DeleteDeXuat(string MaDeXuat)
        {
            var deXuat = await _context.deXuatThanhToans.FindAsync(MaDeXuat);
            if(deXuat==null)
            {
                throw new  TLUException("Khong co de xuat nay nay");
            }
            if(deXuat.TinhTrang == "Chua xet duyet") { 
            _context.deXuatThanhToans.Remove(deXuat);
            }
            else
            {
                throw new TLUException("De xuat da xet duyet, khong duoc xoa");
            }
            return await _context.SaveChangesAsync();

        }
        public async Task<int> DeleteChiPhiCongTac(string MaChuyenCongTac,string MaChiPhi)
        {
            var chuyenCongTac = from CTT in _context.chuyenCongTacs
                                join CPCT in _context.chiPhiCongTacs
on CTT.MaChuyenCongTac equals CPCT.MaChuyenCongTac
                                where CPCT.MaChuyenCongTac == MaChuyenCongTac
                                select CTT.TrangThai;
            if (chuyenCongTac.FirstOrDefault().ToString() == "Da thuc hien")
            {
                var ChiPhiDeXuat = await _context.chiPhiCongTacs.FindAsync(MaChiPhi, MaChuyenCongTac);
                // var chucvu = await _context.ChiPhiChucVus.FindAsync(MaChucVu);
                if (ChiPhiDeXuat == null) throw new TLUException("Khong co loai chi phi trong de xuat nay nay");
                _context.chiPhiCongTacs.RemoveRange(ChiPhiDeXuat);
                return await _context.SaveChangesAsync();
            }
            else
            {
                throw new TLUException("khong duoc xoa");
            }
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        public async Task<List<DeXuatThanhToanViewModel>> GetallDeXuatToanTruong()
        {
            var query = from p in _context.deXuatThanhToans
                        join NV in _context.NhanVienPhongs
                        on p.MaNhanVien equals NV.MaNhanVien
                        join CCT in _context.chuyenCongTacs on p.MaChuyenCongTac equals CCT.MaChuyenCongTac
                        
                        orderby p.TinhTrang
                        select new { p, NV, CCT };

            //var SoLuongNhanVien = from NV in _context.nhanVienCongTacs
            //                      where NV.MaChuyenCongTac == request.MaChuyenCongTac
            //                      select NV.MaNhanVien;
            var DeXuat = await query.Select(x => new DeXuatThanhToanViewModel()
            {
                MaDeXuat = x.p.MaDeXuat,
                TenNhanVien = x.NV.TenNhanVien,
                TenChuyenCongTac = x.CCT.TenChuyenCongTac,
                SoNhanVien = x.p.SoNhanVien,
                ThoiGianDeXuat = x.p.ThoiGianDeXuat.ToString().Remove(10),
                TongTien = x.p.TongTien,
                TinhTrang = x.p.TinhTrang,
                Lydo = x.p.Lydo,
                MaChuyenCongTac = x.CCT.MaChuyenCongTac
            }).ToListAsync();

            return DeXuat;
        }
    }
}