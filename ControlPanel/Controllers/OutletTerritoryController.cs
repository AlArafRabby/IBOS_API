using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.OutletTerritory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletTerritoryController : ControllerBase
    {
        private readonly IOutletTerritory _Context;
        public OutletTerritoryController(IOutletTerritory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetOutletTerritoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetOutletTerritoryAll()
        {
            try
            {
                var dt = await _Context.GetOutletTerritoryAll();
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
        [Route("GetOutletTerritoryById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetOutletTerritoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetOutletTerritoryById(Id);
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
        [Route("GetOutletTerritoryByClientId")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetOutletTerritoryByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetOutletTerritoryByClientId(cId);
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
        [Route("GetOutletTerritoryByUnitId")]
        [SwaggerOperation(Description = "Example { Uid: 0 }")]
        public async Task<IActionResult> GetOutletTerritoryByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetOutletTerritoryByUnitId(UId);
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
        [Route("CreateOutletTerritory")]
        [SwaggerOperation(Description = "Example { clientid=0, BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateOutletTerritory(CreateOutletTerritoryDTO postOutletTerritory)
        {
            try
            {
                var dt = await _Context.CreateOutletTerritory(postOutletTerritory);
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
        [Route("EditOutletTerritory")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditOutletTerritory([FromBody] EditOutletTerritoryDTO OutletTerritory)
        {
            try
            {
                var dt = await _Context.EditOutletTerritory(OutletTerritory);
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
        [Route("CancelOutletTerritory")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelOutletTerritory([FromBody] CancelOutletTerritoryDTO OutletTerritory)
        {
            try
            {
                var dt = await _Context.CancelOutletTerritory(OutletTerritory);
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