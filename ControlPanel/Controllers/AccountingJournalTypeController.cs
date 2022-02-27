using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountingJournalType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingJournalTypeController : ControllerBase
    {
        private readonly IAccountingJournalType _Context;
        public AccountingJournalTypeController(IAccountingJournalType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountingJournalTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAccountingJournalTypeAll()
        {
            try
            {
                var dt = await _Context.GetAccountingJournalTypeAll();
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
        [Route("GetAccountingJournalTypeById")]
        [SwaggerOperation(Description = "Example { AccountingJournalTypeid: 0 }")]
        public async Task<IActionResult> GetAccountingJournalTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetAccountingJournalTypeById(Id);
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