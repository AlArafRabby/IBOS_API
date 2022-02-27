using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountGroup;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountGroupController : ControllerBase
    {
        private readonly IAccountGroup _Context;
        public AccountGroupController(IAccountGroup context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountGroupAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAccountGroupAll()
        {
            try
            {
                var dt = await _Context.GetAccountGroupAll();
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
        [Route("GetAccountGroupById")]
        [SwaggerOperation(Description = "Example { AccountGroupid: 0 }")]
        public async Task<IActionResult> GetAccountGroupById(long Id)
        {
            try
            {
                var dt = await _Context.GetAccountGroupById(Id);
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
        [Route("GetAccountGroupByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetAccountGroupByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetAccountGroupByClientId(CId);
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
        [Route("CreateAccountGroup")]
        [SwaggerOperation(Description = "Example { Clientid: 0,  AccountGroupCode: string, AccountGroupName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAccountGroup(CreateAccountGroupDTO postAccountGroup)
        {
            try
            {
                var dt = await _Context.CreateAccountGroup(postAccountGroup);
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
        [Route("EditAccountGroup")]
        [SwaggerOperation(Description = "Example { AccountGroupid: 0,  ClientId: 0,  AccountGroupName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditAccountGroup([FromBody] EditAccountGroupDTO AccountGroup)
        {
            try
            {
                var dt = await _Context.EditAccountGroup(AccountGroup);
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
        [Route("CancelAccountGroup")]
        [SwaggerOperation(Description = "Example {  AccountGroupid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelAccountGroup([FromBody] CancelAccountGroupDTO AccountGroup)
        {
            try
            {
                var dt = await _Context.CancelAccountGroup(AccountGroup);
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