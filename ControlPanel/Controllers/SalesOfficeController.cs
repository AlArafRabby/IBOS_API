using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SalesOffice;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOfficeController : ControllerBase
    {
        private readonly ISalesOffice _Context;
        public SalesOfficeController(ISalesOffice context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSalesOfficeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSalesOfficeAll()
        {
            try
            {
                var dt = await _Context.GetSalesOfficeAll();
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
        [Route("GetSalesOfficeById")]
        [SwaggerOperation(Description = "Example { SalesOfficeid: 0 }")]
        public async Task<IActionResult> GetSalesOfficeById(long Id)
        {
            try
            {
                var dt = await _Context.GetSalesOfficeById(Id);
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
        [Route("GetSalesOfficeByClientId")]
        [SwaggerOperation(Description = "Example { SalesOfficeByClientId: 0 }")]
        public async Task<IActionResult> GetSalesOfficeByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetSalesOfficeByClientId(CId);
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
        [Route("SalesOfficeByUnitId")]
        [SwaggerOperation(Description = "Example { SalesOfficeByUnitId: 0 }")]
        public async Task<IActionResult> SalesOfficeByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSalesOfficeByClientId(UId);
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
        [Route("CreateSalesOffice")]
        [SwaggerOperation(Description = "Example { id= 0, SalesOfficeName : string, ClientId : 0, BusinessUnitId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateSalesOffice(DTO.SalesOffice.CreateSalesOfficeDTO postSalesOffice)
        {
            try
            {
                var dt = await _Context.CreateSalesOffice(postSalesOffice);
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
        [Route("EditSalesOffice")]
        [SwaggerOperation(Description = "Example { id= 0, SalesOfficeName : string, ClientId : 0, BusinessUnitId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditSalesOffice([FromBody] EditSalesOfficeDTO SalesOffice)
        {
            try
            {
                var dt = await _Context.EditSalesOffice(SalesOffice);
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
        [Route("CancelSalesOffice")]
        [SwaggerOperation(Description = "Example { SalesOfficeid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelSalesOffice([FromBody] CancelSalesOfficeDTO SalesOffice)
        {
            try
            {
                var dt = await _Context.CancelSalesOffice(SalesOffice);
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