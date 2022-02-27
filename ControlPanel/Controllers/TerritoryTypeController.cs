using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TerritoryType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryTypeController : ControllerBase
    {
        private readonly ITerritoryType _Context;
        public TerritoryTypeController(ITerritoryType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetTerritoryTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetTerritoryTypeAll()
        {
            try
            {
                var dt = await _Context.GetTerritoryTypeAll();
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
        [Route("GetTerritoryTypeById")]
        [SwaggerOperation(Description = "Example { TerritoryTypeid: 0 }")]
        public async Task<IActionResult> GetTerritoryTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetTerritoryTypeById(Id);
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
        [Route("GetTerritoryTypeByUnitId")]
        [SwaggerOperation(Description = "Example { TerritoryTypeByUnitId: 0 }")]
        public async Task<IActionResult> GetTerritoryTypeByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetTerritoryTypeById(UId);
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
        [Route("GetTerritoryTypeByClientId")]
        [SwaggerOperation(Description = "Example { TerritoryTypeByClientId: 0 }")]
        public async Task<IActionResult> GetTerritoryTypeByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetTerritoryTypeByClientId(CId);
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
        [Route("CreateTerritoryType")]
        [SwaggerOperation(Description = "Example { TerritoryTypename: string, BusinessUnitId: 0, LevelPosition: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateTerritoryType(CreateTerritoryTypeDTO postTerritoryType)
        {
            try
            {
                var dt = await _Context.CreateTerritoryType(postTerritoryType);
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
        [Route("EditTerritoryType")]
        [SwaggerOperation(Description = "Example { TerritoryTypeid: 0, TerritoryTypename: string, BusinessUnitId: 0, LevelPosition: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditTerritoryType([FromBody] EditTerritoryTypeDTO TerritoryType)
        {
            try
            {
                var dt = await _Context.EditTerritoryType(TerritoryType);
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
        [Route("CancelTerritoryType")]
        [SwaggerOperation(Description = "Example { TerritoryTypeid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelTerritoryType([FromBody] CancelTerritoryTypeDTO TerritoryType)
        {
            try
            {
                var dt = await _Context.CancelTerritoryType(TerritoryType);
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