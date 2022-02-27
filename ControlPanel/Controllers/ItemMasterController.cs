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
    public class ItemMasterController : ControllerBase
    {
        private readonly IItemMaster _Context;
        public ItemMasterController(IItemMaster context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetItemMasteryAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetItemMasteryAll()
        {
            try
            {
                var dt = await _Context.GetItemMasteryAll();
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
        [Route("GetItemMasterById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemMasterById(long Id)
        {
            try
            {
                var dt = await _Context.GetItemMasterById(Id);
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
        [Route("GetItemMasterByClientId")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetItemMasterByClientId(long cId)
        {
            try
            {
                var dt = await _Context.GetItemMasterByClientId(cId);
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
        [Route("CreateItemMaster")]
        [SwaggerOperation(Description = "Example { clientid=0, ItemMasterName: string, ActionBy: 0,LastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateItemMaster(DTO.ItemMaster.CreateItemMasterDTO postItemMaster)
        {
            try
            {
                var dt = await _Context.CreateItemMaster(postItemMaster);
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
        [Route("EditItemMaster")]
        [SwaggerOperation(Description = "Example { Id: 0, ItemMasterName:String, ActionBy: 0, LastActionDateTime: : 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditItemMaster([FromBody] DTO.ItemMaster.EditItemMasterDTO Itemmaster)
        {
            try
            {
                var dt = await _Context.EditItemMaster(Itemmaster);
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
        [Route("CancelItemMaster")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelItemMaster([FromBody] DTO.ItemMaster.CancelItemMasterDTO ItemMaster)
        {
            try
            {
                var dt = await _Context.CancelItemMaster(ItemMaster);
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