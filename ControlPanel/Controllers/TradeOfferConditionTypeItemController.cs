using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TradeOfferConditionTypeItem;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOfferConditionTypeItemController : ControllerBase
    {
        private readonly ITradeOfferConditionTypeItem _Context;
        public TradeOfferConditionTypeItemController(ITradeOfferConditionTypeItem context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTradeOfferConditionTypeItemAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetTradeOfferConditionTypeItemAll()
        {
            try
            {
                var dt = await _Context.GetTradeOfferConditionTypeItemAll();
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

        [HttpGet]
        [Route("GetTradeOfferConditionTypeItemById")]
        [SwaggerOperation(Description = "Example { TradeOfferConditionTypeItemid: 0 }")]
        public async Task<IActionResult> GetTradeOfferConditionTypeItemById(long Id)
        {
            try
            {
                var dt = await _Context.GetTradeOfferConditionTypeItemById(Id);
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