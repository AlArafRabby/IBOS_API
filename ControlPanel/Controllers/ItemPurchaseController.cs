using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPurchaseController : ControllerBase
    {
        private readonly IItemPurchase _Context;
        public ItemPurchaseController(IItemPurchase context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemPurchaseAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemPurchaseAll()
        {
            try
            {
                var dt = await _Context.getItemPurchaseAll();
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
        [Route("GetItemPurchaseById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemPurchaseById(long Id)
        {
            try
            {
                var dt = await _Context.getItemPurchasebyId(Id);
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
        [Route("getItemPurchasebyClientId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> getItemPurchasebyClientId(long cId)
        {
            try
            {
                var dt = await _Context.getItemPurchasebyClientId(cId);
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
        [Route("getItemPurchasebybusinsessunit")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> getItemPurchasebybusinsessunit(long UId)
        {
            try
            {
                var dt = await _Context.getItemPurchasebybusinsessunit(UId);
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
        [Route("CreateItemPurchase")]
        [SwaggerOperation(Description = "Example {clientid=0,  BusinessUnitId=0,PlantId=0,PurchaseOrganizationId=0,ItemId=0,PurchaseDescription=string,Hscode=string,MaxLeadDays=0,MinLeadDays=0,MinOrderQuantity=0,LotSize=0,ActionBy=0,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemPurchase(DTO.ItemPurchase.CreateItemPurchaseDTO ItemPurchase)
        {
            try
            {
                var dt = await _Context.CreateItemPurchase(ItemPurchase);
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
        [Route("EditItemPurchase")]
        [SwaggerOperation(Description = "Example { Id=0,BusinessUnitId=0,PlantId=0,PurchaseOrganizationId=0,ItemId=0,PurchaseDescription=string,Hscode=string,MaxLeadDays=0,MinLeadDays=0,MinOrderQuantity=0,LotSize=0,ActionBy=0 }}")]
        public async Task<IActionResult> EditItemPurchase([FromBody] DTO.ItemPurchase.EidtItemPurchaseDTO Itempurchase)
        {
            try
            {
                var dt = await _Context.EditItemPurchase(Itempurchase);
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
        [Route("CancelItemPurchase")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemPurchase([FromBody] DTO.ItemPurchase.CancelItemPurchaseDTO Itempurchase)
        {
            try
            {
                var dt = await _Context.CancelItemPurchase(Itempurchase);
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