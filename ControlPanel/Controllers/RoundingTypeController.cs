using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.RoundingType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundingTypeController : ControllerBase
    {
        private readonly IRoundingType _Context;
        public RoundingTypeController(IRoundingType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetRoundingTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetRoundingTypeAll()
        {
            try
            {
                var dt = await _Context.GetRoundingTypeAll();
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
        [Route("GetRoundingTypeById")]
        [SwaggerOperation(Description = "Example { RoundingTypeid: 0 }")]
        public async Task<IActionResult> GetRoundingTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetRoundingTypeById(Id);
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