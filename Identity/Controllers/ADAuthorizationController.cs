using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.DbContexts;
using Identity.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Identity.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ADAuthorizationController : ControllerBase
    {
        ILogger<ADAuthorizationController> _logger;
        private readonly DB_SecurityContext _context;
        public ADAuthorizationController(DB_SecurityContext context, ILogger<ADAuthorizationController> logger)
        {
            _logger = logger;
            _context = context;
        }
         
        [HttpGet]
        [Route("ADAuthorization")]
        public async Task<ActionResult> Authorization([FromQuery] string username, string password)
        {
            try
            {
                _logger.LogInformation($"Active Directory Check {username.ToString()}! : {DateTime.UtcNow}");
                ActiveDirectoryValidation activeval = new ActiveDirectoryValidation();
                if (activeval.ValidateUser(username, password))
                {
                    return Ok(true);
                }
                else
                {
                    return NotFound(false);
                }

            }
            catch(Exception ex)
            {
                _logger.LogCritical($"Active DirectoryCheck Error {username.ToString()} ", ex);
                _logger.LogError(ex, $"TActive DirectoryCheck  {username.ToString()} ");
                return NotFound(false);
            }
           
             
        }
    }
}