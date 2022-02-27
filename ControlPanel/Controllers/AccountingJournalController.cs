using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountingJournal;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingJournalController : ControllerBase
    {
        private readonly IAccountingJournal _Context;
        public AccountingJournalController(IAccountingJournal context)
        {
            _Context = context;
        }

        [HttpPost]
        [Route("CreateAccountingJournal")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0, AccountingJournalTypeId: 0, AccountingJournalId: 0, AccountingJournalCode: string, TransactionDate: 2020-02-09, GeneralLedgerId: 0, GeneralLedgerCode: string, Amount: 0, Narration: string, GeneralLedgerCode: string, Amount: 0, Narration: string, actionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankAccount(CreateAccountingJournalDTO postAccountingJournal)
        {
            try
            {
                var dt = await _Context.CreateAccountingJournalVoucher(postAccountingJournal);
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