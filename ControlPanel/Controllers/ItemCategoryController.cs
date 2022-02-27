using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemCategory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        private readonly IItemCategory _Context;
        public ItemCategoryController(IItemCategory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemCategoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemCategoryAll()
        {
            try
            {
                var dt = await _Context.GetItemCategoryAll();
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
        [Route("GetItemCategoryById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetItemCategoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemCategoryById(Id);
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
        [Route("GetItemCategoryByClientId")]
        [SwaggerOperation(Description = "Example { cId: 0 }")]
        public async Task<IActionResult> GetItemCategoryByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemCategoryByClientId(cId);
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
        [Route("GetItemCategoryByUnitId")]
        [SwaggerOperation(Description = "Example { UId: 0 }")]
        public async Task<IActionResult> GetItemCategoryByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetItemCategoryByUnitId(UId);
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
        [Route("CreateItemCategory")]
        [SwaggerOperation(Description = "Example { BusinessUnitId: 0, ItemMasterId: 0, ItemCode: string, ItemName: string, ItemTypeId: 0,ItemTypeName:string,ItemCategoryId: 0,ItemCategoryName:string,ItemSubCategoryId:0,ItemSubCategoryName:string,Uomid:0,Uomname:string,GrossWeightKg:0,NetWeightKg:0,ActionBy:0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemCategory(DTO.ItemCategory.CreateItemCategoryDTO postItemCategory)
        {
            try
            {
                var dt = await _Context.CreateItemCategory(postItemCategory);
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
        [Route("EditItemCategory")]
        [SwaggerOperation(Description = "Example { id: 0, clintId: 0, name: string, address: string, actionBy: 0 }")]
        public async Task<IActionResult> EditItemCategory([FromBody] EditItemCategoryDTO item)
        {
            try
            {
                var dt = await _Context.EditItemCategory(item);
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
        [Route("CancelItemCategory")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemCategory([FromBody] CancelItemCategoryDTO ItemCategory)
        {
            try
            {
                var dt = await _Context.CancelItemCategory(ItemCategory);
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