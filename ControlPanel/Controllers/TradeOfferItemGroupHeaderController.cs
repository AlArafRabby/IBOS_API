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
    public class TradeOfferItemGroupHeaderController : ControllerBase
    {
        private readonly ITradeOfferItemGroupHeader _Context;

        public TradeOfferItemGroupHeaderController(ITradeOfferItemGroupHeader context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTradeOfferItemGroupHeaderById")]
        [SwaggerOperation(Description = "Example { TradeOfferItemGroupHeaderid: 0 }")]
        public async Task<IActionResult> GetTradeOfferItemGroupHeaderById(long Id)
        {
            try
            {
                var dt = await _Context.GetTradeOfferItemGroupHeaderById(Id);
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
        [Route("GetTradeOfferItemGroupHeaderByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetTradeOfferItemGroupHeaderByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferItemGroupHeaderByClientId(CId);
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
        [Route("GetTradeOfferItemGroupHeaderByUnitId")]
        [SwaggerOperation(Description = "Example { Unitid: 0 }")]
        public async Task<IActionResult> GetTradeOfferItemGroupHeaderByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferItemGroupHeaderByUnitId(UId);
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

        [HttpPost]
        [Route("CreateTradeOfferItemGroupHeaderCommon")]
        [SwaggerOperation(Description = "Example { TradeOfferItemGroupId: 0, TradeOfferItemGroupName: string, ClientId:0, BusinessUnitId: 0,  actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
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
        [Route("EditTradeOfferItemGroupHeaderCommon")]
        [SwaggerOperation(Description = "Example { TradeOfferItemGroupId: 0, TradeOfferItemGroupName: string, ClientId:0, BusinessUnitId: 0,  actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
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

        [HttpPut]
        [Route("CancelTradeOfferItemGroupHeader")]
        [SwaggerOperation(Description = "Example {  TradeOfferItemGroupId: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelTradeOfferItemGroupHeader([FromBody] CancelTradeOfferItemGroupHeaderDTO TradeOfferItemGroupHeader)
        {
            try
            {
                var dt = await _Context.CancelTradeOfferItemGroupHeader(TradeOfferItemGroupHeader);
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