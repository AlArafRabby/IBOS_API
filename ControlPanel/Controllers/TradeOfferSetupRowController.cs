using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TradeOfferSetupRow;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOfferSetupRowController : ControllerBase
    {
        private readonly ITradeOfferSetupRow _Context;
        public TradeOfferSetupRowController(ITradeOfferSetupRow context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTradeOfferSetupRowById")]
        [SwaggerOperation(Description = "Example { RowId: 0 }")]
        public async Task<IActionResult> GetTradeOfferSetupRowById(long Id)
        {
            try
            {
                var dt = await _Context.GetTradeOfferSetupRowById(Id);
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