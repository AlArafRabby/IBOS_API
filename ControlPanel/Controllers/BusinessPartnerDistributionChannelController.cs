using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerDistributionChannel;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerDistributionChannelController : ControllerBase
    {
        private readonly IBusinessPartnerDistributionChannel _Context;
        public BusinessPartnerDistributionChannelController(IBusinessPartnerDistributionChannel context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerDistributionChannelAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerDistributionChannelAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerDistributionChannelAll();
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
        [Route("GetBusinessPartnerDistributionChannelById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerDistributionChannelById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerDistributionChannelById(Id);
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
        [Route("GetBusinessPartnerDistributionChannelByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerDistributionChannelByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerDistributionChannelByClientId(CId);
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
        [Route("CreateBusinessPartnerDistributionChannel")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, DistributionChannelId: 0, BusinessUnitId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerDistributionChannel(CreateBusinessPartnerDistributionChannelDTO postBusinessPartnerDistributionChannel)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerDistributionChannel(postBusinessPartnerDistributionChannel);
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
        [Route("EditBusinessPartnerDistributionChannel")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, DistributionChannelId: 0, BusinessUnitId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessPartnerDistributionChannel([FromBody] EditBusinessPartnerDistributionChannelDTO BusinessPartnerDistributionChannel)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerDistributionChannel(BusinessPartnerDistributionChannel);
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
        [Route("CancelBusinessPartnerDistributionChannel")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerDistributionChannel([FromBody] CancelBusinessPartnerDistributionChannelDTO BusinessPartnerDistributionChannel)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerDistributionChannel(BusinessPartnerDistributionChannel);
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