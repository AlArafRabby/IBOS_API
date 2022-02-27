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
    public class ItemTypeController : ControllerBase
    {
        private readonly IItemType _Context;
        public ItemTypeController(IItemType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemTypeAll()
        {
            try
            {
                var dt = await _Context.GetItemTypeAll();
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
        [Route("GetItemTypeById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemTypeById(Id);
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
        [Route("GetItemTypeByClientId")]
        [SwaggerOperation(Description = "Example { Cid: 0 }")]
        public async Task<IActionResult> GetItemTypeByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemTypeByClientId(cId);
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
        [Route("GetItemTypeByBusinessUnitid")]
        [SwaggerOperation(Description = "Example { Businessid: 0 }")]
        public async Task<IActionResult> GetItemTypeByBusinessUnitid(long BusinessUnitid)
        {
            try
            {
                var dt = await _Context.GetItemTypeByBusinessUnitid(BusinessUnitid);
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
        [Route("CreateItemType")]
        [SwaggerOperation(Description = "Example { clientid=0, ItemTypeName: string, BusinessUnitId:0,ActionBy: 0,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemType(DTO.ItemType.CreateItemTypeDTO postItemType)
        {
            try
            {
                var dt = await _Context.CreateItemType(postItemType);
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
        [Route("EditItemType")]
        [SwaggerOperation(Description = "Example { ItemTypeName: string, ActionBy: 0 }}")]
        public async Task<IActionResult> EditItemType([FromBody] DTO.ItemType.EditItemTypeDTO ItemType)
        {
            try
            {
                var dt = await _Context.EditItemType(ItemType);
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
        [Route("CancelItemType")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemType([FromBody] DTO.ItemType.CancelItemTypeDTO ItemType)
        {
            try
            {
                var dt = await _Context.CancelItemType(ItemType);
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