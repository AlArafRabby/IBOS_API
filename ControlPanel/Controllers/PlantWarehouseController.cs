using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.PlantWarehouse;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantWarehouseController : ControllerBase
    {
        private readonly IPlantWarehouse _Context;
        public PlantWarehouseController(IPlantWarehouse context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPlantWarehouseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetPlantWarehouseAll()
        {
            try
            {
                var dt = await _Context.GetPlantWarehouseAll();
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
        [Route("GetPlantWarehouseById")]
        [SwaggerOperation(Description = "Example { PlantWarehouseid: 0 }")]
        public async Task<IActionResult> GetPlantWarehouseById(long Id)
        {
            try
            {
                var dt = await _Context.GetPlantWarehouseById(Id);
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
        [Route("GetPlantWarehouseByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetPlantWarehouseByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetPlantWarehouseByClientId(cId);
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
        [Route("CreatePlantWarehouse")]
        [SwaggerOperation(Description = "Example { clientid=0,PlantWarehousecode: string, PlantWarehousename: string, PlantWarehouseTypeId: 0, BusinessUnitId: 0, ParentPlantWarehouseid: 0, PlantId: 0, Division: 0, DivisionName: string, District: 0, DistrictName: string, Thana: 0, ThanaName: string, Address: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreatePlantWarehouse(CreatePlantWarehouseDTO postPlantWarehouse)
        {
            try
            {
                var dt = await _Context.CreatePlantWarehouse(postPlantWarehouse);
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
        [Route("EditPlantWarehouse")]
        [SwaggerOperation(Description = "Example { PlantWarehouseid: 0, PlantWarehousename: string, PlantWarehouseTypeId: 0, BusinessUnitId: 0, ParentPlantWarehouseid: 0, PlantId: 0, Division: 0, DivisionName: string, District: 0, DistrictName: string, Thana: 0, ThanaName: string, Address: string, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditPlantWarehouse([FromBody] EditPlantWarehouseDTO PlantWarehouse)
        {
            try
            {
                var dt = await _Context.EditPlantWarehouse(PlantWarehouse);
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
        [Route("CancelPlantWarehouse")]
        [SwaggerOperation(Description = "Example { PlantWarehouseid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelPlantWarehouse([FromBody] CancelPlantWarehouseDTO PlantWarehouse)
        {
            try
            {
                var dt = await _Context.CancelPlantWarehouse(PlantWarehouse);
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