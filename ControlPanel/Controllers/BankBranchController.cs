using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO. BankBranch;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankBranchController : ControllerBase
    {
        private readonly IBankBranch _Context;
        public  BankBranchController(IBankBranch context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBankBranchAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBankBranchAll()
        {
            try
            {
                var dt = await _Context.GetBankBranchAll();
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
        [Route("GetBankBranchById")]
        [SwaggerOperation(Description = "Example { BankBranchid: 0 }")]
        public async Task<IActionResult> GetBankBranchById(long Id)
        {
            try
            {
                var dt = await _Context.GetBankBranchById(Id);
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
        [SwaggerOperation(Description = "Example { BankBranchCode: string, BankBranchName: string, BankBranchAddress: string, BankBranchCode: string, CountryId: 0, BankId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankBranch(CreateBankBranchDTO postBankBranch)
        {
            try
            {
                var dt = await _Context.CreateBankBranch(postBankBranch);
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
        [Route("EditBankBranch")]
        [SwaggerOperation(Description = "Example { BankBranchCode: string, BankBranchName: string, BankBranchAddress: string, BankBranchCode: string, CountryId: 0, BankId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBankBranch([FromBody] EditBankBranchDTO BankBranch)
        {
            try
            {
                var dt = await _Context.EditBankBranch(BankBranch);
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
        [Route("CancelBankBranch")]
        [SwaggerOperation(Description = "Example {  BankBranchid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBankBranch([FromBody] CancelBankBranchDTO BankBranch)
        {
            try
            {
                var dt = await _Context.CancelBankBranch(BankBranch);
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