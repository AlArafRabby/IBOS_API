using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BusinessUnitCurrency;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUnitCurrencyController : ControllerBase
    {
        private readonly IBusinessUnitCurrency _Context;
        public BusinessUnitCurrencyController(IBusinessUnitCurrency context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBusinessUnitCurrencyAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBusinessUnitCurrencyAll()
        {
            try
            {
                var dt = await _Context.GetBusinessUnitCurrencyAll();
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
        [Route("GetBusinessUnitCurrencyById")]
        [SwaggerOperation(Description = "Example { BusinessUnitCurrencyid: 0 }")]
        public async Task<IActionResult> GetBusinessUnitCurrencyById(long Id)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitCurrencyById(Id);
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
        [Route("GetBusinessUnitCurrencyByUnitId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBusinessUnitCurrencyByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBusinessUnitCurrencyByUnitId(UId);
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
        [Route("CreateBusinessUnitCurrency")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, CurrencyId: 0, BaseCurrency: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBusinessUnitCurrency(CreateBusinessUnitCurrencyDTO postBusinessUnitCurrency)
        {
            try
            {
                var dt = await _Context.CreateBusinessUnitCurrency(postBusinessUnitCurrency);
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
        [Route("EditBusinessUnitCurrency")]
        [SwaggerOperation(Description = "Example {id: 0, BusinessUnitId: 0, CurrencyId: 0, BaseCurrency: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBusinessUnitCurrency([FromBody] EditBusinessUnitCurrencyDTO BusinessUnitCurrency)
        {
            try
            {
                var dt = await _Context.EditBusinessUnitCurrency(BusinessUnitCurrency);
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
        [Route("CancelBusinessUnitCurrency")]
        [SwaggerOperation(Description = "Example {  ConfigId: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBusinessUnitCurrency([FromBody] CancelBusinessUnitCurrencyDTO BusinessUnitCurrency)
        {
            try
            {
                var dt = await _Context.CancelBusinessUnitCurrency(BusinessUnitCurrency);
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