using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountClass;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountClassController : ControllerBase
    {
        private readonly IAccountClass _Context;
        public AccountClassController(IAccountClass context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountClassAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAccountClassAll()
        {
            try
            {
                var dt = await _Context.GetAccountClassAll();
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
        [Route("GetAccountClassById")]
        [SwaggerOperation(Description = "Example { AccountClassid: 0 }")]
        public async Task<IActionResult> GetAccountClassById(long Id)
        {
            try
            {
                var dt = await _Context.GetAccountClassById(Id);
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
        [Route("GetAccountClassByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetAccountClassByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetAccountClassByClientId(CId);
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
        [Route("CreateAccountClass")]
        [SwaggerOperation(Description = "Example { Clientid: 0, AccountGroupId: 0, AccountClassCode: string, AccountClassName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAccountClass(CreateAccountClassDTO postAccountClass)
        {
            try
            {
                var dt = await _Context.CreateAccountClass(postAccountClass);
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
        [Route("EditAccountClass")]
        [SwaggerOperation(Description = "Example { AccountClassid: 0, clientId: 0, AccountGroupId: 0, AccountClassId: 0, AccountClassCode: string, AccountClassName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditAccountClass([FromBody] EditAccountClassDTO AccountClass)
        {
            try
            {
                var dt = await _Context.EditAccountClass(AccountClass);
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
        [Route("CancelAccountClass")]
        [SwaggerOperation(Description = "Example {  AccountClassid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelAccountClass([FromBody] CancelAccountClassDTO AccountClass)
        {
            try
            {
                var dt = await _Context.CancelAccountClass(AccountClass);
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