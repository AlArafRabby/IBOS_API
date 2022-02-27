using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AccountCategory;
using ControlPanel.Helper;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCategoryController : ControllerBase
    {
        private readonly IAccountCategory _Context;

        ILogger<AccountCategoryController> _logger;
        
        public AccountCategoryController(IAccountCategory context, ILogger<AccountCategoryController> logger)
        {
            _Context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAccountCategoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetAccountCategoryAll()
        {
            try
            {
                _logger.LogInformation($"GetAccountCategoryAll ! : {TimeZones.GetCurrentDatTime()}");

                var dt = await _Context.GetAccountCategoryAll();
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                _logger.LogCritical("GetAccountCategoryAll error", ex);
                _logger.LogError(ex, "GetAccountCategoryAll  buggy.");
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetAccountCategoryById")]
        [SwaggerOperation(Description = "Example { AccountCategoryid: 0 }")]
        public async Task<IActionResult> GetAccountCategoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetAccountCategoryById(Id);
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
        [Route("GetAccountCategoryByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetAccountCategoryByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetAccountCategoryByClientId(CId);
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
        [Route("CreateAccountCategory")]
        [SwaggerOperation(Description = "Example { clientid: 0, AccountGroupId: 0, AccountClassId: 0, AccountCategoryCode: string, AccountCategoryName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateAccountCategory(CreateAccountCategoryDTO postAccountCategory)
        {
            try
            {
                var dt = await _Context.CreateAccountCategory(postAccountCategory);
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
        [Route("EditAccountCategory")]
        [SwaggerOperation(Description = "Example { AccountCategoryid: 0,clientId:0, AccountGroupId: 0, AccountClassId: 0, AccountCategoryCode: string, AccountCategoryName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditAccountCategory([FromBody] EditAccountCategoryDTO AccountCategory)
        {
            try
            {
                var dt = await _Context.EditAccountCategory(AccountCategory);
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
        [Route("CancelAccountCategory")]
        [SwaggerOperation(Description = "Example {  AccountCategoryid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelAccountCategory([FromBody] CancelAccountCategoryDTO AccountCategory)
        {
            try
            {
                var dt = await _Context.CancelAccountCategory(AccountCategory);
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