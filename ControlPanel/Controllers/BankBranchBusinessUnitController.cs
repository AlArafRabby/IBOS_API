using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.BankBranchBusinessUnit;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankBranchBusinessUnitController : ControllerBase
    {
        private readonly IBankBranchBusinessUnit _Context;
        public BankBranchBusinessUnitController(IBankBranchBusinessUnit context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetBankBranchBusinessUnitAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetBankBranchBusinessUnitAll()
        {
            try
            {
                var dt = await _Context.GetBankBranchBusinessUnitAll();
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
        [Route("GetBankBranchBusinessUnitById")]
        [SwaggerOperation(Description = "Example { BankBranchBusinessUnitid: 0 }")]
        public async Task<IActionResult> GetBankBranchBusinessUnitById(long Id)
        {
            try
            {
                var dt = await _Context.GetBankBranchBusinessUnitById(Id);
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
        [Route("GetBankBranchBusinessUnitByUnitId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBankBranchBusinessUnitByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetBankBranchBusinessUnitByUnitId(UId);
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
        [Route("GetBankBranchBusinessUnitByClientId")]
        [SwaggerOperation(Description = "Example { Clientid: 0 }")]
        public async Task<IActionResult> GetBankBranchBusinessUnitByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetBankBranchBusinessUnitByClientId(CId);
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
        [Route("CreateBankBranchBusinessUnit")]
        [SwaggerOperation(Description = "Example { ClientId: 0, BusinessUnitId: 0,BusinessName: string, BankId: 0, BankName: string,BankBranchId:0, BankBranchName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateBankBranchBusinessUnit(CreateBankBranchBusinessUnitDTO postBankBranchBusinessUnit)
        {
            try
            {
                var dt = await _Context.CreateBankBranchBusinessUnit(postBankBranchBusinessUnit);
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
        [Route("EditBankBranchBusinessUnit")]
        [SwaggerOperation(Description = "Example { ConfigId: 0, ClientId: 0, BusinessUnitId: 0,BusinessName: string, BankId: 0, BankName: string,BankBranchId:0, BankBranchName: string, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z  }")]
        public async Task<IActionResult> EditBankBranchBusinessUnit([FromBody] EditBankBranchBusinessUnitDTO BankBranchBusinessUnit)
        {
            try
            {
                var dt = await _Context.EditBankBranchBusinessUnit(BankBranchBusinessUnit);
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
        [Route("CancelBankBranchBusinessUnit")]
        [SwaggerOperation(Description = "Example {  ConfigId: 0, actionBy: 0}")]
        public async Task<IActionResult> CancelBankBranchBusinessUnit([FromBody] CancelBankBranchBusinessUnitDTO BankBranchBusinessUnit)
        {
            try
            {
                var dt = await _Context.CancelBankBranchBusinessUnit(BankBranchBusinessUnit);
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