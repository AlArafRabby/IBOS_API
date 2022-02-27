using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Warehouse;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouse _Context;
        public WarehouseController(IWarehouse context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetWarehouseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetWarehouseAll()
        {
            try
            {
                var dt = await _Context.GetWarehouseAll();
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
        [Route("GetWarehouseId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetWarehouseById(long Id)
        {
            try
            {
                var dt = await _Context.GetWarehouseById(Id);
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
        [Route("GetWarehouseByUnitId")]
        [SwaggerOperation(Description = "Example { WarehouseByUnitid: 0 }")]
        public async Task<IActionResult> GetWarehouseByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetWarehouseByUnitId(UId);
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
        [Route("GetWarehouseByClientid")]
        [SwaggerOperation(Description = "Example { WarehouseByClientid: 0 }")]
        public async Task<IActionResult> GetWarehouseByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetWarehouseByClientId(CId);
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
        [Route("CreateWarehouse")]
        [SwaggerOperation(Description = "Example { id: 0, WarehouseCode: string, WarehouseName: string, WarehouseAddress: string,  BusinessUnitId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateWarehouse(CreateWarehouseDTO postWarehouse)
        {
            try
            {
                var dt = await _Context.CreateWarehouse(postWarehouse);
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
        [Route("EditWarehouse")]
        [SwaggerOperation(Description = "Example { id: 0, WarehouseCode: string, WarehouseName: string, WarehouseAddress: string,  BusinessUnitId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditWarehouse([FromBody] EditWarehouseDTO Warehouse)
        {
            try
            {
                var dt = await _Context.EditWarehouse(Warehouse);
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
        [Route("CancelWarehouse")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelWarehouse([FromBody] CancelWarehouseDTO Warehouse)
        {
            try
            {
                var dt = await _Context.CancelWarehouse(Warehouse);
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