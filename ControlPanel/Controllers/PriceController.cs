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
    public class PriceController : ControllerBase
    {
        private readonly IPrice _Context;
        public PriceController(IPrice context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPrice")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetPrice(long BusinessId, long intPartner, long intItemId, DateTime dtePricingDate, long intTerr, long ChannelId, long sorgid)
        {
            try
            {
                var dt = await _Context.GetPrices(BusinessId, intPartner, intItemId, dtePricingDate, intTerr, ChannelId, sorgid);                
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