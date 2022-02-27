using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountReceivablePayableCommon;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountReceivablePayableCommonController : ControllerBase
    {
        private readonly IAccountReceivablePayableCommon _Context;

        public AccountReceivablePayableCommonController(IAccountReceivablePayableCommon context)
        {
            _Context = context;
        }
        
        [HttpGet]
        [Route("GetAccountReceivablePayableHeaderById")]
        [SwaggerOperation(Description = "Example { ReceivablePayableId: 0, iscomplete : true/false}")]
        public async Task<IActionResult> GetAccountReceivablePayableHeaderById(long ReceivablePayableId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAccountReceivablePayableHeaderById(ReceivablePayableId, iscomplete);
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
        [Route("GetAccountPayableRowById")]
        [SwaggerOperation(Description = "Example { ReceivablePayableId: 0}")]
        public async Task<IActionResult> GetAccountPayableRowById(long ReceivablePayableId)
        {
            try
            {
                var dt = await _Context.GetAccountPayableRowById(ReceivablePayableId);
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
        [Route("GetAccountReceivablePayableHeaderClientBusinessUnitArea")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0, iscomplete : true/false}")]
        public async Task<IActionResult> GetAccountReceivablePayableHeaderClientBusinessUnitArea(long ClientId, long BusinessUnitId, long BusinessAreaId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAccountReceivablePayableHeaderClientBusinessUnitArea(ClientId, BusinessUnitId, BusinessAreaId, iscomplete);
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
        [Route("GetAccountReceivablePayableHeaderClientBusinessUnitPartner")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, BusinessPartnerId: 0, iscomplete : true/false}")]
        public async Task<IActionResult> GetAccountReceivablePayableHeaderClientBusinessUnitPartner(long ClientId, long BusinessUnitId, long BusinessPartnerId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAccountReceivablePayableHeaderClientBusinessUnitPartner(ClientId, BusinessUnitId, BusinessPartnerId, iscomplete);
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
        [Route("GetAccountReceivablePayableHeaderClientIdBusinessUnitId")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, iscomplete : true/false}")]
        public async Task<IActionResult> GetAccountReceivablePayableHeaderClientIdBusinessUnitId(long ClientId, long BusinessUnitId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAccountReceivablePayableHeaderClientIdBusinessUnitId(ClientId, BusinessUnitId, iscomplete);
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
        [Route("GetAccountReceivableRowById")]
        [SwaggerOperation(Description = "Example { receivablePayableId: 0 }")]
        public async Task<IActionResult> GetAccountReceivableRowById(long receivablePayableId)
        {
            try
            {
                var dt = await _Context.GetAccountReceivableRowById(receivablePayableId);
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
        [Route("CreateAccountReceivablePayableCommon")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0,BusinessPartnerId: 0, InvoiceCode: string, AdjustmentJournalId: 0, AdjustmentJournalCode: string, Amount: 0,Narration: string,IsReceivable: true/false, PayTerm: string, TransactionDate: 2020-02-09,DueDate:  2020-02-09, IsCleared: false, ClearingDate: 2020-02-09,ActionBy: 0 ,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAccountReceivablePayableCommon(CreateAccountReceivablePayableCommonDTO postCreateAccountReceivablePayableCommon)
        {
            try
            {
                var dt = await _Context.CreateAccountReceivablePayableCommon(postCreateAccountReceivablePayableCommon);
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
        [Route("EditAccountReceivablePayableCommon")]
        [SwaggerOperation(Description = "Example { AdjustmentJournalId: 0, AdjustmentJournalCode: string,JournalDate:2020-02-09 ,ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0,DebitAmount: 0, CreditAmount: 0,Narration: string,IsPosted: false,  AccountingJournalTypeId: 0,IsDirectPosting: true/False,actionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z ,RowId: 0, AdjustmentJournalId: 0, AdjustmentJournalCode: string, GeneralLedgerId: 0, GeneralLedgerName: string, Narration: string, Amount: 0 }")]
        public async Task<IActionResult> EditAccountReceivablePayableCommon([FromBody] EditAccountReceivablePayableCommonDTO putAccountReceivablePayableCommon)
        {
            try
            {
                var dt = await _Context.EditAccountReceivablePayableCommon(putAccountReceivablePayableCommon);
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
        [Route("CancelAccountReceivablePayableCommon")]
        [SwaggerOperation(Description = "Example {  AccountReceivablePayableId: 0, ActionBy: 0}")]
        public async Task<IActionResult> CancelAccountReceivablePayableCommon([FromBody] CancelAccountReceivablePayableHeaderDTO putAccountReceivablePayableHeader)
        {
            try
            {
                var dt = await _Context.CancelAccountReceivablePayableCommon(putAccountReceivablePayableHeader);
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