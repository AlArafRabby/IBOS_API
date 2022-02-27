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
    public class TransportModeController : ControllerBase
    {
        private readonly ITransportMode _Context;
        public TransportModeController(ITransportMode context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTransportModeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetTransportModeAll()
        {
            try
            {
                var dt = await _Context.GetTransportModeAll();
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
        [Route("GetTransportModeById")]
        [SwaggerOperation(Description = "Example { SalesOfficeid: 0 }")]
        public async Task<IActionResult> GetTransportModeById(long Id)
        {
            try
            {
                var dt = await _Context.GetTransportModeById(Id);
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