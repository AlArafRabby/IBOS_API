using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ElasticSearch;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElasticSearchLogController : ControllerBase
    {
        ILogger<ElasticSearchLogController> _logger; 
        public ElasticSearchLogController( ILogger<ElasticSearchLogController> logger)
        { 
            _logger = logger;
        }

        [HttpPost]
        [Route("ElasticSearchLogCreate")]        
        public async Task<IActionResult> ElasticSearchLogCreate(CreateLogElasticSearchDTO log)
        {
            try
            {
                _logger.LogInformation($"{log.LogInfo} ! : {log.CurrentDateTime}");

                _logger.LogCritical("{log.LogInfo} +error", log.ErrorLog);
                _logger.LogError(log.ErrorLog, "'"+ log.LogInfo + "'  bug.");
                return await Task.FromResult(Ok("OK"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}