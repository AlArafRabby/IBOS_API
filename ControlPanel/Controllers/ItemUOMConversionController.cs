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
    public class ItemUOMConversionController : ControllerBase
    {
        private readonly IItemUOMConversion _Context;
        public ItemUOMConversionController(IItemUOMConversion context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemUOMConversionAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemUOMConversionAll()
        {
            try
            {
                var dt = await _Context.GetItemUOMConversionAll();
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
        [Route("GetItemUOMConversionById")]
        [SwaggerOperation(Description = "Example { Id: 0 }")]
        public async Task<IActionResult> GetItemUOMConversionById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemUOMConversionById(Id);
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
        [Route("GetItemUOMConversionByClientId")]
        [SwaggerOperation(Description = "Example { cId: 0 }")]
        public async Task<IActionResult> GetItemUOMConversionByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemUOMConversionByClientId(cId);
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
        [Route("CreateItemUOMConversion")]
        [SwaggerOperation(Description = "Example { clientid=0,BusinessUnitId: 0, ItemId: 0, BaseUom: 0, ConvertedUom: 0, ConversionRate: 0,ActionBy:0, LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemUOMConversion(DTO.IItemUOMConversion.CreateIItemUOMConversionDTO postIItemUOMConversion)
        {
            try
            {
                var dt = await _Context.CreateItemUOMConversion(postIItemUOMConversion);
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
        [Route("EditItemUOMConversion")]
        [SwaggerOperation(Description = "Example {Id=0, BusinessUnitId: 0, ItemId: 0, BaseUom: 0, ConvertedUom: 0, ConversionRate: 0,ActionBy=0 }")]
        public async Task<IActionResult> EditItemUOMConversion([FromBody] DTO.IItemUOMConversion.EidtIItemUOMConversionDTO putIItemUOMConversion)
        {
            try
            {
                var dt = await _Context.EditItemUOMConversion(putIItemUOMConversion);
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
        [Route("CancelItemUOMConversion")]
        [SwaggerOperation(Description = "Example { id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemUOMConversion([FromBody] DTO.IItemUOMConversion.CancelIItemUOMConversionDTO putIItemUOMConversion)
        {
            try
            {
                var dt = await _Context.CancelItemUOMConversion(putIItemUOMConversion);
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