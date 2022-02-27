using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.LogTerritorySalesForceChange;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogTerritorySalesForceChangeController : ControllerBase
    {
        private readonly ILogTerritorySalesForceChange _Context;
        public LogTerritorySalesForceChangeController(ILogTerritorySalesForceChange context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetLogTerritorySalesForceChangeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetLogTerritorySalesForceChangeAll()
        {
            try
            {
                var dt = await _Context.GetLogTerritorySalesForceChangeAll();
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
        [Route("GetLogTerritorySalesForceChangeById")]
        [SwaggerOperation(Description = "Example { Logid: 0 }")]
        public async Task<IActionResult> GetLogTerritorySalesForceChangeById(long Id)
        {
            try
            {
                var dt = await _Context.GetLogTerritorySalesForceChangeById(Id);
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
        [Route("GetLogTerritorySalesForceChangeByUnitId")]
        [SwaggerOperation(Description = "Example { Uid: 0 }")]
        public async Task<IActionResult> GetLogTerritorySalesForceChangeByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetLogTerritorySalesForceChangeByUnitId(UId);
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
        [Route("GetLogTerritorySalesForceChangeByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetLogTerritorySalesForceChangeByClientId(long cid)
        {
            try
            {
                var dt = await _Context.GetLogTerritorySalesForceChangeByClientId(cid);
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
        [Route("CreateLogTerritorySalesForceChange")]
        [SwaggerOperation(Description = "Example { clientid=0, BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, FromDate: 2020-02-09T11:42:09.172Z, ToDate: 2020-02-09T11:42:09.172Z,  actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateLogTerritorySalesForceChange(CreateLogTerritorySalesForceChangeDTO postLogTerritorySalesForceChange)
        {
            try
            {
                var dt = await _Context.CreateLogTerritorySalesForceChange(postLogTerritorySalesForceChange);
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
        [Route("EditLogTerritorySalesForceChange")]
        [SwaggerOperation(Description = "Example { Logid: 0, BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, FromDate: 2020-02-09T11:42:09.172Z, ToDate: 2020-02-09T11:42:09.172Z, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditLogTerritorySalesForceChange([FromBody] EditLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange)
        {
            try
            {
                var dt = await _Context.EditLogTerritorySalesForceChange(LogTerritorySalesForceChange);
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
        [Route("CancelLogTerritorySalesForceChange")]
        [SwaggerOperation(Description = "Example { Logid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelLogTerritorySalesForceChange([FromBody] CancelLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange)
        {
            try
            {
                var dt = await _Context.CancelLogTerritorySalesForceChange(LogTerritorySalesForceChange);
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