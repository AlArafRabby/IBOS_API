using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.OrderReferanceType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderReferanceTypeController : ControllerBase
    {
        private readonly IOrderReferanceType _Context;
        public OrderReferanceTypeController(IOrderReferanceType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetOrderReferanceTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetOrderReferanceTypeAll()
        {
            try
            {
                var dt = await _Context.GetOrderReferanceTypeAll();
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