using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerShipPoint;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerShipPointController : ControllerBase
    {
        private readonly IBusinessPartnerShipPoint _Context;
        public BusinessPartnerShipPointController(IBusinessPartnerShipPoint context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerShipPointAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerShipPointAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerShipPointAll();
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
        [Route("GetBusinessPartnerShipPointById")]
        [SwaggerOperation(Description = "Example { BusinessPartnerShipPointid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerShipPointById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerShipPointById(Id);
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
        [Route("GetBusinessPartnerShipPointByClientId")]
        [SwaggerOperation(Description = "Example { BusinessPartnerShipPointByClientId: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerShipPointByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerShipPointByClientId(CId);
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
        [Route("BusinessPartnerShipPointByUnitId")]
        [SwaggerOperation(Description = "Example { BusinessPartnerShipPointByUnitId: 0 }")]
        public async Task<IActionResult> BusinessPartnerShipPointByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerShipPointByClientId(UId);
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
        [Route("CreateBusinessPartnerShipPoint")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId : 0, BusinessUnitId : 0, BusinessPartnerId: 0, ShipPointId: 0, DistanceKm: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerShipPoint(DTO.BusinessPartnerShipPoint.CreateBusinessPartnerShipPointDTO postBusinessPartnerShipPoint)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerShipPoint(postBusinessPartnerShipPoint);
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
        [Route("EditBusinessPartnerShipPoint")]
        [SwaggerOperation(Description = "Example { id: 0, ClientId : 0, BusinessUnitId : 0, BusinessPartnerId: 0, ShipPointId: 0, DistanceKm: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessPartnerShipPoint([FromBody] EditBusinessPartnerShipPointDTO putBusinessPartnerShipPoint)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerShipPoint(putBusinessPartnerShipPoint);
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
        [Route("CancelBusinessPartnerShipPoint")]
        [SwaggerOperation(Description = "Example { Id: 0, actionBy: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z}")]
        public async Task<IActionResult> CancelBusinessPartnerShipPoint([FromBody] CancelBusinessPartnerShipPointDTO putBusinessPartnerShipPoint)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerShipPoint(putBusinessPartnerShipPoint);
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