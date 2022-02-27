using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesOrderType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderTypeController : ControllerBase
    {
        private readonly ISalesOrderType _Context;
        public SalesOrderTypeController(ISalesOrderType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesOrderTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesOrderTypeAll()
        {
            try
            {
                var dt = await _Context.GetSalesOrderTypeAll();
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
        [Route("GetSalesOrderTypeById")]
        [SwaggerOperation(Description = "Example { SalesOrderTypeid: 0 }")]
        public async Task<IActionResult> GetSalesOrderTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetSalesOrderTypeById(Id);
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
        [Route("GetSalesOrderTypeByUnitId")]
        [SwaggerOperation(Description = "Example { SalesOrderType Unit id: 0 }")]
        public async Task<IActionResult> GetSalesOrderTypeByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSalesOrderTypeByUnitId(UId);
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