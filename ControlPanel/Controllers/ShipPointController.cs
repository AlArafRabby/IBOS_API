using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ShipPoint;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipPointController : ControllerBase
    {
        private readonly IShipPoint _Context;
        public ShipPointController(IShipPoint context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetShipPointAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetShipPointAll()
        {
            try
            {
                var dt = await _Context.GetShipPointAll();
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
        [Route("GetShipPointById")]
        [SwaggerOperation(Description = "Example { ShipPointid: 0 }")]
        public async Task<IActionResult> GetShipPointById(long Id)
        {
            try
            {
                var dt = await _Context.GetShipPointById(Id);
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
        [Route("GetShipPointByClientId")]
        [SwaggerOperation(Description = "Example { ShipPoint Client id: 0 }")]
        public async Task<IActionResult> GetShipPointByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetShipPointByClientId(CId);
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
        [Route("GetShipPointByUnitId")]
        [SwaggerOperation(Description = "Example { ShipPoint Unit id: 0 }")]
        public async Task<IActionResult> GetShipPointByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetShipPointByUnitId(UId);
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