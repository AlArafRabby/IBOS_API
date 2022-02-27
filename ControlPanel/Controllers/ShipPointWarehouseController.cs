using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ShipPointWarehouse;
using ControlPanel.Helper;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipPointWarehouseController : ControllerBase
    {
        private readonly IShipPointWarehouse _Context;
        public ShipPointWarehouseController(IShipPointWarehouse context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetShipPointWarehouseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetShipPointWarehouseAll()
        {
            try
            {
                var dt = await _Context.GetShipPointWarehouseAll();
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
        [Route("GetShipPointWarehouseById")]
        [SwaggerOperation(Description = "Example { ShipPointWarehouseid: 0 }")]
        public async Task<IActionResult> GetShipPointWarehouseById(long Id)
        {
            try
            {
                var dt = await _Context.GetShipPointWarehouseById(Id);
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
        [Route("GetShipPointWarehouseByUnitId")]
        [SwaggerOperation(Description = "Example { ShipPointWarehouseByUnitId: 0 }")]
        public async Task<IActionResult> GetShipPointWarehouseByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetShipPointWarehouseByUnitId(UId);
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
        [Route("GetShipPointWarehouseByClientId")]
        [SwaggerOperation(Description = "Example { ShipPointWarehouseByClientId: 0 }")]
        public async Task<IActionResult> GetShipPointWarehouseByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetShipPointWarehouseByClientId(CId);
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
        [Route("CreateShipPointWarehouse")]
        [SwaggerOperation(Description = "Example { ConfigId= 0, ClientId : 0, BusinessUnitId : 0, WarehouseId : 0, ShipPointId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateShipPointWarehouse(DTO.ShipPointWarehouse.CreateShipPointWarehouseDTO postShipPointWarehouse)
        {
            try
            {
                var dt = await _Context.CreateShipPointWarehouse(postShipPointWarehouse);
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
        [Route("EditShipPointWarehouse")]
        [SwaggerOperation(Description = "Example { ConfigId= 0, ClientId : 0, BusinessUnitId : 0, WarehouseId : 0, ShipPointId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditShipPointWarehouse([FromBody] EditShipPointWarehouseDTO ShipPointWarehouse)
        {
            try
            {
                var dt = await _Context.EditShipPointWarehouse(ShipPointWarehouse);
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
        [Route("CancelShipPointWarehouse")]
        [SwaggerOperation(Description = "Example { ConfigId= 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelShipPointWarehouse([FromBody] CancelShipPointWarehouseDTO ShipPointWarehouse)
        {
            try
            {
                var dt = await _Context.CancelShipPointWarehouse(ShipPointWarehouse);
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