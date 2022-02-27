using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerZone;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerZoneController : ControllerBase
    {
        private readonly IBusinessPartnerZone _Context;

        public BusinessPartnerZoneController(IBusinessPartnerZone _context)
        {
            _Context = _context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerZoneById")]
        [SwaggerOperation(Description = "Example { ConfigId: 0}")]
        public async Task<IActionResult> GetBusinessPartnerZoneById(long ConfigId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerZoneById(ConfigId);
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
        [Route("GetBusinessPartnerZoneByClientBusinessUnitId")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0}")]
        public async Task<IActionResult> GetBusinessPartnerZoneByClientBusinessUnitId(long ClientId, long BusinessUnitId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerZoneByClientBusinessUnitId(ClientId, BusinessUnitId);
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
        [Route("GetBusinessPartnerZoneByClientBusinessUnitPartnerId")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, BusinessPartnerId: 0}")]
        public async Task<IActionResult> GetBusinessPartnerZoneByClientBusinessUnitPartnerId(long ClientId, long BusinessUnitId, long BusinessPartnerId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerZoneByClientBusinessUnitPartnerId(ClientId, BusinessUnitId, BusinessPartnerId);
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
        [Route("CreateBusinessPartnerZone")]
        [SwaggerOperation(Description = "Example { ClientId : 0, BusinessUnitId : 0, BusinessPartnerId : 0, TransportZoneId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerZone(CreateBusinessPartnerZoneDTO postBusinessPartnerZone)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerZone(postBusinessPartnerZone);
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
        [Route("EditBusinessPartnerZone")]
        [SwaggerOperation(Description = "Example { ConfigId= 0, ClientId : 0, BusinessUnitId : 0, BusinessPartnerId : 0, TransportZoneId : 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessPartnerZone([FromBody] EditBusinessPartnerZoneDTO putBusinessPartnerZone)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerZone(putBusinessPartnerZone);
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
        [Route("CancelBusinessPartnerZone")]
        [SwaggerOperation(Description = "Example { ConfigId= 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelShipPointWarehouse([FromBody] CancelBusinessPartnerZoneDTO BusinessPartnerZone)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerZone(BusinessPartnerZone);
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