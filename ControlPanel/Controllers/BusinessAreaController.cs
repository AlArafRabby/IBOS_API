using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.BusinessArea;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessAreaController : ControllerBase
    {
        private readonly IBusinessArea _Context;
        public BusinessAreaController(IBusinessArea context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessAreaAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessAreaAll()
        {
            try
            {
                var dt = await _Context.GetBusinessAreaAll();
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
        [Route("GetBusinessAreaById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetBusinessAreaById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessAreaById(Id);
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
        [Route("GetBusinessAreaByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessAreaByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessAreaByClientId(CId);
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
        [Route("CreateBusinessArea")]
        [SwaggerOperation(Description = "Example { id: 0, BusinessUnitId: 0, BusinessAreaCode: string, BusinessAreaName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessArea(CreateBusinessAreaDTO postBusinessArea)
        {
            try
            {
                var dt = await _Context.CreateBusinessArea(postBusinessArea);
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
        [Route("EditBusinessArea")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId:0, BusinessUnitId: 0, BusinessAreaCode: string, BusinessAreaName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessArea([FromBody] EditBusinessAreaDTO BusinessArea)
        {
            try
            {
                var dt = await _Context.EditBusinessArea(BusinessArea);
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
        [Route("CancelBusinessArea")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessArea([FromBody] CancelBusinessAreaDTO BusinessArea)
        {
            try
            {
                var dt = await _Context.CancelBusinessArea(BusinessArea);
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