using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.PriceConditionTypeOrganization;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceConditionTypeOrganizationController : ControllerBase
    {
        private readonly IPriceConditionTypeOrganization _Context;
        public PriceConditionTypeOrganizationController(IPriceConditionTypeOrganization context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPriceConditionTypeOrganizationAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetPriceConditionTypeOrganizationAll()
        {
            try
            {
                var dt = await _Context.GetPriceConditionTypeOrganizationAll();
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
        [Route("GetPriceConditionTypeOrganizationById")]
        [SwaggerOperation(Description = "Example { PriceConditionTypeOrganizationid: 0 }")]
        public async Task<IActionResult> GetPriceConditionTypeOrganizationById(long Id)
        {
            try
            {
                var dt = await _Context.GetPriceConditionTypeOrganizationById(Id);
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