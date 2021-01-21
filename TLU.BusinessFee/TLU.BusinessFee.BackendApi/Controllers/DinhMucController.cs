using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus;

namespace TLU.BusinessFee.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinhMucController : ControllerBase
    {
        private readonly IManagerDinhMucService _managerChiPhiChucVuService;
        public DinhMucController(IManagerDinhMucService managerChiPhiChucVuService)
        {
            _managerChiPhiChucVuService = managerChiPhiChucVuService;
        }
        
        [HttpDelete("{maChiPhi}&{maCapBac}")]
        public async Task<IActionResult> Delete(string maChiPhi,string maCapBac)
        {
            var affecedResult = await _managerChiPhiChucVuService.Delete(maChiPhi, maCapBac);
            if (affecedResult == 0)
                return BadRequest();

            return Ok();
        }
    }
}
