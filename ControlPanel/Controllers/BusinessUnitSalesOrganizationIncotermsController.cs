using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessUnitSalesOrganizationIncoterms;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUnitSalesOrganizationIncotermsController : ControllerBase
    {
        private readonly IBusinessUnitSalesOrganizationIncoterms _Context;
        public BusinessUnitSalesOrganizationIncotermsController(IBusinessUnitSalesOrganizationIncoterms context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessUnitSalesOrganizationIncotermsAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessUnitSalesOrganizationIncotermsAll()
        {
            try
            {
                var dt = await _Context.GetBusinessUnitSalesOrganizationIncotermsAll();
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
        [Route("GetBusinessUnitSalesOrganizationIncotermsById")]
        [SwaggerOperation(Description = "Example { BusinessUnitSalesOrganizationIncotermsid: 0 }")]
        public async Task<IActionResult> GetBusinessUnitSalesOrganizationIncotermsById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitSalesOrganizationIncotermsById(Id);
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
        [Route("GetBusinessUnitSalesOrganizationIncotermsByClientId")]
        [SwaggerOperation(Description = "Example { BusinessUnitSalesOrganizationIncotermsByClientId: 0 }")]
        public async Task<IActionResult> GetBusinessUnitSalesOrganizationIncotermsByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitSalesOrganizationIncotermsByClientId(CId);
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
        [Route("BusinessUnitSalesOrganizationIncotermsByUnitId")]
        [SwaggerOperation(Description = "Example { BusinessUnitSalesOrganizationIncotermsByUnitId: 0 }")]
        public async Task<IActionResult> BusinessUnitSalesOrganizationIncotermsByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitSalesOrganizationIncotermsByClientId(UId);
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
        [Route("CreateBusinessUnitSalesOrganizationIncoterms")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId : 0, BusinessUnitId : 0, BusinessUnitName : String, IncotermsId: 0, IncotermsName: String, SalesOrganizationId: 0, SalesOrganizationName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessUnitSalesOrganizationIncoterms(DTO.BusinessUnitSalesOrganizationIncoterms.CreateBusinessUnitSalesOrganizationIncotermsDTO postBusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                var dt = await _Context.CreateBusinessUnitSalesOrganizationIncoterms(postBusinessUnitSalesOrganizationIncoterms);
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
        [Route("EditBusinessUnitSalesOrganizationIncoterms")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId : 0, BusinessUnitId : 0, BusinessUnitName : String, IncotermsId: 0, IncotermsName: String, SalesOrganizationId: 0, SalesOrganizationName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessUnitSalesOrganizationIncoterms([FromBody] EditBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                var dt = await _Context.EditBusinessUnitSalesOrganizationIncoterms(BusinessUnitSalesOrganizationIncoterms);
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
        [Route("CancelBusinessUnitSalesOrganizationIncoterms")]
        [SwaggerOperation(Description = "Example { Id: 0, actionBy: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z}")]
        public async Task<IActionResult> CancelBusinessUnitSalesOrganizationIncoterms([FromBody] CancelBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                var dt = await _Context.CancelBusinessUnitSalesOrganizationIncoterms(BusinessUnitSalesOrganizationIncoterms);
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