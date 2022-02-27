using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.PriceSetup;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceSetupController : ControllerBase
    {
        private readonly IPriceSetup _Context;
        public PriceSetupController(IPriceSetup context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPriceSetupById")]
        [SwaggerOperation(Description = "Example { PriceSetupid: 0 }")]
        public async Task<IActionResult> GetPriceSetupById(long Id)
        {
            try
            {
                var dt = await _Context.GetPriceSetupById(Id);
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
        [Route("GetPriceSetupByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 , fromDate: 2020-02-09T11:42:09.172Z , Todate:2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> GetPriceSetupByClientId(long CId, DateTime fromDate, DateTime Todate)
        {
            try
            {
                var dt = await _Context.GetPriceSetupClientId(CId,fromDate, Todate);
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
        [Route("GetPriceSetupByUnitId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 , fromDate: 2020-02-09T11:42:09.172Z , Todate:2020-02-09T11:42:09.172Z}")]
        public async Task<IActionResult> GetPriceSetupByUnitId(long UId, DateTime fromDate, DateTime Todate)
        {
            try
            {
                var dt = await _Context.GetPriceSetupByUnitId(UId, fromDate, Todate);
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
        [Route("CreatePriceSetup")]
        [SwaggerOperation(Description = "Example { clientid: 0, unitid: 0, conditiontypeId: 0, ConditiontypeName: string, ConditionReffId: 0, ItemId: 0, price:0.00, startDate:2020-02-09T11:42:09.172Z, EndDate:2020-02-09T11:42:09.172Z , actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreatePriceSetup(CreatePriceSetupDTO postPriceSetup)
        {
            try
            {
                var dt = await _Context.CreatePriceSetup(postPriceSetup);
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
        [Route("CancelPriceSetup")]
        [SwaggerOperation(Description = "Example {  PriceSetupid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelPriceSetup([FromBody] CancelPriceSetupDTO PriceSetup)
        {
            try
            {
                var dt = await _Context.CancelPriceSetup(PriceSetup);
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