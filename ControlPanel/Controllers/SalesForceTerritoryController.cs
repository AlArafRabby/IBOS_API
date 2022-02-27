using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesForceTerritory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesForceTerritoryController : ControllerBase
    {
        private readonly ISalesForceTerritory _Context;
        public SalesForceTerritoryController(ISalesForceTerritory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesForceTerritoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesForceTerritoryAll()
        {
            try
            {
                var dt = await _Context.GetSalesForceTerritoryAll();
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
        [Route("GetSalesForceTerritoryById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetSalesForceTerritoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetSalesForceTerritoryById(Id);
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
        [Route("GetSalesForceTerritoryByUnitId")]
        [SwaggerOperation(Description = "Example { SalesForceTerritoryByUnitId: 0 }")]
        public async Task<IActionResult> GetSalesForceTerritoryByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSalesForceTerritoryByUnitId(UId);
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
        [Route("GetSalesForceTerritoryByClientId")]
        [SwaggerOperation(Description = "Example { SalesForceTerritoryByClientId: 0 }")]
        public async Task<IActionResult> GetSalesForceTerritoryByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetSalesForceTerritoryByClientId(CId);
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
        [Route("CreateSalesForceTerritory")]
        [SwaggerOperation(Description = "Example {  BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateSalesForceTerritory(CreateSalesForceTerritoryDTO postSalesForceTerritory)
        {
            try
            {
                var dt = await _Context.CreateSalesForceTerritory(postSalesForceTerritory);
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
        [Route("EditSalesForceTerritory")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditSalesForceTerritory([FromBody] EditSalesForceTerritoryDTO SalesForceTerritory)
        {
            try
            {
                var dt = await _Context.EditSalesForceTerritory(SalesForceTerritory);
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
        [Route("CancelSalesForceTerritory")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelSalesForceTerritory([FromBody] CancelSalesForceTerritoryDTO SalesForceTerritory)
        {
            try
            {
                var dt = await _Context.CancelSalesForceTerritory(SalesForceTerritory);
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