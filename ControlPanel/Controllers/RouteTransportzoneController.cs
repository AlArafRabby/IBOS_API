using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.RouteTransportzone;
using ControlPanel.IRepository;
using ControlPanel.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteTransportzoneController : ControllerBase
    {
        private readonly IRouteTransportzone _Context;
        public RouteTransportzoneController(IRouteTransportzone context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetRouteTransportzoneAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetRouteTransportzoneAll()
        {
            try
            {
                var dt = await _Context.GetRouteTransportzoneAll();
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
        [Route("GetRouteTransportzoneId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetRouteTransportzoneById(long Id)
        {
            try
            {
                var dt = await _Context.GetRouteTransportzoneById(Id);
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
        [Route("GetRouteTransportzoneByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetRouteTransportzoneByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetRouteTransportzoneByClientId(cId);
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
        [Route("GetRouteTransportzoneByUnitId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetRouteTransportzoneByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetRouteTransportzoneByUnitId(UId);
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
        [Route("CreateRouteTransportzone")]
        [SwaggerOperation(Description = "Example { RouteTransportzoneCode: string, RouteTransportzoneName: string, RouteTransportzoneAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateRouteTransportzone(CreateRouteTransportzoneDTO postRouteTransportzone)
        {
            try
            {
                var dt = await _Context.CreateRouteTransportzone(postRouteTransportzone);
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
        [Route("EditRouteTransportzone")]
        [SwaggerOperation(Description = "Example { id: 0, RouteTransportzoneCode: string, RouteTransportzoneName: string, RouteTransportzoneAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditRouteTransportzone([FromBody] EditRouteTransportzoneDTO RouteTransportzone)
        {
            try
            {
                var dt = await _Context.EditRouteTransportzone(RouteTransportzone);
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
        [Route("CancelRouteTransportzone")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelRouteTransportzone([FromBody] CancelRouteTransportzoneDTO RouteTransportzone)
        {
            try
            {
                var dt = await _Context.CancelRouteTransportzone(RouteTransportzone);
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