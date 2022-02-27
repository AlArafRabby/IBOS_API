using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BankJournalHeader;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankJournalHeaderController : ControllerBase
    {
        private readonly IBankJournalHeader _Context;
        public BankJournalHeaderController(IBankJournalHeader context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("BankJournalbyBusinessAreaId")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> BankJournalbyBusinessAreaId(long AreaId)
        {
            try
            {
                var dt = await _Context.BankJournalbyBusinessAreaId(AreaId);
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
        [Route("BankJournalbyBusinessUnitId")]
        [SwaggerOperation(Description = "Example { BankJournalHeaderid: 0 }")]
        public async Task<IActionResult> BankJournalbyBusinessUnitId(long UnitId, bool isPosted)
        {
            try
            {
                var dt = await _Context.BankJournalbyBusinessUnitId( UnitId, isPosted);
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
        [Route("BankJournalbyClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> BankJournalbyClientId(long ClientId)
        {
            try
            {
                var dt = await _Context.BankJournalbyClientId(ClientId);
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
        [Route("BankJournalbyVoucherId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> BankJournalbyVoucherId(long VoucherId)
        {
            try
            {
                var dt = await _Context.BankJournalbyVoucherId(VoucherId);
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
        [Route("CreateBankJournalVoucher")]
        [SwaggerOperation(Description = "Example { clientid: 0, AccountGroupId: 0, AccountClassId: 0, BankJournalHeaderCode: string, BankJournalHeaderName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankJournalVoucher(CreateBankJournalHeaderCommonDTO postBankJournalHeaderCommon)
        {
            try
            {
                var dt = await _Context.CreateBankJournalVoucher(postBankJournalHeaderCommon);
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
        [Route("EditBankJournalVoucher")]
        [SwaggerOperation(Description = "Example { BankJournalHeaderid: 0,clientId:0, AccountGroupId: 0, AccountClassId: 0, BankJournalHeaderCode: string, BankJournalHeaderName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditBankJournalVoucher([FromBody] EditBankJournalHeaderCommonDTO BankJournalHeaderCommon)
        {
            try
            {
                var dt = await _Context.EditBankJournalVoucher(BankJournalHeaderCommon);
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
        [Route("CancelBankJournalVoucher")]
        [SwaggerOperation(Description = "Example {  BankJournalHeaderid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBankJournalVoucher([FromBody] CancelBankJournalHeaderDTO BankJournalHeader)
        {
            try
            {
                var dt = await _Context.CancelBankJournalVoucher(BankJournalHeader);
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
        [Route("CompleteBankJournalVoucher")]
        [SwaggerOperation(Description = "Example {  BankJournalHeaderid: 0, actionBy: 0}")]
        public async Task<IActionResult> CompleteBankJournalVoucher([FromBody] EditBankJournalHeaderDTO BankJournalHeader)
        {
            try
            {
                var dt = await _Context.CompleteBankJournalVoucher(BankJournalHeader);
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