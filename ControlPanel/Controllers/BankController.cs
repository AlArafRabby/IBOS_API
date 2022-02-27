using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Bank;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBank _Context;
        public BankController(IBank context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBankAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBankAll()
        {
            try
            {
                var dt = await _Context.GetBankAll();
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
        [Route("GetBankById")]
        [SwaggerOperation(Description = "Example { Bankid: 0 }")]
        public async Task<IActionResult> GetBankById(long Id)
        {
            try
            {
                var dt = await _Context.GetBankById(Id);
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
        [Route("CreateBank")]
        [SwaggerOperation(Description = "Example { BankName: string, BankCode: string,  actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBank(CreateBankDTO postBank)
        {
            try
            {
                var dt = await _Context.CreateBank(postBank);
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
        [Route("EditBank")]
        [SwaggerOperation(Description = "Example { Bankid: 0, BankName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditBank([FromBody] EditBankDTO Bank)
        {
            try
            {
                var dt = await _Context.EditBank(Bank);
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
        [Route("CancelBank")]
        [SwaggerOperation(Description = "Example {  Bankid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBank([FromBody] CancelBankDTO Bank)
        {
            try
            {
                var dt = await _Context.CancelBank(Bank);
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