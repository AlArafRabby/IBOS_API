using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherCodeController : ControllerBase
    {
        private readonly IVoucherCode _Context;
        public VoucherCodeController(IVoucherCode context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetVoucherCode")]
        [SwaggerOperation(Description = "Example { ClientId: 0 }")]
        public async Task<IActionResult> GetVoucherCode(long ClientId, long UnitId, long AccTypeId)
        {
            try
            {
                var dt = await _Context.GetVoucherCode(ClientId, UnitId, AccTypeId);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}