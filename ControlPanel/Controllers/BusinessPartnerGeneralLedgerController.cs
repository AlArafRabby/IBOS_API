using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerGeneralLedger;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerGeneralLedgerController : ControllerBase
    {
        private readonly IBusinessPartnerGeneralLedger _Context;
        public BusinessPartnerGeneralLedgerController(IBusinessPartnerGeneralLedger context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerGeneralLedgerAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerGeneralLedgerAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerGeneralLedgerAll();
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
        [Route("GetBusinessPartnerGeneralLedgerById")]
        [SwaggerOperation(Description = "Example { BusinessPartnerGeneralLedgerid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerGeneralLedgerById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerGeneralLedgerById(Id);
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
        [Route("GetBusinessPartnerGeneralLedgerByUnitId")]
        [SwaggerOperation(Description = "Example { UnitId: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerGeneralLedgerByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerGeneralLedgerByUnitId(UId);
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
        [Route("GetBusinessPartnerGeneralLedgerByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerGeneralLedgerByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerGeneralLedgerByClientId(CId);
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
        [Route("CreateBusinessPartnerGeneralLedger")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0, GeneralLedgerId: 0, BusinessPartnerId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerGeneralLedger(CreateBusinessPartnerGeneralLedgerDTO postBusinessPartnerGeneralLedger)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerGeneralLedger(postBusinessPartnerGeneralLedger);
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
        [Route("EditBusinessPartnerGeneralLedger")]
        [SwaggerOperation(Description = "Example {  ClientId: 0, BusinessUnitId: 0, GeneralLedgerId: 0, BusinessPartnerId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessPartnerGeneralLedger([FromBody] EditBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerGeneralLedger(BusinessPartnerGeneralLedger);
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
        [Route("CancelBusinessPartnerGeneralLedger")]
        [SwaggerOperation(Description = "Example {  BusinessPartnerGeneralLedgerid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerGeneralLedger([FromBody] CancelBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerGeneralLedger(BusinessPartnerGeneralLedger);
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