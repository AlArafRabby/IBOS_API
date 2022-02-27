using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.AdjustmentJournalCommon;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdjustmentJournalCommonController : ControllerBase
    {
        private readonly IAdjustmentJournalCommon _Context;

        public AdjustmentJournalCommonController(IAdjustmentJournalCommon context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetAdjustmentJournalHeaderbyClientId")]
        [SwaggerOperation(Description = "Example { ClientId: 0, iscomplete: True/False }")]
        public async Task<IActionResult> GetAdjustmentJournalHeaderbyClientId(long ClientId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAdjustmentJournalHeaderbyClientId(ClientId, iscomplete);
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
        [Route("GetAdjustmentJournalHeaderbyBusinessUnitId")]
        [SwaggerOperation(Description = "Example { UnitId: 0, iscomplete: True/False }")]
        public async Task<IActionResult> GetAdjustmentJournalHeaderbyBusinessUnitId(long UnitId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAdjustmentJournalHeaderbyBusinessUnitId(UnitId, iscomplete);
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
        [Route("GetAdjustmentJournalHeaderByAreaId")]
        [SwaggerOperation(Description = "Example { AreaId: 0, iscomplete: True/False }")]
        public async Task<IActionResult> GetAdjustmentJournalHeaderByAreaId(long AreaId, bool iscomplete)
        {
            try
            {
                var dt = await _Context.GetAdjustmentJournalHeaderByAreaId(AreaId, iscomplete);
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
        [Route("GetAdjustmentJournalHeaderbyVoucherId")]
        [SwaggerOperation(Description = "Example { VoucherId: 0}")]
        public async Task<IActionResult> GetAdjustmentJournalHeaderbyVoucherId(long VoucherId)
        {
            try
            {
                var dt = await _Context.GetAdjustmentJournalHeaderbyVoucherId(VoucherId);
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
        [Route("GetAdjustmentJournalRowDetailsById")]
        [SwaggerOperation(Description = "Example { VoucherId: 0 }")]
        public async Task<IActionResult> GetAdjustmentJournalRowDetailsById(long VoucherId)
        {
            try
            {
                var dt = await _Context.GetAdjustmentJournalRowDetailsById(VoucherId);
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
        [Route("CreateAdjustmentJournalVoucher")]
        [SwaggerOperation(Description = "Example { JournalDate:2020-02-09 ,ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0,DebitAmount: 0, CreditAmount: 0,Narration: string,IsPosted: false,  AccountingJournalTypeId: 0,IsDirectPosting: true/False,actionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z , GeneralLedgerId: 0, GeneralLedgerName: string, Narration: string, Amount: 0 }")]
        public async Task<IActionResult> CreateAdjustmentJournalVoucher(CreateAdjustmentJournalCommonDTO postCreateAdjustmentJournalCommon)
        {
            try
            {
                var dt = await _Context.CreateAdjustmentJournalVoucher(postCreateAdjustmentJournalCommon);
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
        [Route("EditAdjustmentJournalVoucher")]
        [SwaggerOperation(Description = "Example { AdjustmentJournalId: 0, AdjustmentJournalCode: string,JournalDate:2020-02-09 ,ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0,DebitAmount: 0, CreditAmount: 0,Narration: string,IsPosted: false,  AccountingJournalTypeId: 0,IsDirectPosting: true/False,actionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z ,RowId: 0, AdjustmentJournalId: 0, AdjustmentJournalCode: string, GeneralLedgerId: 0, GeneralLedgerName: string, Narration: string, Amount: 0 }")]
        public async Task<IActionResult> EditAdjustmentJournalVoucher([FromBody] EditAdjustmentJournalCommonDTO AdjustmentJournalCommon)
        {
            try
            {
                var dt = await _Context.EditAdjustmentJournalVoucher(AdjustmentJournalCommon);
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
        [Route("CancelAdjustmentJournalVoucher")]
        [SwaggerOperation(Description = "Example {  AdjustmentJournalId: 0,AdjustmentJournalCode: string, ActionBy: 0}")]
        public async Task<IActionResult> CancelAdjustmentJournalVoucher([FromBody] CancelAdjustmentJournalHeaderDTO putAdjustmentJournalHeader)
        {
            try
            {
                var dt = await _Context.CancelAdjustmentJournalVoucher(putAdjustmentJournalHeader);
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
        [Route("CompleteAdjustmentJournalVoucher")]
        [SwaggerOperation(Description = "Example { AdjustmentJournalId: 0, AdjustmentJournalCode: string,JournalDate:2020-02-09 ,ClientId: 0, BusinessUnitId: 0, BusinessAreaId: 0,DebitAmount: 0, CreditAmount: 0,Narration: string,IsPosted: false,  AccountingJournalTypeId: 0,IsDirectPosting: true/False,actionBy: 0, LastActionDateTime: 2020-02-09T11:42:09.172Z ,RowId: 0, AdjustmentJournalId: 0, AdjustmentJournalCode: string, GeneralLedgerId: 0, GeneralLedgerName: string, Narration: string, Amount: 0 }")]
        public async Task<IActionResult> CompleteAdjustmentJournalVoucher([FromBody] EditAdjustmentJournalCommonDTO AdjustmentJournalCommon)
        {
            try
            {
                var dt = await _Context.CompleteAdjustmentJournalVoucher(AdjustmentJournalCommon);
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