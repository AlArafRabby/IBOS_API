using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Territory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ControllerBase
    {
        private readonly ITerritory _Context;
        public TerritoryController(ITerritory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTerritoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetTerritoryAll()
        {
            try
            {
                var dt = await _Context.GetTerritoryAll();
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
        [Route("GetTerritoryById")]
        [SwaggerOperation(Description = "Example { Territoryid: 0 }")]
        public async Task<IActionResult> GetTerritoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetTerritoryById(Id);
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
        [Route("GetTerritoryByUnitId")]
        [SwaggerOperation(Description = "Example { TerritoryByUnitId: 0 }")]
        public async Task<IActionResult> GetTerritoryByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetTerritoryByUnitId(UId);
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
        [Route("GetTerritoryByClientId")]
        [SwaggerOperation(Description = "Example { TerritoryByClientId: 0 }")]
        public async Task<IActionResult> GetTerritoryByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetTerritoryByClientId(CId);
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
        [Route("GetTerritoryByTerritoryTypeId")]
        [SwaggerOperation(Description = "Example { TerritoryByTerritoryTypeId: 0 }")]
        public async Task<IActionResult> GetTerritoryByTerritoryTypeId(long TTId, long UId)
        {
            try
            {
                var dt = await _Context.GetTerritoryByTerritoryTypeId(TTId, UId);
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
        [Route("GetTerritoryByParentTerritoryId")]
        [SwaggerOperation(Description = "Example { TerritoryByParentTerritoryId: 0 }")]
        public async Task<IActionResult> GetTerritoryByParentTerritoryId(long PTId, long UId)
        {
            try
            {
                var dt = await _Context.GetTerritoryByParentTerritoryId(PTId, UId);
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
        [Route("CreateTerritory")]
        [SwaggerOperation(Description = "Example { Territorycode: string, Territoryname: string, TerritoryTypeId: 0, BusinessUnitId: 0, ParentTerritoryid: 0, PlantId: 0, Division: 0, DivisionName: string, District: 0, DistrictName: string, Thana: 0, ThanaName: string, Address: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateTerritory(DTO.Territory.CreateTerritoryDTO postTerritory)
        {
            try
            {
                var dt = await _Context.CreateTerritory(postTerritory);
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
        [Route("EditTerritory")]
        [SwaggerOperation(Description = "Example { Territoryid: 0, Territoryname: string, TerritoryTypeId: 0, BusinessUnitId: 0, ParentTerritoryid: 0, PlantId: 0, Division: 0, DivisionName: string, District: 0, DistrictName: string, Thana: 0, ThanaName: string, Address: string, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditTerritory([FromBody] EditTerritoryDTO Territory)
        {
            try
            {
                var dt = await _Context.EditTerritory(Territory);
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
        [Route("CancelTerritory")]
        [SwaggerOperation(Description = "Example { Territoryid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelTerritory([FromBody] CancelTerritoryDTO Territory)
        {
            try
            {
                var dt = await _Context.CancelTerritory(Territory);
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