using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.SoldToPartnerShipToPartner;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldToPartnerShipToPartnerController : ControllerBase
    {
        private readonly ISoldToPartnerShipToPartner _Context;
        public SoldToPartnerShipToPartnerController(ISoldToPartnerShipToPartner context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetSoldToPartnerShipToPartnerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetSoldToPartnerShipToPartnerAll()
        {
            try
            {
                var dt = await _Context.GetSoldToPartnerShipToPartnerAll();
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
        [Route("GetSoldToPartnerShipToPartnerById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetSoldToPartnerShipToPartnerById(long Id)
        {
            try
            {
                var dt = await _Context.GetSoldToPartnerShipToPartnerById(Id);
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
        [Route("GetSoldToPartnerShipToPartnerByUnitId")]
        [SwaggerOperation(Description = "Example { SoldToPartnerShipToPartnerByUnitId: 0 }")]
        public async Task<IActionResult> GetSoldToPartnerShipToPartnerByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetSoldToPartnerShipToPartnerByUnitId(UId);
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
        [Route("GetSoldToPartnerShipToPartnerByClientId")]
        [SwaggerOperation(Description = "Example { SoldToPartnerShipToPartnerByClientId: 0 }")]
        public async Task<IActionResult> GetSoldToPartnerShipToPartnerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetSoldToPartnerShipToPartnerByClientId(CId);
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
        [Route("CreateSoldToPartnerShipToPartner")]
        [SwaggerOperation(Description = "Example {  BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateSoldToPartnerShipToPartner(CreateSoldToPartnerShipToPartnerDTO postSoldToPartnerShipToPartner)
        {
            try
            {
                var dt = await _Context.CreateSoldToPartnerShipToPartner(postSoldToPartnerShipToPartner);
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
        [Route("EditSoldToPartnerShipToPartner")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, TerritoryId: 0, EmployeeId: 0, YsnManager: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditSoldToPartnerShipToPartner([FromBody] EditSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner)
        {
            try
            {
                var dt = await _Context.EditSoldToPartnerShipToPartner(SoldToPartnerShipToPartner);
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
        [Route("CancelSoldToPartnerShipToPartner")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelSoldToPartnerShipToPartner([FromBody] CancelSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner)
        {
            try
            {
                var dt = await _Context.CancelSoldToPartnerShipToPartner(SoldToPartnerShipToPartner);
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