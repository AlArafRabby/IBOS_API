using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUnitController : ControllerBase
    {        
        private readonly IBusinessUnit _Context;
        public BusinessUnitController(IBusinessUnit context)
        {
            _Context = context;
        }
                
        [HttpGet]
        [Route("GetBusinessUnitAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessUnitAll()
        {
            try
            {
                var dt = await _Context.GetBusinessUnitAll();
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
        [Route("GetBusinessUnitById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetBusinessUnitById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitById(Id);
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
        [Route("GetBusinessUnitByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessUnitByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitByClientId(CId);
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
        [Route("CreateBusinessUnit")]
        [SwaggerOperation(Description = "Example { code: string, name: string, address: string, clientId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessUnit(DTO.CreateBusinessUnitDTO postBusinessUnit)
        {
            try
            {
                var dt = await _Context.CreateBusinessUnit(postBusinessUnit);
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
        [Route("EditBusinessUnit")]
        [SwaggerOperation(Description = "Example { id: 0, clintId: 0, name: string, address: string, actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessUnit([FromBody] EditBusinessUnitDTO businessUnit)
        {
            try
            {
                var dt = await _Context.EditBusinessUnit(businessUnit);
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
        [Route("CancelBusinessUnit")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessUnit([FromBody] CancelBusinessUnitDTO businessUnit)
        {
            try
            {
                var dt = await _Context.CancelBusinessUnit(businessUnit);
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