using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.DistributionChannel;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionChannelController : ControllerBase
    {
        private readonly IDistributionChannel _Context;
        public DistributionChannelController(IDistributionChannel context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetDistributionChannelAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetDistributionChannelAll()
        {
            try
            {
                var dt = await _Context.GetDistributionChannelAll();
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
        [Route("GetDistributionChannelById")]
        [SwaggerOperation(Description = "Example { distributionChannelid: 0 }")]
        public async Task<IActionResult> GetDistributionChannelById(long Id)
        {
            try
            {
                var dt = await _Context.GetDistributionChannelById(Id);
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
        [Route("GetDistributionChannelByUnitId")]
        [SwaggerOperation(Description = "Example { distributionUnitid: 0 }")]
        public async Task<IActionResult> GetDistributionChannelByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetDistributionChannelByUnitId(UId);
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
        [Route("GetDistributionChannelByAreaId")]
        [SwaggerOperation(Description = "Example { distributionAreaid: 0 }")]
        public async Task<IActionResult> GetDistributionChannelByAreaId(long AId)
        {
            try
            {
                var dt = await _Context.GetDistributionChannelByAreaId(AId);
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
        [Route("GetDistributionChannelByClientId")]
        [SwaggerOperation(Description = "Example { distributionClientid: 0 }")]
        public async Task<IActionResult> GetDistributionChannelByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetDistributionChannelByClientId(CId);
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
        [Route("CreateDistributionChannel")]
        [SwaggerOperation(Description = "Example { distributionChannelcode: string, distributionChannelname: string, bussinessUnitId: 0, bussinessAreaId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateDistributionChannel(DTO.DistributionChannel.CreateDistributionChannelDTO postDistributionChannel)
        {
            try
            {
                var dt = await _Context.CreateDistributionChannel(postDistributionChannel);
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
        [Route("EditDistributionChannel")]
        [SwaggerOperation(Description = "Example { distributionChannelid: 0, distributionChannelname: string, bussinessUnitId: 0, bussinessAreaId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditDistributionChannel([FromBody] EditDistributionChannelDTO distributionChannel)
        {
            try
            {
                var dt = await _Context.EditDistributionChannel(distributionChannel);
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
        [Route("CancelDistributionChannel")]
        [SwaggerOperation(Description = "Example { distributionChannelid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelDistributionChannel([FromBody] CancelDistributionChannelDTO distributionChannel)
        {
            try
            {
                var dt = await _Context.CancelDistributionChannel(distributionChannel);
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