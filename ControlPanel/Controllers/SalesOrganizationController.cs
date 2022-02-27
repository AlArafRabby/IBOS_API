using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesOrganization;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrganizationController : ControllerBase
    {
        private readonly ISalesOrganization _Context;
        public SalesOrganizationController(ISalesOrganization context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesOrganizationAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesOrganizationAll()
        {
            try
            {
                var dt = await _Context.GetSalesOrganizationAll();
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
        [Route("GetSalesOrganizationById")]
        [SwaggerOperation(Description = "Example { SalesOrganizationid: 0 }")]
        public async Task<IActionResult> GetSalesOrganizationById(long Id)
        {
            try
            {
                var dt = await _Context.GetSalesOrganizationById(Id);
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
        [Route("GetSalesOrganizationByUnitId")]
        [SwaggerOperation(Description = "Example { SalesOrganizationByUnitId: 0 }")]
        public async Task<IActionResult> GetSalesOrganizationByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSalesOrganizationByUnitId(UId);
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
        [Route("GetSalesOrganizationByClientId")]
        [SwaggerOperation(Description = "Example { SalesOrganizationByClientId: 0 }")]
        public async Task<IActionResult> GetSalesOrganizationByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetSalesOrganizationByUnitId(CId);
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
        [Route("CreateSalesOrganization")]
        [SwaggerOperation(Description = "Example { SalesOrganizationcode: string, SalesOrganizationname: string, bussinessUnitId: 0, bussinessAreaId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateSalesOrganization(DTO.SalesOrganization.CreateSalesOrganizationDTO postSalesOrganization)
        {
            try
            {
                var dt = await _Context.CreateSalesOrganization(postSalesOrganization);
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
        [Route("EditSalesOrganization")]
        [SwaggerOperation(Description = "Example { SalesOrganizationid: 0, SalesOrganizationname: string, bussinessUnitId: 0, bussinessAreaId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditSalesOrganization([FromBody] EditSalesOrganizationDTO SalesOrganization)
        {
            try
            {
                var dt = await _Context.EditSalesOrganization(SalesOrganization);
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
        [Route("CancelSalesOrganization")]
        [SwaggerOperation(Description = "Example { SalesOrganizationid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelSalesOrganization([FromBody] CancelSalesOrganizationDTO SalesOrganization)
        {
            try
            {
                var dt = await _Context.CancelSalesOrganization(SalesOrganization);
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