using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemAttributeConfig;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemAttributeConfigController : ControllerBase
    {
        private readonly IItemAttributeConfig _Context;
        public ItemAttributeConfigController(IItemAttributeConfig context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemAttributeConfigAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemAttributeConfigAll()
        {
            try
            {
                var dt = await _Context.GetItemAttributeConfigAll();
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
        [Route("GetItemAttributeConfigById")]
        [SwaggerOperation(Description = "Example { Configid: 0 }")]
        public async Task<IActionResult> GetItemAttributeConfigById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemAttributeConfigById(Id);
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
        [Route("GetItemAttributeConfigByClient")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetItemAttributeConfigByClient(long cId)
        {
            try
            {
                var dt = await _Context.GetItemAttributeConfigByClient(cId);
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
        [Route("GetItemAttributeConfigByUnitId")]
        [SwaggerOperation(Description = "Example { Unitid: 0 }")]
        public async Task<IActionResult> GetItemAttributeConfigByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetItemAttributeConfigByUnitId(UId);
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
        [Route("CreateItemAttributeConfig")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, ItemId: 0, AttributeId: 0, AttributeName: string, AttributeUom: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemAttributeConfig(CreateItemAttributeConfigDTO postItemAttributeConfig)
        {
            try
            {
                var dt = await _Context.CreateItemAttributeConfig(postItemAttributeConfig);
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
        [Route("EditItemAttributeConfig")]
        [SwaggerOperation(Description = "Example { ConfigId: 0, BusinessUnitId: 0, ItemId: 0, AttributeId: 0, AttributeName: string, AttributeUom: string, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditItemAttributeConfig([FromBody] EditItemAttributeConfigDTO ItemAttributeConfig)
        {
            try
            {
                var dt = await _Context.EditItemAttributeConfig(ItemAttributeConfig);
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
        [Route("CancelItemAttributeConfig")]
        [SwaggerOperation(Description = "Example { Configid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelItemAttributeConfig([FromBody] CancelItemAttributeConfigDTO ItemAttributeConfig)
        {
            try
            {
                var dt = await _Context.CancelItemAttributeConfig(ItemAttributeConfig);
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