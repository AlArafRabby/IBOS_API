using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO;
using ControlPanel.DTO.ItemAttribute;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemAttriuteController : ControllerBase
    {
        private readonly IItemAttribute _Context;
        public ItemAttriuteController(IItemAttribute context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemAttributeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemAttributeAll()
        {
            try
            {
                var dt = await _Context.GetItemAttributeAll();
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
        [Route("GetItemAttributeById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetItemAttributeById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemAttributeById(Id);
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
        [Route("GetItemAttributeByUnitId")]
        [SwaggerOperation(Description = "Example { ItemAttributeByUnitid: 0 }")]
        public async Task<IActionResult> GetItemAttributeByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetItemAttributeByUnitId(UId);
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
        [Route("GetItemAttributeByClientId")]
        [SwaggerOperation(Description = "Example { cid: 0 }")]
        public async Task<IActionResult> GetItemAttributeByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemAttributeByClientId(cId);
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
        [Route("CreateItemAttribute")]
        [SwaggerOperation(Description = "Example { ItemAttributeName: string, ItemAttributeUom: 0, BusinessUnitId: 0, ItemCategoryId: 0, ActionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemAttribute(DTO.CreateItemAttributeDTO postItemAttribute)
        {
            try
            {
                var dt = await _Context.CreateItemAttribute(postItemAttribute);
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
        [Route("EditItemAttribute")]
        [SwaggerOperation(Description = "Example { id: 0, clintId: 0, name: string, address: string, actionBy: 0 }")]
        public async Task<IActionResult> EditItemAttribute([FromBody] EditItemAttributeDTO item)
        {
            try
            {
                var dt = await _Context.EditItemAttribute(item);
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
        [Route("CancelItemAttribute")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemAttribute([FromBody] CancelItemAttributeDTO items)
        {
            try
            {
                var dt = await _Context.CancelItemAttribute(items);
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