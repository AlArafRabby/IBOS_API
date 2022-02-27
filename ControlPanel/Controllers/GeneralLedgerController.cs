using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.GeneralLedger;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralLedgerController : ControllerBase
    {
        private readonly IGeneralLedger _Context;
        public GeneralLedgerController(IGeneralLedger context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetGeneralLedgerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetGeneralLedgerAll()
        {
            try
            {
                var dt = await _Context.GetGeneralLedgerAll();
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
        [Route("GetGeneralLedgerById")]
        [SwaggerOperation(Description = "Example { GeneralLedgerid: 0 }")]
        public async Task<IActionResult> GetGeneralLedgerById(long Id)
        {
            try
            {
                var dt = await _Context.GetGeneralLedgerById(Id);
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
        [Route("GetGeneralLedgerByClientId")]
        [SwaggerOperation(Description = "Example { GeneralLedgerByClientId: 0 }")]
        public async Task<IActionResult> GetGeneralLedgerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetGeneralLedgerByClientId(CId);
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
        [Route("CreateGeneralLedger")]
        [SwaggerOperation(Description = "Example { id= 0, AccountGroupId : 0, AccountClassId : 0, AccountCategoryId : 0, GeneralLedgerCode : string, GeneralLedgerName : string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateGeneralLedger(DTO.GeneralLedger.CreateGeneralLedgerDTO postGeneralLedger)
        {
            try
            {
                var dt = await _Context.CreateGeneralLedger(postGeneralLedger);
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
        [Route("EditGeneralLedger")]
        [SwaggerOperation(Description = "Example { AccountGroupId : 0, AccountClassId : 0, AccountCategoryId : 0, GeneralLedgerCode : string, GeneralLedgerName : string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditGeneralLedger([FromBody] EditGeneralLedgerDTO generalledger)
        {
            try
            {
                var dt = await _Context.EditGeneralLedger(generalledger);
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
        [Route("CancelGeneralLedger")]
        [SwaggerOperation(Description = "Example { GeneralLedgerid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelGeneralLedger([FromBody] CancelGeneralLedgerDTO generalledger)
        {
            try
            {
                var dt = await _Context.CancelGeneralLedger(generalledger);
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