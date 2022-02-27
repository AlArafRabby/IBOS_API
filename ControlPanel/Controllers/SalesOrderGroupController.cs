using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesOrderGroup;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderGroupController : ControllerBase
    {
        private readonly ISalesOrderGroup _Context;
        public SalesOrderGroupController(ISalesOrderGroup context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesOrderGroupAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesOrderGroupAll()
        {
            try
            {
                var dt = await _Context.GetSalesOrderGroupAll();
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