using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.PhongBans;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        private readonly IPublicPhongBanService _publicPhongBanService;
        public PhongBanController(IPublicPhongBanService publicPhongBanService)
        {
            _publicPhongBanService = publicPhongBanService;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var phongban = await _publicPhongBanService.GetAll();
            return Ok(phongban);
        }
    }
}
