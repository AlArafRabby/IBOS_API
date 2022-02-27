using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TradeOfferSetupHeader;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOfferSetupHeaderController : ControllerBase
    {
        private readonly ITradeOfferSetupHeader _Context;
        public TradeOfferSetupHeaderController(ITradeOfferSetupHeader context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTradeOfferSetupHeaderById")]
        [SwaggerOperation(Description = "Example { TradeOfferConditionid: 0 }")]
        public async Task<IActionResult> GetTradeOfferSetupHeaderById(long Id)
        {
            try
            {
                var dt = await _Context.GetTradeOfferSetupHeaderById(Id);
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
        [Route("GetTradeOfferbyItemId")]
        [SwaggerOperation(Description = "Example { Itemid: 0 }")]
        public async Task<IActionResult> GetTradeOfferbyItemId(long itemId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferbyItemId(itemId);
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
        [Route("GetTradeOfferSetupHeaderByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetTradeOfferSetupHeaderByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferSetupHeaderByClientId(CId);
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
        [Route("GetTradeOfferSetupHeaderByUnitId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetTradeOfferSetupHeaderByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferSetupHeaderByUnitId(UId);
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
        [Route("GetTradeOfferSetupHeaderByPartnerId")]
        [SwaggerOperation(Description = "Example { Partnerid: 0 }")]
        public async Task<IActionResult> GetTradeOfferSetupHeaderByPartnerId(long PId)
        {
            try
            {
                var dt = await _Context.GetTradeOfferSetupHeaderByPartnerId(PId);
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
        [Route("CreateTradeOfferSetupHeader")]
        [SwaggerOperation(Description = "Example { TradeOfferConditionId: 0 , Clientid: 0, BusinessUnitId: 0, PriceConditionTypeId: 0, PriceConditionTypeName: string, PriceConditionReffId:0, TradeOfferConditionTypeId:0, TradeOfferConditionTypeName: string,TradeOfferConditionReffId:0, RoundingTypeId: 0 , MinimumApplied : 0, ValueBase: 0 , SlabProgram: 0, StartDate:2020-02-09T11:42:09.172Z ,EndDate: 2020-02-09T11:42:09.172Z,  actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateTradeOfferSetupHeader(CreateTradeOfferSetupCommonDTO postTradeOfferSetupHeadercommon)
        {
            try
            {
                var dt = await _Context.CreateTradeOfferSetupHeader(postTradeOfferSetupHeadercommon);
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
        [Route("CancelTradeOfferSetupHeader")]
        [SwaggerOperation(Description = "Example {  TradeOfferConditionId: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelTradeOfferSetupHeader([FromBody] CancelTradeOfferSetupHeaderDTO TradeOfferSetupHeader)
        {
            try
            {
                var dt = await _Context.CancelTradeOfferSetupHeader(TradeOfferSetupHeader);
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