using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.BusinessPartner;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerController : ControllerBase
    {
        private readonly IBusinessPartner _Context;
        public BusinessPartnerController(IBusinessPartner context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerAll();
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
        [Route("GetBusinessPartnerId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerId(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerId(Id);
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
        [Route("GetBusinessPartnerByClientId")]
        [SwaggerOperation(Description = "Example { Client id: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerByClientId(CId);
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
        [Route("CreateBusinessPartner")]
        [SwaggerOperation(Description = "Example { id: 0,BusinessPartnerCode: string, BusinessPartnerName: string, BusinessPartnerAddress: string, ContactNumber: 0, Email: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartner(DTO.CreateBusinessPartnerDTO postBusinessPartner)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartner(postBusinessPartner);
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
        [Route("EditBusinessPartner")]
        [SwaggerOperation(Description = "Example { id: 0, BusinessPartnerName: string, BusinessPartnerAddress: string, ContactNumber: 0, Email: string, actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessPartner([FromBody] EditBusinessPartnerDTO businesspartner)
        {
            try
            {
                var dt = await _Context.EditBusinessPartner(businesspartner);
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
        [Route("CancelBusinessPartner")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartner([FromBody] CancelBusinessPartnerDTO businesspartner)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartner(businesspartner);
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