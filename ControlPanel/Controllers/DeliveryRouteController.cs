using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.DeliveryRoute;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryRouteController : ControllerBase
    {
        private readonly IDeliveryRoute _Context;
        public DeliveryRouteController(IDeliveryRoute context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetDeliveryRouteAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDeliveryRouteAll()
        {
            try
            {
                var dt = await _Context.GetDeliveryRouteAll();
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
        [Route("GetDeliveryRouteId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetDeliveryRouteById(long Id)
        {
            try
            {
                var dt = await _Context.GetDeliveryRouteById(Id);
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
        [Route("GetDeliveryRouteByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetDeliveryRouteByClientBusinessUnitId(long CId, long UId)
        {
            try
            {
                var dt = await _Context.GetDeliveryRouteByClientBusinessUnitId(CId, UId);
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
        [Route("CreateDeliveryRoute")]
        [SwaggerOperation(Description = "Example {  }")]
        public async Task<IActionResult> CreateDeliveryRoute(CreateDeliveryRouteDTO postDeliveryRoute)
        {
            try
            {
                var dt = await _Context.CreateDeliveryRoute(postDeliveryRoute);
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
        [Route("EditDeliveryRoute")]
        [SwaggerOperation(Description = "Example { id: 0, DeliveryRouteCode: string, DeliveryRouteName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditDeliveryRoute([FromBody] EditDeliveryRouteDTO DeliveryRoute)
        {
            try
            {
                var dt = await _Context.EditDeliveryRoute(DeliveryRoute);
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
        [Route("CancelDeliveryRoute")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelDeliveryRoute([FromBody] CancelDeliveryRouteDTO DeliveryRoute)
        {
            try
            {
                var dt = await _Context.CancelDeliveryRoute(DeliveryRoute);
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