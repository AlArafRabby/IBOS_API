using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Route;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRoute _Context;
        public RouteController(IRoute context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetRouteAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetRouteAll()
        {
            try
            {
                var dt = await _Context.GetRouteAll();
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
        [Route("GetRouteId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetRouteById(long Id)
        {
            try
            {
                var dt = await _Context.GetRouteById(Id);
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
        [Route("GetRouteByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetRouteByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetRouteByClientId(cId);
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
        [Route("GetRouteByUnitId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetRouteByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetRouteByUnitId(UId);
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
        [Route("CreateRoute")]
        [SwaggerOperation(Description = "Example { RouteCode: string, RouteName: string, RouteAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateRoute(CreateRouteDTO postRoute)
        {
            try
            {
                var dt = await _Context.CreateRoute(postRoute);
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
        [Route("EditRoute")]
        [SwaggerOperation(Description = "Example { id: 0, RouteCode: string, RouteName: string, RouteAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditRoute([FromBody] EditRouteDTO Route)
        {
            try
            {
                var dt = await _Context.EditRoute(Route);
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
        [Route("CancelRoute")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelRoute([FromBody] CancelRouteDTO Route)
        {
            try
            {
                var dt = await _Context.CancelRoute(Route);
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