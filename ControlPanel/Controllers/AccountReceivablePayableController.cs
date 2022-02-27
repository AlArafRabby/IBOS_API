using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountReceivablePayable;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountReceivablePayableController : ControllerBase
    {
        private readonly IAccountReceivablePayable _Context;
        public AccountReceivablePayableController(IAccountReceivablePayable context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountReceivablePayablebyClientIdBusinessUnitId")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0 }")]
        public async Task<IActionResult> GetAccountReceivablePayablebyClientIdBusinessUnitId(long ClientId, long BusinessUnitId)
        {
            try
            {
                var dt = await _Context.GetAccountReceivablePayablebyClientIdBusinessUnitId(ClientId, BusinessUnitId);
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
        [Route("CreateBankBranch")]
        [SwaggerOperation(Description = "Example {  ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0, BusinessPartnerId: 0, InvoiceCode: string, AdjustmentJournalId: 0,AdjustmentJournalCode: string, Amount: 0, Narration: string, IsReceivable: True, PayTerm: 0, TransactionDate: 0, DueDate: 0, Cleared: string, ClearingDate: True, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankBranch(CreateAccountReceivablePayableDTO postAccountReceivablePayable)
        {
            try
            {
                var dt = await _Context.CreateAccountReceivablePayableVoucher(postAccountReceivablePayable);
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