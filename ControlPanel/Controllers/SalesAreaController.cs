using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesArea;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesAreaController : ControllerBase
    {
        private readonly ISalesArea _Context;
        public SalesAreaController(ISalesArea context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesAreaAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesAreaAll()
        {
            try
            {
                var dt = await _Context.GetSalesAreaAll();
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
        [Route("GetSalesAreaById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetSalesAreaById(long Id)
        {
            try
            {
                var dt = await _Context.GetSalesAreaById(Id);
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
        [Route("GetSalesAreaByUnitId")]
        [SwaggerOperation(Description = "Example { SalesAreaByUnitId: 0 }")]
        public async Task<IActionResult> GetSalesAreaByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSalesAreaByUnitId(UId);
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
        [Route("GetSalesAreaByClientId")]
        [SwaggerOperation(Description = "Example { SalesAreaByClientId: 0 }")]
        public async Task<IActionResult> GetSalesAreaByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetSalesAreaByClientId(CId);
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
        [Route("CreateSalesArea")]
        [SwaggerOperation(Description = "Example {  BusinessUnitId: 0, DistributionChannelId: 0, ProductDivisionId: 0, SalesOrganization: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateSalesArea(CreateSalesAreaDTO postSalesArea)
        {
            try
            {
                var dt = await _Context.CreateSalesArea(postSalesArea);
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
        [Route("EditSalesArea")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, DistributionChannelId: 0, ProductDivisionId: 0, SalesOrganization: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditSalesArea([FromBody] EditSalesAreaDTO SalesArea)
        {
            try
            {
                var dt = await _Context.EditSalesArea(SalesArea);
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
        [Route("CancelSalesArea")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelSalesArea([FromBody] CancelSalesAreaDTO SalesArea)
        {
            try
            {
                var dt = await _Context.CancelSalesArea(SalesArea);
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