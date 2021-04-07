using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ThanhToans.DTOS;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.ThanhToans
{
    public class ThanhToanManagerService : IThanhToanManagerService
    {
        private readonly TLUBusinessFeeDbContext _context;
    
        public ThanhToanManagerService(TLUBusinessFeeDbContext context)
        {
            _context = context;
          
        }
        public async Task<List<ThanhToanViewModel>> GetAll()
        {
            var query = from TT in _context.thanhToans
                            join DX in _context.deXuatThanhToans
                            on TT.MaDeXuat equals DX.MaDeXuat
                            join CTT in _context.chuyenCongTacs
                            on DX.MaChuyenCongTac equals CTT.MaChuyenCongTac
                            join NV in _context.NhanVienPhongs on DX.MaNhanVien equals NV.MaNhanVien
                            select new { TT, DX, CTT,NV };
                            
             var thanhtoan= await query.Select(x=>new ThanhToanViewModel()
            {
                MaHoaDon=x.TT.MaHoaDon,
                MaDeXuat=x.DX.MaDeXuat,
                TenChuyenCongTac=x.CTT.TenChuyenCongTac,
                TenNhanVienDeXuat=x.NV.TenNhanVien,
                SoNhanVien=x.DX.SoNhanVien,
                ThoiGianDeXuat=x.DX.ThoiGianDeXuat.ToShortDateString(),
                TongChiPhi=x.DX.TongTien,
                TinhTrang=x.DX.TinhTrang,
                MaChuyenCongTac=x.CTT.MaChuyenCongTac
            }).ToListAsync();

            List<ThanhToanViewModel> thanhToanViewModels = new List<ThanhToanViewModel>();
            foreach (var item in thanhtoan)
            {
                if (item.TinhTrang == "Ban lanh dao da xet duyet")
                {
                    thanhToanViewModels.Add(item);
                }
            }
            foreach (var item in thanhtoan)
            {
                if (item.TinhTrang == "Phong ke toan da xet duyet")
                {
                    thanhToanViewModels.Add(item);
                }
            }
            foreach (var item in thanhtoan)
            {
                if (item.TinhTrang == "Truong bo phan da duyet")
                {
                    thanhToanViewModels.Add(item);
                }
            }
            foreach (var item in thanhtoan)
            {
                if (item.TinhTrang == "Da Thanh Toan")
                {
                    thanhToanViewModels.Add(item);
                }
            }
            foreach (var item in thanhtoan)
            {
                if (item.TinhTrang == "Chua xet duyet")
                {
                    thanhToanViewModels.Add(item);
                }
            }
            return thanhToanViewModels;
        }

        
        public async Task<string> ThanhToan(string MaHoaDon,string MaDeXuat)
        {

            var ThanhToan = await _context.thanhToans.FindAsync(MaHoaDon, MaDeXuat);
            var dexuat = from TT in _context.thanhToans
                         join DX in _context.deXuatThanhToans on TT.MaDeXuat equals DX.MaDeXuat
                         where MaHoaDon == TT.MaHoaDon
                         select DX;
            var dexuatDF = dexuat.FirstOrDefault();
            if (dexuatDF.TinhTrang != "Ban lanh dao da xet duyet")
            {
                return null;
            }
            else
            {
                ThanhToan.TinhTrang = "Da Thanh Toan";
                dexuatDF.TinhTrang = "Da Thanh Toan";
                await _context.SaveChangesAsync();
                return ThanhToan.MaDeXuat;
            }


        }
    }
}
