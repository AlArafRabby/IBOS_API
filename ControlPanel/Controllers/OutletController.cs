using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Outlet;
using ControlPanel.IRepository;
using ControlPanel.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private readonly IOutlet _Context;
        public OutletController(IOutlet context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetOutletAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetOutletAll()
        {
            try
            {
                var dt = await _Context.GetOutletAll();
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
        [Route("GetOutletById")]
        [SwaggerOperation(Description = "Example { Outletid: 0 }")]
        public async Task<IActionResult> GetOutletById(long Id)
        {
            try
            {
                var dt = await _Context.GetOutletById(Id);
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
        [Route("GetOutletByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetOutletByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetOutletByClientId(cId);
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
        [Route("CreateOutlet")]
        [SwaggerOperation(Description = "Example {clientid=0, Outletcode: string, Outletname: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateOutlet(CreateOutletDTO postOutlet)
        {
            try
            {
                var dt = await _Context.CreateOutlet(postOutlet);
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
        [Route("EditOutlet")]
        [SwaggerOperation(Description = "Example { Outletid: 0, Outletname: string,  dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditOutlet([FromBody] EditOutletDTO outlet)
        {
            try
            {
                var dt = await _Context.EditOutlet(outlet);
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
        [Route("CancelOutlet")]
        [SwaggerOperation(Description = "Example { Outletid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelOutlet([FromBody] CancelOutletDTO outlet)
        {
            try
            {
                var dt = await _Context.CancelOutlet(outlet);
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