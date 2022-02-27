using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Thana;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThanaController : ControllerBase
    {
        private readonly IThana _Context;
        public ThanaController(IThana context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetThanaAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetThanaAll()
        {
            try
            {
                var dt = await _Context.GetThanaAll();
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
        [Route("GetThanaById")]
        [SwaggerOperation(Description = "Example { Thanaid: 0 }")]
        public async Task<IActionResult> GetThanaById(long Id)
        {
            try
            {
                var dt = await _Context.GetThanaById(Id);
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