using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Plant;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private readonly IPlant _Context;
        public PlantController(IPlant context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPlantAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetPlantAll()
        {
            try
            {
                var dt = await _Context.GetPlantAll();
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
        [Route("GetPlantId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetPlantById(long Id)
        {
            try
            {
                var dt = await _Context.GetPlantById(Id);
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
        [Route("GetPlantByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetPlantByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetPlantByClientId(cId);
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
        [Route("CreatePlant")]
        [SwaggerOperation(Description = "Example { PlantCode: string, PlantName: string, PlantAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreatePlant(CreatePlantDTO postPlant)
        {
            try
            {
                var dt = await _Context.CreatePlant(postPlant);
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
        [Route("EditPlant")]
        [SwaggerOperation(Description = "Example { id: 0, PlantCode: string, PlantName: string, PlantAddress: string,  BusinessUnitId: 0, ClientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditPlant([FromBody] EditPlantDTO Plant)
        {
            try
            {
                var dt = await _Context.EditPlant(Plant);
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
        [Route("CancelPlant")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelPlant([FromBody] CancelPlantDTO Plant)
        {
            try
            {
                var dt = await _Context.CancelPlant(Plant);
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