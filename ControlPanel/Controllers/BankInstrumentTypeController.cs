using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BankInstrumentType;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankInstrumentTypeController : ControllerBase
    {
        private readonly IBankInstrumentType _Context;
        public BankInstrumentTypeController(IBankInstrumentType context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBankInstrumentTypeAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBankInstrumentTypeAll()
        {
            try
            {
                var dt = await _Context.GetBankInstrumentTypeAll();
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
        [Route("GetBankInstrumentTypeById")]
        [SwaggerOperation(Description = "Example { BankInstrumentTypeid: 0 }")]
        public async Task<IActionResult> GetBankInstrumentTypeById(long Id)
        {
            try
            {
                var dt = await _Context.GetBankInstrumentTypeById(Id);
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
        [Route("CreateBankInstrumentType")]
        [SwaggerOperation(Description = "Example { BankInstrumentTypeid: 0, InstrumentName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankInstrumentType(CreateBankInstrumentTypeDTO postBankInstrumentType)
        {
            try
            {
                var dt = await _Context.CreateBankInstrumentType(postBankInstrumentType);
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
        [Route("EditBankInstrumentType")]
        [SwaggerOperation(Description = "Example { BankInstrumentTypeid: 0, InstrumentName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> EditBankInstrumentType([FromBody] EditBankInstrumentTypeDTO BankInstrumentType)
        {
            try
            {
                var dt = await _Context.EditBankInstrumentType(BankInstrumentType);
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
        [Route("CancelBankInstrumentType")]
        [SwaggerOperation(Description = "Example {  BankInstrumentTypeid: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBankInstrumentType([FromBody] CancelBankInstrumentTypeDTO BankInstrumentType)
        {
            try
            {
                var dt = await _Context.CancelBankInstrumentType(BankInstrumentType);
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