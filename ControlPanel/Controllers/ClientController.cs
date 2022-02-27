using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Client;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClient _Context;
        public ClientController(IClient context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetClientAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetClientAll()
        {
            try
            {
                var dt = await _Context.GetClientAll();
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
        [Route("GetClientById")]
        [SwaggerOperation(Description = "Example { id: 0 }")]
        public async Task<IActionResult> GetClientById(long Id)
        {
            try
            {
                var dt = await _Context.GetClientById(Id);
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
        [Route("CreateClient")]
        [SwaggerOperation(Description = "Example { id: 0, ClientCode: string, ClientName: string, ClientAddress: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateClient(CreateClientDTO postClient)
        {
            try
            {
                var dt = await _Context.CreateClient(postClient);
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
        [Route("EditClient")]
        [SwaggerOperation(Description = "Example { id: 0, ClientCode: string, ClientName: string, ClientAddress: string, actionBy: 0 }")]
        public async Task<IActionResult> EditClient([FromBody] EditClientDTO Client)
        {
            try
            {
                var dt = await _Context.EditClient(Client);
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
        [Route("CancelClient")]
        [SwaggerOperation(Description = "Example {  id: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelClient([FromBody] CancelClientDTO Client)
        {
            try
            {
                var dt = await _Context.CancelClient(Client);
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