using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerLedger;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerLedgerController : ControllerBase
    {
        private readonly IBusinessPartnerLedger _Context;
        public BusinessPartnerLedgerController(IBusinessPartnerLedger context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerLedgerById")]
        [SwaggerOperation(Description = "Example { BusinessPartnerLedgerid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerLedgerById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerLedgerById(Id);
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
        [Route("GetBusinessPartnerLedgerByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerLedgerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerLedgerByClientId(CId);
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
        [Route("GetBusinessPartnerLedgerByUnitId")]
        [SwaggerOperation(Description = "Example { Unitid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerLedgerByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerLedgerByUnitId(UId);
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
        [Route("CreateBusinessPartnerLedger")]
        [SwaggerOperation(Description = "Example { TransactionDate: 2020-02-09T11:42:09.172Z , clientid: 0, BusinessUnitId: 0, BusinessAreaId: 0, BusinessPartnerId: 0, AccountingJournalTypeId : 0, AccountingJournalTypeName: string, Amount: 0, RunningAmount: 0, Narration: string, AccountingJournalId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerLedger(CreateBusinessPartnerLedgerDTO postBusinessPartnerLedger)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerLedger(postBusinessPartnerLedger);
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
        [Route("EditBusinessPartnerLedger")]
        [SwaggerOperation(Description = "Example { TransactionDate: 2020-02-09T11:42:09.172Z , clientid: 0, BusinessUnitId: 0, BusinessAreaId: 0, BusinessPartnerId: 0, AccountingJournalTypeId : 0, AccountingJournalTypeName: string, Amount: 0, RunningAmount: 0, Narration: string, AccountingJournalId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessPartnerLedger([FromBody] EditBusinessPartnerLedgerDTO BusinessPartnerLedger)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerLedger(BusinessPartnerLedger);
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
        [Route("CancelBusinessPartnerLedger")]
        [SwaggerOperation(Description = "Example {  TransactionId: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerLedger([FromBody] CancelBusinessPartnerLedgerDTO BusinessPartnerLedger)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerLedger(BusinessPartnerLedger);
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