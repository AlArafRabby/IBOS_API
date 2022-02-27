using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.Currency;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrency _Context;
        public CurrencyController(ICurrency context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetCurrencyAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetCurrencyAll()
        {
            try
            {
                var dt = await _Context.GetCurrencyAll();
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
        [Route("GetCurrencyById")]
        [SwaggerOperation(Description = "Example { Currencyid: 0 }")]
        public async Task<IActionResult> GetCurrencyById(long Id)
        {
            try
            {
                var dt = await _Context.GetCurrencyById(Id);
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