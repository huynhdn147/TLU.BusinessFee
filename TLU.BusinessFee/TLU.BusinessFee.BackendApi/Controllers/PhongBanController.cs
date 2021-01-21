using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.PhongBans;
using TLU.BusinessFee.Application.Catalog.PhongBans.DTOS;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        private readonly IPublicPhongBanService _publicPhongBanService;
        private readonly IManagerPhongBanService _managerPhongBanService;
        public PhongBanController(IPublicPhongBanService publicPhongBanService,
            IManagerPhongBanService managerPhongBanService)
        {
            _publicPhongBanService = publicPhongBanService;
            _managerPhongBanService = managerPhongBanService;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var phongban = await _publicPhongBanService.GetAll();
            return Ok(phongban);
        }
        //
        [HttpGet("{MaPhongBan}")]
        public async Task<IActionResult> getbyID(string MaPhongBan)
        {
            var phongban = await _managerPhongBanService.GetByID(MaPhongBan);
            if (phongban == null)
                return BadRequest("khong the tim thay phong ban");
            return Ok(phongban);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PhongBanCrearteRequest request)
        {
            var result = await _managerPhongBanService.Create(request);
            if (result == null)
                return BadRequest();
            var PhongBan = await _managerPhongBanService.GetByID(result);
            return Created(nameof(getbyID), PhongBan);
        }
        [HttpPut("{MaPhongBan}")]
        public async Task<IActionResult> Update([FromForm] PhongBanUpdateRequest request)
        {
            var affecedResult = await _managerPhongBanService.Update(request);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
        [HttpDelete("{maphongban}")]
        public async Task<IActionResult> Delete(string maphongban)
        {
            var affecedResult = await _managerPhongBanService.Delete(maphongban);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }

    }
}
