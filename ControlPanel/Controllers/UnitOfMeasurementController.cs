using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.UnitOfMeasurement;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasurementController : ControllerBase
    {
        private readonly IUnitOfMeasurement _Context;
        public UnitOfMeasurementController(IUnitOfMeasurement context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetUnitOfMeasurementAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetUnitOfMeasurementAll()
        {
            try
            {
                var dt = await _Context.GetUnitOfMeasurementAll();
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
        [Route("GetUnitOfMeasurementById")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementid: 0 }")]
        public async Task<IActionResult> GetUnitOfMeasurementById(long Id)
        {
            try
            {
                var dt = await _Context.GetUnitOfMeasurementById(Id);
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
        [Route("GetUnitOfMeasurementByUnitId")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementUnitid: 0 }")]
        public async Task<IActionResult> GetUnitOfMeasurementByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetUnitOfMeasurementByUnitId(UId);
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
        [Route("GetUnitOfMeasurementByClientId")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementByClientId: 0 }")]
        public async Task<IActionResult> GetUnitOfMeasurementByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetUnitOfMeasurementByClientId(CId);
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
        [Route("CreateUnitOfMeasurement")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementname: string, BusinessUnitId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateUnitOfMeasurement(CreateUnitOfMeasurementDTO postUnitOfMeasurement)
        {
            try
            {
                var dt = await _Context.CreateUnitOfMeasurement(postUnitOfMeasurement);
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
        [Route("EditUnitOfMeasurement")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementid: 0, UnitOfMeasurementname: string, BusinessUnitId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditUnitOfMeasurement([FromBody] EditUnitOfMeasurementDTO UnitOfMeasurement)
        {
            try
            {
                var dt = await _Context.EditUnitOfMeasurement(UnitOfMeasurement);
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
        [Route("CancelUnitOfMeasurement")]
        [SwaggerOperation(Description = "Example { UnitOfMeasurementid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelUnitOfMeasurement([FromBody] CancelUnitOfMeasurementDTO UnitOfMeasurement)
        {
            try
            {
                var dt = await _Context.CancelUnitOfMeasurement(UnitOfMeasurement);
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