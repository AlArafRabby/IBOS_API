using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.DepreciationType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepreciationTypeController : ControllerBase
    {
        private readonly IDepreciationType _Context;
        public DepreciationTypeController(IDepreciationType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetDepreciationTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDepreciationTypeAll()
        {
            try
            {
                var dt = await _Context.GetDepreciationTypeAll();
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
        [Route("GetDepreciationTypeById")]
        [SwaggerOperation(Description = "Example { DepreciationTypeid: 0 }")]
        public async Task<IActionResult> GetDepreciationTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetDepreciationTypeById(Id);
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