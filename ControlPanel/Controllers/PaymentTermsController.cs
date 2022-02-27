using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.PaymentTerms;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTermsController : ControllerBase
    {
        private readonly IPaymentTerms _Context;
        public PaymentTermsController(IPaymentTerms context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetPaymentTermsAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetPaymentTermsAll()
        {
            try
            {
                var dt = await _Context.GetPaymentTermsAll();
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