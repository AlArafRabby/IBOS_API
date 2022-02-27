using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Country;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountry _Context;
        public CountryController(ICountry context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetCountryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetCountryAll()
        {
            try
            {
                var dt = await _Context.GetCountryAll();
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
        [Route("GetCountryId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetCountryId(long Id)
        {
            try
            {
                var dt = await _Context.GetCountryId(Id);
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
        [Route("GetCountryByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetCountryByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetCountryByClientId(CId);
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
        [Route("CreateCountry")]
        [SwaggerOperation(Description = "Example { id: 0,CountryCode: string, CountryName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateCountry(CreateCountryDTO postCountry)
        {
            try
            {
                var dt = await _Context.CreateCountry(postCountry);
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
        [Route("EditCountry")]
        [SwaggerOperation(Description = "Example { id: 0, CountryCode: string, CountryName: string, actionBy: 0 }")]
        public async Task<IActionResult> EditCountry([FromBody] EditCountryDTO Country)
        {
            try
            {
                var dt = await _Context.EditCountry(Country);
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
        [Route("CancelCountry")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelCountry([FromBody] CancelCountryDTO Country)
        {
            try
            {
                var dt = await _Context.CancelCountry(Country);
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