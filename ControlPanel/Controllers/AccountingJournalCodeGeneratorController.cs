using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingJournalCodeGeneratorController : ControllerBase
    {
        private readonly IAccountingJournalCodeGenerator _Context;
        public AccountingJournalCodeGeneratorController(IAccountingJournalCodeGenerator context)
        {
            _Context = context;
        }
        //[HttpGet]
        //[Route("GetItemTypeByBusinessUnitid")]
        //[SwaggerOperation(Description = "Example { Businessid: 0 }")]
        //public async Task<IActionResult> GetItemTypeByBusinessUnitid(DTO.AccountingJournalCodeGenerator.CreateAccountingJournalCodeGenerator postAccountingJournalCodeGenerator)
        //{
        //    try
        //    {
        //        var dt = await _Context.GetAccountingJournalCodeGeneratorId(postAccountingJournalCodeGenerator);
        //        if (dt == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //} 

    }
}