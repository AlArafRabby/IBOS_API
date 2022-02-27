using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItem _Context;
        public ItemController(IItem context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetIItemAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetIItemAll()
        {
            try
            {
                var dt = await _Context.GetIItemAll();
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
        [Route("GetIItemById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetIItemById(long Id)
        {
            try
            {
                var dt = await _Context.GetIItemById(Id);
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
        [Route("GetIItemByClientId")]
        [SwaggerOperation(Description = "Example { ClientId: 0 }")]
        public async Task<IActionResult> GetIItemByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetIItemByClientId(CId);
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
        [Route("GetIItemByUnitId")]
        [SwaggerOperation(Description = "Example { UnitId: 0 }")]
        public async Task<IActionResult> GetIItemByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetIItemByUnitId(UId);
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
        [Route("CreateIItem")]
        [SwaggerOperation(Description = "Example { clientid=0,BusinessUnitId: 0, ItemMasterId: 0, ItemCode: string, ItemName: string, ItemTypeId: 0,ItemTypeName:string,ItemCategoryId: 0,ItemCategoryName:string,ItemSubCategoryId:0,ItemSubCategoryName:string,Uomid:0,Uomname:string,GrossWeightKg:0,NetWeightKg:0,ActionBy:0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateIItem(DTO.CreateItemDTO postItem)
        {
            try
            {
                var dt = await _Context.CreateIItem(postItem);
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
        [Route("EditIItem")]
        [SwaggerOperation(Description = "Example { id: 0, clintId: 0, name: string, address: string, actionBy: 0 }")]
        public async Task<IActionResult> EditIItem([FromBody] EditItemDTO item)
        {
            try
            {
                var dt = await _Context.EditIItem(item);
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
        [Route("CancelIItem")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelIItem([FromBody] CancelItemDTO items)
        {
            try
            {
                var dt = await _Context.CancelIItem(items);
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