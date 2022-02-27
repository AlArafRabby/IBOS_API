using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountingJournalTypeBusinessUnit;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingJournalTypeBusinessUnitController : ControllerBase
    {
        private readonly IAccountingJournalTypeBusinessUnit _Context;
        public AccountingJournalTypeBusinessUnitController(IAccountingJournalTypeBusinessUnit context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountingJournalTypeBusinessUnitAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAccountingJournalTypeBusinessUnitAll()
        {
            try
            {
                var dt = await _Context.GetAccountingJournalTypeBusinessUnitAll();
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
        [Route("GetAccountingJournalTypeBusinessUnitById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetAccountingJournalTypeBusinessUnitById(long Id)
        {
            try
            {
                var dt = await _Context.GetAccountingJournalTypeBusinessUnitById(Id);
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
        [Route("GetAccountingJournalTypeBusinessUnitByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetAccountingJournalTypeBusinessUnitByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetAccountingJournalTypeBusinessUnitByClientId(CId);
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
        [Route("CreateAccountingJournalTypeBusinessUnit")]
        [SwaggerOperation(Description = "Example { id: 0, BusinessUnitId: 0, AccountingJournalTypeBusinessUnitName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAccountingJournalTypeBusinessUnit(CreateAccountingJournalTypeBusinessUnitDTO postAccountingJournalTypeBusinessUnit)
        {
            try
            {
                var dt = await _Context.CreateAccountingJournalTypeBusinessUnit(postAccountingJournalTypeBusinessUnit);
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
        [Route("EditAccountingJournalTypeBusinessUnit")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId:0, BusinessUnitId: 0, AccountingJournalTypeBusinessUnitName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditAccountingJournalTypeBusinessUnit([FromBody] EditAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit)
        {
            try
            {
                var dt = await _Context.EditAccountingJournalTypeBusinessUnit(AccountingJournalTypeBusinessUnit);
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
        [Route("CancelAccountingJournalTypeBusinessUnit")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelAccountingJournalTypeBusinessUnit([FromBody] CancelAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit)
        {
            try
            {
                var dt = await _Context.CancelAccountingJournalTypeBusinessUnit(AccountingJournalTypeBusinessUnit);
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