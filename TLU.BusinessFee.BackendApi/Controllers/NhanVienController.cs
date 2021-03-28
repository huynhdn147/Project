using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.NhanViens;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using TLU.BusinessFee.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using TLU.BusinessFee.Application.System;
using System.Security.Claims;
using TLU.BusinessFee.Data.EF;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NhanVienController : ControllerBase
    {

        private readonly IHostingEnvironment _appEnvironment;
        private readonly TLUBusinessFeeDbContext _context;
        private readonly IManagerNhanVienService _managarNhanVienService;
        public NhanVienController(IManagerNhanVienService managarNhanVienService, IHostingEnvironment appEnvironment, TLUBusinessFeeDbContext context)
        {
            _managarNhanVienService = managarNhanVienService;
            _appEnvironment = appEnvironment;
            _context = context;
        }

        [HttpHead]
        public UserLoginViewModel post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claims = identity.Claims.ToList();
            var RoleId = claims[1].Value;
            var roleName = from Rn in _context.Roles
                           where Rn.Id == RoleId
                           select Rn.Name;

            var data = new UserLoginViewModel
            {
                MaNhanVien = claims[0].Value,
                RoleName = roleName.ToList()[0],
                RoleID = claims[1].Value
            };
            return data;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var role = post();
            if (role.RoleID == "RL01" || role.RoleID == "RL04" || role.RoleID == "RL05") {
                var nhanvien = await _managarNhanVienService.GetAll();
                return Ok(nhanvien);
            }
            if (role.RoleID == "RL02"||role.RoleID=="RL03")
            {
                var phongban = from NV in _context.NhanVienPhongs
                               where NV.MaNhanVien==role.MaNhanVien
                               select NV.MaPhongBan;
                var MaPhongBan = phongban.FirstOrDefault();
                var nhanvien = await _managarNhanVienService.GetAllByPhongBanID(MaPhongBan);
                return Ok(nhanvien);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet("getbyNVid/{MaNhanVien}")]
        public async Task<IActionResult> getbyID(string MaNhanVien)
        {
            var nhanvien = await _managarNhanVienService.GetByID(MaNhanVien);
            if (nhanvien == null)
                return BadRequest("khong the tim thay nhan vien");
            return Ok(nhanvien);
        }
        [HttpGet("getbypbid /{MaPhongBan}")]
        public async Task<IActionResult> getbyPhongBanID(string MaPhongBan)
        {
            var nhanvien = await _managarNhanVienService.GetAllByPhongBanID(MaPhongBan);
            if (nhanvien == null)
                return BadRequest("khong the tim thay nhan vien");
            return Ok(nhanvien);
        }
        [HttpGet("getbycvid /{MaCapBac}")]
        public async Task<IActionResult> getbyChucVuID(string MaCapBac)
        {
            var nhanvien = await _managarNhanVienService.GetAllByChucVuID(MaCapBac);
            if (nhanvien == null)
                return BadRequest("khong the tim thay nhan vien");
            return Ok(nhanvien);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNhanVienRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var result = await _managarNhanVienService.Create(request);
                if (result == null)
                    return BadRequest();
                var PhongBan = await _managarNhanVienService.GetByID(result);
                return Created(nameof(getbyID), PhongBan);
            }
            else
                return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateNhanVienRequest request)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var affecedResult = await _managarNhanVienService.Update(request);
                if (affecedResult == 0)
                {
                    return BadRequest();
                }
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{maNhanVien}")]
        public async Task<IActionResult> Delete(string maNhanVien)
        {
            var role = post().RoleID;
            if (role == "RL01" || role == "RL04" || role == "RL05")
            {
                var affecedResult = await _managarNhanVienService.Delete(maNhanVien);
                if (affecedResult == 0)
                {
                    return BadRequest();
                }
                return Ok();
            }
            else
                return BadRequest();
        }
        //[HttpPost("createdByExcel")]
        //public async Task<IActionResult> CreatedByExcel(IFormCollection collection)
        //{
        //    var files = HttpContext.Request.Form.Files;
        //    List<NhanVienPhongBan> nhanvien = new List<NhanVienPhongBan>();
        //    foreach (var item in files)
        //    {
        //        if (item.Length > 0 && item != null)
        //        {
        //            string file_name = Guid.NewGuid().ToString().Replace("-", "") + "_" + item.FileName;
        //            string uploads = Path.Combine(_appEnvironment.WebRootPath, "files");
        //            string urlPart = uploads + "/" + file_name;
        //            string extension = Path.GetExtension(urlPart);
        //            if (extension == ".xls" || extension == ".xslx")
        //            {
        //                using (var fileStream = new FileStream(Path.Combine(uploads, file_name), FileMode.Create))
        //                {
        //                    await item.CopyToAsync(fileStream);
        //                }
        //                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //                using (var stream = System.IO.File.Open(urlPart, FileMode.Open, FileAccess.Read))
        //                {
        //                    using (var reader = ExcelReaderFactory.CreateReader(stream))
        //                    {
        //                        do
        //                        {
        //                            if ( true /*reader.Name == "page1" || reader.Name == "page2"*/)
        //                            {
        //                                while (reader.Read())
        //                                {
        //                                    nhanvien.Add(new NhanVienPhongBan
        //                                    {
        //                                        MaNhanVien = request.MaNhanVien,
        //                                        TenNhanVien = request.TenNhanVien,
        //                                        MaChucVu = request.MaChucVu,
        //                                        MaPhongBan = request.MaPhongBan

        //                                    });
        //                                }
        //                            }
        //                        } while (reader.NextResult());

        //                    }
        //                }
                        
        //            }
        //        }
        //    }
        //    if (nhanvien.Count > 0)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
