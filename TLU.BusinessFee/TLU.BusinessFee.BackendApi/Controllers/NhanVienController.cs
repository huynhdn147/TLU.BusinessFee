using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.NhanViens;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly IManagerNhanVienService _managarNhanVienService;
        public NhanVienController(IManagerNhanVienService managarNhanVienService)
        {
            _managarNhanVienService = managarNhanVienService;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var nhanvien = await _managarNhanVienService.GetAll();
            return Ok(nhanvien);
        }


        [HttpGet("{MaNhanVien}")]
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
        [HttpGet("getbycvid /{MaChucVu}")]
        public async Task<IActionResult> getbyChucVuID(string MaChucVu)
        {
            var nhanvien = await _managarNhanVienService.GetAllByChucVuID(MaChucVu);
            if (nhanvien == null)
                return BadRequest("khong the tim thay nhan vien");
            return Ok(nhanvien);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateNhanVienRequest request)
        {
            var result = await _managarNhanVienService.Create(request);
            if (result == null)
                return BadRequest();
            var PhongBan = await _managarNhanVienService.GetByID(result);
            return Created(nameof(getbyID), PhongBan);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateNhanVienRequest request)
        {
            var affecedResult = await _managarNhanVienService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maNhanVien}")]
        public async Task<IActionResult> Delete(string maNhanVien)
        {
            var affecedResult = await _managarNhanVienService.Delete(maNhanVien);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
