using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.IncoTerms;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncotermsController : ControllerBase
    {
        private readonly IIncoterms _Context;
        public IncotermsController(IIncoterms context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetIncoTermsAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetIncotermsAll()
        {
            try
            {
                var dt = await _Context.GetIncoTermsAll();
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