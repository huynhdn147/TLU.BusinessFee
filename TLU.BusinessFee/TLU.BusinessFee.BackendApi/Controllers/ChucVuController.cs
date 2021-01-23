using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        private readonly IManagerChucVuSerVice _managerChucVuSerVice;
        public ChucVuController(IManagerChucVuSerVice managerChucVuSerVice)
        {
            _managerChucVuSerVice = managerChucVuSerVice;
        }
        [HttpGet]
        public async Task<IActionResult> getall()
        {
            var chucvu = await _managerChucVuSerVice.GetAll();
            return Ok(chucvu);
        }
        [HttpGet("MaChucVu")]
        public async Task<IActionResult> getbyID(string MaChucVu)
        {
            var chucvu = await _managerChucVuSerVice.GetByID(MaChucVu);
            if (chucvu == null)
                return BadRequest("khong the tim thay phong ban");
            return Ok(chucvu);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreatedChucVuRequest request)
        {
            var result = await _managerChucVuSerVice.Create(request);
            if (result == null)
                return BadRequest();
            var chucvu = await _managerChucVuSerVice.GetByID(result);
            return Created(nameof(getbyID), chucvu);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateChucVuRequest request)
        {
            var affecedResult = await _managerChucVuSerVice.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maChucVu}")]
        public async Task<IActionResult> Delete(string maChucVu)
        {
            var affecedResult = await _managerChucVuSerVice.Delete(maChucVu);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
