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
    public class ItemSalesController : ControllerBase
    {
        private readonly IItemSales _Context;
        public ItemSalesController(IItemSales context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemSalesAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemSalesAll()
        {
            try
            {
                var dt = await _Context.GetItemSalesAll();
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
        [Route("GetItemSalesById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetItemSalesById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemSalesById(Id);
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
        [Route("GetItemSalesByUnitId")]
        [SwaggerOperation(Description = "Example { UId: 0 }")]
        public async Task<IActionResult> GetItemSalesByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetItemSalesByUnitId(UId);
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
        [Route("GetItemSalesByClientId")]
        [SwaggerOperation(Description = "Example { CId: 0 }")]
        public async Task<IActionResult> GetItemSalesByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemSalesByClientId(cId);
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
        [Route("CreateItemSales")]
        [SwaggerOperation(Description = "Example { clientid=0,Code: 0, ItemCategoryName: string, BusinessUnitId: 0,ProfitCenterId:0,ItemTypeId: 0, ActionBy: 0,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemSales(DTO.ItemSales.CreateItemSalesDTO postItemSales)
        {
            try
            {
                var dt = await _Context.CreateItemSales(postItemSales);
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
        [Route("EditteItemSales")]
        [SwaggerOperation(Description = "Example { Code: 0, ItemCategoryName: string, BusinessUnitId: 0,ProfitCenterId=0, ItemTypeId: 0, ActionBy: 0,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditteItemSales([FromBody] DTO.ItemSales.EditItemSalesDTO item)
        {
            try
            {
                var dt = await _Context.EditteItemSales(item);
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
        [Route("CancelteItemSales")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelteItemSales([FromBody] DTO.ItemSales.CancelItemSalesDTO ItemSales)
        {
            try
            {
                var dt = await _Context.CancelteItemSales(ItemSales);
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