using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.District;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrict _Context;
        public DistrictController(IDistrict context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetDistrictAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDistrictAll()
        {
            try
            {
                var dt = await _Context.GetDistrictAll();
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
        [Route("GetDistrictId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetDistrictId(long Id)
        {
            try
            {
                var dt = await _Context.GetDistrictId(Id);
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
        [Route("GetDistrictByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetDistrictByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetDistrictByClientId(CId);
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
        [Route("CreateDistrict")]
        [SwaggerOperation(Description = "Example { id: 0, DistrictCode: string, DistrictName: string, IntCountryId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateDistrict(CreateDistrictDTO postDistrict)
        {
            try
            {
                var dt = await _Context.CreateDistrict(postDistrict);
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
        [Route("EditDistrict")]
        [SwaggerOperation(Description = "Example { id: 0, DistrictCode: string, DistrictName: string, IntCountryId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditDistrict([FromBody] EditDistrictDTO district)
        {
            try
            {
                var dt = await _Context.EditDistrict(district);
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
        [Route("CancelDistrict")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelDistrict([FromBody] CancelDistrictDTO district)
        {
            try
            {
                var dt = await _Context.CancelDistrict(district);
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