using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceCheckTypeController : ControllerBase
    {
        private readonly IBalanceCheckType _Context;
        public BalanceCheckTypeController(IBalanceCheckType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAccountClassAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBalanceCheckTypeAll()
        {
            try
            {
                var dt = await _Context.GetBalanceCheckTypeAll();
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