using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO;
using ControlPanel.DTO.ItemSubCategory;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IItemSubCategoryController : ControllerBase
    {
        private readonly IItemSubCategory _Context;
        public IItemSubCategoryController(IItemSubCategory context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemSubCategoryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemSubCategoryAll()
        {
            try
            {
                var dt = await _Context.GetItemSubCategoryAll();
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
        [Route("GetItemSubCategoryById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetItemSubCategoryById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemSubCategoryById(Id);
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
        [Route("GetItemSubCategoryByClientId")]
        [SwaggerOperation(Description = "Example { cId: 0 }")]
        public async Task<IActionResult> GetItemSubCategoryByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemSubCategoryByClientId(cId);
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
        [Route("CreateItemSubCategory")]
        [SwaggerOperation(Description = "Example { Code: string, ItemSubCategoryName:string, BusinessUnitId: 0, ItemTypeId: 0, ItemCategoryId: 0,ActionBy:0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemSubCategory(CreateItemSubCategoryDTO ItemSubCategory)
        {
            try
            {
                var dt = await _Context.CreateItemSubCategory(ItemSubCategory);
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
        [Route("EditItemSubCategory")]
        [SwaggerOperation(Description = "Example { id: 0, clintId: 0, name: string, address: string, actionBy: 0 }")]
        public async Task<IActionResult> EditItemSubCategory([FromBody] EditItemSubCategoryDTO item)
        {
            try
            {
                var dt = await _Context.EditItemSubCategory(item);
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
        [Route("CancelItemSubCategory")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemSubCategory([FromBody] CancelItemSubCategoryDTO items)
        {
            try
            {
                var dt = await _Context.CancelItemSubCategory(items);
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