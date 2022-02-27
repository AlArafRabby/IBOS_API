using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusniessUnitGeneralLedger;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusniessUnitGeneralLedgerController : ControllerBase
    {
        private readonly IBusniessUnitGeneralLedger _Context;
        public BusniessUnitGeneralLedgerController(IBusniessUnitGeneralLedger context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusniessUnitGeneralLedgerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusniessUnitGeneralLedgerAll()
        {
            try
            {
                var dt = await _Context.GetBusniessUnitGeneralLedgerAll();
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
        [Route("GetBusniessUnitGeneralLedgerById")]
        [SwaggerOperation(Description = "Example { BusniessUnitGeneralLedgerid: 0 }")]
        public async Task<IActionResult> GetBusniessUnitGeneralLedgerById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusniessUnitGeneralLedgerById(Id);
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
        [Route("GetBusniessUnitGeneralLedgerByUnitId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusniessUnitGeneralLedgerByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusniessUnitGeneralLedgerByUnitId(UId);
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
        [Route("GetBusniessUnitGeneralLedgerByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusniessUnitGeneralLedgerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusniessUnitGeneralLedgerByClientId(CId);
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
        [Route("CreateBusniessUnitGeneralLedger")]
        [SwaggerOperation(Description = "Example { IntClientId: 0, IntBusinessUnitId: 0, IntGeneralLedgerId: 0, NumCurrentBalance: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusniessUnitGeneralLedger(CreateBusniessUnitGeneralLedgerDTO postBusniessUnitGeneralLedger)
        {
            try
            {
                var dt = await _Context.CreateBusniessUnitGeneralLedger(postBusniessUnitGeneralLedger);
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
        [Route("EditBusniessUnitGeneralLedger")]
        [SwaggerOperation(Description = "Example { IntClientId: 0, IntBusinessUnitId: 0, IntGeneralLedgerId: 0, NumCurrentBalance: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusniessUnitGeneralLedger([FromBody] EditBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger)
        {
            try
            {
                var dt = await _Context.EditBusniessUnitGeneralLedger(BusniessUnitGeneralLedger);
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
        [Route("CancelBusniessUnitGeneralLedger")]
        [SwaggerOperation(Description = "Example {  IntClientId: 0, IntBusinessUnitId: 0, IntGeneralLedgerId: 0, NumCurrentBalance: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z}")]
        public async Task<IActionResult> CancelBusniessUnitGeneralLedger([FromBody] CancelBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger)
        {
            try
            {
                var dt = await _Context.CancelBusniessUnitGeneralLedger(BusniessUnitGeneralLedger);
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