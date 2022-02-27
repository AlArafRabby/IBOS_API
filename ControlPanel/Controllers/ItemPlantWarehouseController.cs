using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPlantWarehouseController : ControllerBase
    {
        private readonly IItemPlantWarehouse _Context;
        public ItemPlantWarehouseController(IItemPlantWarehouse context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemPlantWarehouseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemPlantWarehouseAll()
        {
            try
            {
                var dt = await _Context.GetItemPlantWarehouseAll();
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
        [Route("GetItemPlantWarehouseById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemPlantWarehouseById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemPlantWarehouseById(Id);
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
        [Route("GetItemPlantWarehouseByClientId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemPlantWarehouseByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemPlantWarehouseByClientId(cId);
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
        [Route("GetItemPlantWarehouseByUnitId")]
        [SwaggerOperation(Description = "Example { Uid: 0 }")]
        public async Task<IActionResult> GetItemPlantWarehouseByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetItemPlantWarehouseByUnitId(UId);
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
        [Route("CreateItemPlantWarehouse")]
        [SwaggerOperation(Description = "Example { clientid=0, BusinessUnitId: 0, PlantId:0,ItemId: 0,WarehouseId=0,ActionBy=0,LastActionDateTime= 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemPlantWarehouse(DTO.ItemPlantWarehouse.CreateItemPlantWarehouseDTO postItemPlantWarehouse)
        {
            try
            {
                var dt = await _Context.CreateItemPlantWarehouse(postItemPlantWarehouse);
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
        [Route("EditItemPlantWarehouse")]
        [SwaggerOperation(Description = "Example { BusinessUnitId:0 ,PlantId=0,ItemId=0,WarehouseId=0,ActionBy=0}}")]
        public async Task<IActionResult> EditItemPlantWarehouse([FromBody] DTO.ItemPlantWarehouse.EidtItemPlantWarehouseDTO ItemPlantWarehouse)
        {
            try
            {
                var dt = await _Context.EditItemPlantWarehouse(ItemPlantWarehouse);
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
        [Route("CancelItemPlantWarehouse")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemPlantWarehouse([FromBody] DTO.ItemPlantWarehouse.CancelItemPlantWarehouseDTO ItemPlantWarehouse)
        {
            try
            {
                var dt = await _Context.CancelItemPlantWarehouse(ItemPlantWarehouse);
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