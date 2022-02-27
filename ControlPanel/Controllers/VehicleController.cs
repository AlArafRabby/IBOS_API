using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Vehicle;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicle _Context;
        public VehicleController(IVehicle context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetVehicleAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetVehicleAll()
        {
            try
            {
                var dt = await _Context.GetVehicleAll();
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
        [Route("GetVehicleById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetVehicleById(long Id)
        {
            try
            {
                var dt = await _Context.GetVehicleById(Id);
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
        [Route("GetVehicleByUnitId")]
        [SwaggerOperation(Description = "Example { VehicleByUnitid: 0 }")]
        public async Task<IActionResult> GetVehicleByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetVehicleByUnitId(UId);
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
        [Route("GetVehicleByClientId")]
        [SwaggerOperation(Description = "Example { VehicleByClientid: 0 }")]
        public async Task<IActionResult> GetVehicleByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetVehicleByClientId(CId);
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
        [Route("CreateVehicle")]
        [SwaggerOperation(Description = "Example { id: 0, VehicleNo: string, VehicleCode: string, BusinessUnitId: 0,  ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateVehicle(CreateVehicleDTO postVehicle)
        {
            try
            {
                var dt = await _Context.CreateVehicle(postVehicle);
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
        [Route("EditVehicle")]
        [SwaggerOperation(Description = "Example { id: 0, VehicleNo: string, VehicleCode: string, BusinessUnitId: 0,  ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditVehicle([FromBody] EditVehicleDTO putVehicle)
        {
            try
            {
                var dt = await _Context.EditVehicle(putVehicle);
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
        [Route("CancelVehicle")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelVehicle([FromBody] CancelVehicleDTO putVehicle)
        {
            try
            {
                var dt = await _Context.CancelVehicle(putVehicle);
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