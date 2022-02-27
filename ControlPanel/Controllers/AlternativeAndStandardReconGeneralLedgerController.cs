using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AlternativeAndStandardReconGeneralLedger;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlternativeAndStandardReconGeneralLedgerController : ControllerBase
    {
        private readonly IAlternativeAndStandardReconGeneralLedger _Context;
        public AlternativeAndStandardReconGeneralLedgerController(IAlternativeAndStandardReconGeneralLedger context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAlternativeAndStandardReconGeneralLedgerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAlternativeAndStandardReconGeneralLedgerAll()
        {
            try
            {
                var dt = await _Context.GetAlternativeAndStandardReconGeneralLedgerAll();
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
        [Route("GetAlternativeAndStandardReconGeneralLedgerById")]
        [SwaggerOperation(Description = "Example { AlternativeAndStandardReconGeneralLedgerid: 0 }")]
        public async Task<IActionResult> GetAlternativeAndStandardReconGeneralLedgerById(long Id)
        {
            try
            {
                var dt = await _Context.GetAlternativeAndStandardReconGeneralLedgerById(Id);
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
        [Route("GetAlternativeAndStandardReconGeneralLedgerByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetAlternativeAndStandardReconGeneralLedgerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetAlternativeAndStandardReconGeneralLedgerByClientId(CId);
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
        [Route("CreateAlternativeAndStandardReconGeneralLedger")]
        [SwaggerOperation(Description = "Example { clientid: 0, AccountGroupId: 0, AccountClassId: 0, AlternativeAndStandardReconGeneralLedgerCode: string, AlternativeAndStandardReconGeneralLedgerName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAlternativeAndStandardReconGeneralLedger(CreateAlternativeAndStandardReconGeneralLedgerDTO postAlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                var dt = await _Context.CreateAlternativeAndStandardReconGeneralLedger(postAlternativeAndStandardReconGeneralLedger);
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
        [Route("EditAlternativeAndStandardReconGeneralLedger")]
        [SwaggerOperation(Description = "Example { AlternativeAndStandardReconGeneralLedgerid: 0,clientId:0, AccountGroupId: 0, AccountClassId: 0, AlternativeAndStandardReconGeneralLedgerCode: string, AlternativeAndStandardReconGeneralLedgerName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditAlternativeAndStandardReconGeneralLedger([FromBody] EditAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                var dt = await _Context.EditAlternativeAndStandardReconGeneralLedger(AlternativeAndStandardReconGeneralLedger);
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
        [Route("CancelAlternativeAndStandardReconGeneralLedger")]
        [SwaggerOperation(Description = "Example {  AlternativeAndStandardReconGeneralLedgerid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelAlternativeAndStandardReconGeneralLedger([FromBody] CancelAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                var dt = await _Context.CancelAlternativeAndStandardReconGeneralLedger(AlternativeAndStandardReconGeneralLedger);
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