using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TradeOfferItemGroupHeader;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOfferItemGroupController : ControllerBase
    {
        private readonly ITradeOfferItemGroupHeader _Context;

        public TradeOfferItemGroupController(ITradeOfferItemGroupHeader context)
        {
            _Context = context;
        }
        [HttpPost]
        [Route("CreateTradeOfferItemGroupHeader")]
        [SwaggerOperation(Description = "Example { TradeOfferItemGroupId: 0, TradeOfferItemGroupName: string,  ClientId: 0,BusinessUnitId:0,ActionBy=0, LastActionDateTime: 2020-02-09T11:42:09.172Z,BusinessUnitId=0,TradeOfferItemGroupId=0,ItemId=0 }")]
        public async Task<IActionResult> CreateTradeOfferItemGroupHeader(CreateTradeOfferItemGroupHeaderCommon postTradeOfferItemGroupHeaderCommon)
        {
            try
            {
                var dt = await _Context.CreateTradeOfferItemGroupHeader(postTradeOfferItemGroupHeaderCommon);
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

        [HttpPut]
        [Route("EditTradeOfferItemGroupHeader")]
        [SwaggerOperation(Description = "Example { TradeOfferGroupId: 0, TradeOfferItemGroupName: string,  ActionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z ,TradeOfferItemGroupId=0,rowid=0,ItemId=0}")]
        public async Task<IActionResult> EditTradeOfferItemGroupHeader(EditTradeOfferItemGroupHeaderCommon putTradeOfferItemGroupHeaderCommon)
        {
            try
            {
                var dt = await _Context.EditTradeOfferItemGroupHeader(putTradeOfferItemGroupHeaderCommon);
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