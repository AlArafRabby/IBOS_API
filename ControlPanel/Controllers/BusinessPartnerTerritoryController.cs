using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerTerritory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerTerritoryController : ControllerBase
    {
        private readonly IBusinessPartnerTerritory _Context;
        public BusinessPartnerTerritoryController(IBusinessPartnerTerritory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerTerritoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerTerritoryAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerTerritoryAll();
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
        [Route("GetBusinessPartnerTerritoryById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerTerritoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerTerritoryById(Id);
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
        [Route("GetBusinessPartnerTerritoryByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerTerritoryByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerTerritoryByClientId(CId);
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
        [Route("CreateBusinessPartnerTerritory")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0,  TerritoryId: 0, BusinessPartnerId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerTerritory(CreateBusinessPartnerTerritoryDTO postBusinessPartnerTerritory)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerTerritory(postBusinessPartnerTerritory);
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
        [Route("EditBusinessPartnerTerritory")]
        [SwaggerOperation(Description = "Example { ConfigId: 0, BusinessUnitId: 0,  TerritoryId: 0, BusinessPartnerId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessPartnerTerritory([FromBody] EditBusinessPartnerTerritoryDTO BusinessPartnerTerritory)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerTerritory(BusinessPartnerTerritory);
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
        [Route("CancelBusinessPartnerTerritory")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerTerritory([FromBody] CancelBusinessPartnerTerritoryDTO BusinessPartnerTerritory)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerTerritory(BusinessPartnerTerritory);
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