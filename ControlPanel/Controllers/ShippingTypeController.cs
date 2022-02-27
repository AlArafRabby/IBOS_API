using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingTypeController : ControllerBase
    {
        private readonly IShippingType _Context;
        public ShippingTypeController(IShippingType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetShippingTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetShippingTypeAll()
        {
            try
            {
                var dt = await _Context.GetShippingTypeAll();
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
        [Route("GetShippingTypeById")]
        [SwaggerOperation(Description = "Example { ShippingTypeid: 0 }")]
        public async Task<IActionResult> GetShippingTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetShippingTypeById(Id);
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