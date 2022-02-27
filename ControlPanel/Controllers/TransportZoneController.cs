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
    public class TransportZoneController : ControllerBase
    {
        private readonly ITransportZone _Context;
        public TransportZoneController(ITransportZone context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTransportZoneAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetTransportZoneAll()
        {
            try
            {
                var dt = await _Context.GetTransportZoneAll();
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
        [Route("GetTransportZoneById")]
        [SwaggerOperation(Description = "Example { TransportZoneid: 0 }")]
        public async Task<IActionResult> GetTransportZoneById(long Id)
        {
            try
            {
                var dt = await _Context.GetTransportZoneById(Id);
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
        [Route("GetTransportZoneByClientId")]
        [SwaggerOperation(Description = "Example { TransportZoneid: 0 }")]
        public async Task<IActionResult> GetTransportZoneByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetTransportZoneByClientId(CId);
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
        [Route("GetTransportZoneByUnitId")]
        [SwaggerOperation(Description = "Example { TransportZoneid: 0 }")]
        public async Task<IActionResult> GetTransportZoneByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetTransportZoneByUnitId(UId);
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