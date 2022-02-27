using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BankAccount;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccount _Context;
        public BankAccountController(IBankAccount context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBankAccountAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBankAccountAll()
        {
            try
            {
                var dt = await _Context.GetBankAccountAll();
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
        [Route("GetBankAccountById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetBankAccountById(long Id)
        {
            try
            {
                var dt = await _Context.GetBankAccountById(Id);
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
        [Route("GetBankAccountByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBankAccountByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBankAccountByClientId(CId);
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
        [Route("GetBankAccountByUnitId")]
        [SwaggerOperation(Description = "Example { Unitid: 0 }")]
        public async Task<IActionResult> GetBankAccountByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBankAccountByUnitId(UId);
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
        [Route("CreateBankAccount")]
        [SwaggerOperation(Description = "Example { BankAccountName: string, BankAccountNo: string, BankId: 0, BankName: string, BankBranchId: 0, BankBranchName: string, ClientID: 0, UnitID: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankAccount(CreateBankAccountDTO postBankAccount)
        {
            try
            {
                var dt = await _Context.CreateBankAccount(postBankAccount);
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
        [Route("EditBankAccount")]
        [SwaggerOperation(Description = "Example { id: 0, BankAccountName: string, BankAccountNo: string, BankId: 0, BankName: string, BankBranchId: 0, BankBranchName: string, ClientID: 0, UnitID: 0, actionBy: 0 }")]
        public async Task<IActionResult> EditBankAccount([FromBody] EditBankAccountDTO BankAccount)
        {
            try
            {
                var dt = await _Context.EditBankAccount(BankAccount);
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
        [Route("CancelBankAccount")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBankAccount([FromBody] CancelBankAccountDTO BankAccount)
        {
            try
            {
                var dt = await _Context.CancelBankAccount(BankAccount);
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