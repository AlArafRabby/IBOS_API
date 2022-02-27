using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerWarehousePurchase;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerPurchaseController : ControllerBase
    {
        private readonly IBusinessPartnerPurchase _Context;
        public BusinessPartnerPurchaseController(IBusinessPartnerPurchase context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerPurchaseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerPurchaseAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerPurchaseAll();
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
        [Route("GetBusinessPartnerPurchaseById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerPurchaseById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerPurchaseById(Id);
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
        [Route("GetBusinessPartnerPurchaseByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerPurchaseByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerPurchaseByClientId(CId);
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
        [Route("CreateBusinessPartnerPurchase")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, BusinessUnitId: 0, PurchaseOrganizationId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerPurchase(CreateBusinessPartnerPurchaseDTO postBusinessPartnerPurchase)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerPurchase(postBusinessPartnerPurchase);
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
        [Route("EditBusinessPartnerPurchase")]
        [SwaggerOperation(Description = "Example { ConfigId: 0, BusinessPartnerId: 0, BusinessUnitId: 0, PurchaseOrganizationId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessPartnerPurchase([FromBody] EditBusinessPartnerPurchaseDTO BusinessPartnerPurchase)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerPurchase(BusinessPartnerPurchase);
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
        [Route("CancelBusinessPartnerPurchase")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerPurchase([FromBody] CancelBusinessPartnerPurchaseDTO BusinessPartnerPurchase)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerPurchase(BusinessPartnerPurchase);
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
        [Route("LedgerBalanceUpdateDuringPartnerRecive")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, Ladger Amount: 0.0 }")]
        public async Task<IActionResult> LedgerBalanceUpdateDuringPartnerRecive(long pId, decimal amount)
        {
            try
            {
                var dt = await _Context.LedgerBalanceUpdateDuringPartnerRecive(pId, amount);
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
        [Route("UnbilledAmountUpdateDuringSalesOrder")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, Ladger Amount: 0.0 }")]
        public async Task<IActionResult> UnbilledAmountUpdateDuringSalesOrder(long pId, decimal SOamount)
        {
            try
            {
                var dt = await _Context.UnbilledAmountUpdateDuringSalesOrder(pId, SOamount);
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
        [Route("UnbilledAmountUpdateDuringPartnerBilling")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, Ladger Amount: 0.0 }")]
        public async Task<IActionResult> UnbilledAmountUpdateDuringPartnerBilling(long pId, decimal amount)
        {
            try
            {
                var dt = await _Context.UnbilledAmountUpdateDuringPartnerBilling(pId, amount);
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
        [Route("CreditLimitUpdateDuringPartnerCreaditLimit")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0, Ladger Amount: 0.0  }")]
        public async Task<IActionResult> CreditLimitUpdateDuringPartnerCreaditLimit(long pId, decimal amount)
        {
            try
            {
                var dt = await _Context.CreditLimitUpdateDuringPartnerCreaditLimit(pId, amount);
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
        [Route("GetAvailableBalance")]
        [SwaggerOperation(Description = "Example { BusinessPartnerId: 0 }")]
        public async Task<IActionResult> GetAvailableBalance(long pId)
        {
            try
            {
                var dt = await _Context.GetAvailableBalance(pId);
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