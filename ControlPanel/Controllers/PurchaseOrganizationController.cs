using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.PurchaseOrganization;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrganizationController : ControllerBase
    {
        private readonly IPurchaseOrganization _Context;
        public PurchaseOrganizationController(IPurchaseOrganization context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPurchaseOrganizationAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetPurchaseOrganizationAll()
        {
            try
            {
                var dt = await _Context.GetPurchaseOrganizationAll();
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
        [Route("GetPurchaseOrganizationById")]
        [SwaggerOperation(Description = "Example { PurchaseOrganizationid: 0 }")]
        public async Task<IActionResult> GetPurchaseOrganizationById(long Id)
        {
            try
            {
                var dt = await _Context.GetPurchaseOrganizationById(Id);
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
        [Route("GetPurchaseOrganizationByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetPurchaseOrganizationByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetPurchaseOrganizationByClientId(CId);
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