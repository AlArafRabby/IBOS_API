using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessPartnerWarehouseSales;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerSalesController : ControllerBase
    {
        private readonly IBusinessPartnerSales _Context;
        public BusinessPartnerSalesController(IBusinessPartnerSales context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessPartnerSalesAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessPartnerSalesAll()
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerSalesAll();
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
        [Route("GetBusinessPartnerSalesById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerSalesById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerSalesById(Id);
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
        [Route("GetBusinessPartnerSalesByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessPartnerSalesByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBusinessPartnerSalesByClientId(CId);
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
        [Route("CreateBusinessPartnerSales")]
        [SwaggerOperation(Description = "Example { WarehouseId: 0,  BusinessPartnerId: 0, PlantId: 0, BusinessUnitId: 0, SalesOrganizationId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessPartnerSales(CreateBusinessPartnerSalesDTO postBusinessPartnerSales)
        {
            try
            {
                var dt = await _Context.CreateBusinessPartnerSales(postBusinessPartnerSales);
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
        [Route("EditBusinessPartnerSales")]
        [SwaggerOperation(Description = "Example { ConfigId: 0, WarehouseId: 0,  BusinessPartnerId: 0, PlantId: 0, BusinessUnitId: 0, SalesOrganizationId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditBusinessPartnerSales([FromBody] EditBusinessPartnerSalesDTO BusinessPartnerSales)
        {
            try
            {
                var dt = await _Context.EditBusinessPartnerSales(BusinessPartnerSales);
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
        [Route("CancelBusinessPartnerSales")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessPartnerSales([FromBody] CancelBusinessPartnerSalesDTO BusinessPartnerSales)
        {
            try
            {
                var dt = await _Context.CancelBusinessPartnerSales(BusinessPartnerSales);
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