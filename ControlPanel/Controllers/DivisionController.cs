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
    public class DivisionController : ControllerBase
    {
        private readonly IDivision _Context;
        public DivisionController(IDivision context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetDivisionAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDivisionAll()
        {
            try
            {
                var dt = await _Context.GetDivisionAll();
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
        [Route("GetDivisionByCountry")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDivisionByCountry(long CountryId)
        {
            try
            {
                var dt = await _Context.GetDivisionByCountry(CountryId);
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