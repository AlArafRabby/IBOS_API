using ControlPanel.DbContexts;
using ControlPanel.DTO.AdjustmentJournalCommon;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AdjustmentJournalCommon : IAdjustmentJournalCommon
    {
        public readonly iBOSContext _context;

        public AdjustmentJournalCommon(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> GetAdjustmentJournalHeaderbyClientId(long ClientId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Adjustment Journal Header by Client Id",

                    data = await _context.TblAdjustmentJournalHeader.Where(x => x.IntClientId == ClientId && x.IsPosted == iscomplete).Select(t => new GetAdjustmentJournalHeaderDTO()
                                                  {
                                                      AdjustmentJournalId = t.IntAdjustmentJournalId,
                                                      AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                                                      DteJournalDate = t.DteJournalDate,
                                                      ClientId = t.IntClientId,
                                                      BusinessUnitId = t.IntBusinessUnitId,
                                                      BusinessAreaId = t.IntBusinessAreaId,
                                                      DebitAmount = t.NumDebitAmount,
                                                      CreditAmount = t.NumCreditAmount,
                                                      Narration = t.StrNarration,
                                                      IsPosted = t.IsPosted,
                                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                                      IsDirectPosting = t.IsDirectPosting,
                                                      ActionBy = t.IntActionBy,
                                                      DteLastActionDateTime = t.DteLastActionDateTime,
                                                      IsActive = t.IsActive
                                                  }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }


        public async Task<Message> GetAdjustmentJournalHeaderbyBusinessUnitId(long UnitId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Adjustment Journal Header by Business UnitId",
                    data = await _context.TblAdjustmentJournalHeader.Where(x => x.IntBusinessUnitId == UnitId && x.IsPosted == iscomplete).Select(t => new GetAdjustmentJournalHeaderDTO()
                    {
                        AdjustmentJournalId = t.IntAdjustmentJournalId,
                        AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                        DteJournalDate = t.DteJournalDate,
                        ClientId = t.IntClientId,
                        BusinessUnitId = t.IntBusinessUnitId,
                        BusinessAreaId = t.IntBusinessAreaId,
                        DebitAmount = t.NumDebitAmount,
                        CreditAmount = t.NumCreditAmount,
                        Narration = t.StrNarration,
                        IsPosted = t.IsPosted,
                        AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                        IsDirectPosting = t.IsDirectPosting,
                        ActionBy = t.IntActionBy,
                        DteLastActionDateTime = t.DteLastActionDateTime,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAdjustmentJournalHeaderByAreaId(long AreaId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Adjustment Journal Header By AreaId",
                    data = await _context.TblAdjustmentJournalHeader.Where(x => x.IntBusinessAreaId == AreaId && x.IsPosted == iscomplete).Select(t => new GetAdjustmentJournalHeaderDTO()
                    {
                        AdjustmentJournalId = t.IntAdjustmentJournalId,
                        AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                        DteJournalDate = t.DteJournalDate,
                        ClientId = t.IntClientId,
                        BusinessUnitId = t.IntBusinessUnitId,
                        BusinessAreaId = t.IntBusinessAreaId,
                        DebitAmount = t.NumDebitAmount,
                        CreditAmount = t.NumCreditAmount,
                        Narration = t.StrNarration,
                        IsPosted = t.IsPosted,
                        AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                        IsDirectPosting = t.IsDirectPosting,
                        ActionBy = t.IntActionBy,
                        DteLastActionDateTime = t.DteLastActionDateTime,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }


        public async Task<Message> GetAdjustmentJournalHeaderbyVoucherId(long VoucherId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Adjustment Journal Header by VoucherId",
                    data = await _context.TblAdjustmentJournalHeader.Where(x => x.IntAdjustmentJournalId == VoucherId && x.IsActive == true).Select(t => new GetAdjustmentJournalHeaderDTO()
                    {
                        AdjustmentJournalId = t.IntAdjustmentJournalId,
                        AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                        DteJournalDate = t.DteJournalDate,                       
                        ClientId = t.IntClientId,
                        BusinessUnitId = t.IntBusinessUnitId,
                        BusinessAreaId = t.IntBusinessAreaId,
                        DebitAmount = t.NumDebitAmount,
                        CreditAmount = t.NumCreditAmount,
                        Narration = t.StrNarration,
                        IsPosted = t.IsPosted,
                        AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                        IsDirectPosting = t.IsDirectPosting,
                        ActionBy = t.IntActionBy,
                        DteLastActionDateTime = t.DteLastActionDateTime,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAdjustmentJournalRowDetailsById(long VoucherId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Adjustment Journal RowDetails By Id",
                    data = await _context.TblAdjustmentJournalRow.Where(x => x.IntAdjustmentJournalId == VoucherId).Select(t => new GetAdjustmentJournalRowDTO()
                    {
                        RowId = t.IntRowId,
                        AdjustmentJournalId = t.IntAdjustmentJournalId,
                        AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                        GeneralLedgerId = t.IntGeneralLedgerId,
                        GeneralLedgerName = t.StrGeneralLedgerName,
                        Narration = t.StrNarration,
                        Amount = t.NumAmount
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<object> CancelAdjustmentJournalVoucher(CancelAdjustmentJournalHeaderDTO putAdjustmentJournalHeader)
        {
            try
            {
                TblAdjustmentJournalHeader data = _context.TblAdjustmentJournalHeader.First(x => x.IntAdjustmentJournalId == putAdjustmentJournalHeader.AdjustmentJournalId);

                data.IntActionBy = putAdjustmentJournalHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblAdjustmentJournalHeader.Update(data);
                await _context.SaveChangesAsync();
                
                var successmsg = new Message
                {
                    status = true,
                    message = "Adjustment Journal Voucher Cancelled Successfully.",
                    data = putAdjustmentJournalHeader
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> CompleteAdjustmentJournalVoucher(EditAdjustmentJournalCommonDTO putAdjustmentJournalCommon)
        {
            try
            {
                TblAdjustmentJournalHeader dataParent = _context.TblAdjustmentJournalHeader.First(x => x.IntAdjustmentJournalId == putAdjustmentJournalCommon.AdjustmentJournalHeader.AdjustmentJournalId && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsPosted == false
                    && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsDirectPosting == true && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsActive == true);

                dataParent.IsPosted = true;                
                dataParent.IntActionBy = putAdjustmentJournalCommon.AdjustmentJournalHeader.ActionBy;
                dataParent.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblAdjustmentJournalHeader.Update(dataParent);
                await _context.SaveChangesAsync();

                var successmsg = new
                {
                    status = true,
                    message = "Edited Successfully.",
                    data = dataParent
                };
                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> CreateAdjustmentJournalVoucher(CreateAdjustmentJournalCommonDTO postAdjustmentJournalCommonDTO)
        {
            try
            {
                var detalis = new TblAdjustmentJournalHeader
                {
                    StrAdjustmentJournalCode = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.AdjustmentJournalCode,
                    DteJournalDate = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.JournalDate,
                    IntClientId = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.ClientId,
                    IntBusinessUnitId = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.BusinessUnitId,
                    IntBusinessAreaId = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.BusinessAreaId,
                    NumDebitAmount = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.DebitAmount,
                    NumCreditAmount = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.CreditAmount,
                    StrNarration = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.Narration,
                    IsPosted = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.IsPosted,
                    IntAccountingJournalTypeId = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.AccountingJournalTypeId,
                    IsDirectPosting = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.IsDirectPosting,
                    IntActionBy = postAdjustmentJournalCommonDTO.AdjustmentJournalHeader.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblAdjustmentJournalHeader.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var JournalRows = new List<TblAdjustmentJournalRow>(postAdjustmentJournalCommonDTO.AdjustmentJournalRowList.Count);              
                foreach (var datas in postAdjustmentJournalCommonDTO.AdjustmentJournalRowList)
                {
                    var detalisrow = new TblAdjustmentJournalRow { };
                    detalisrow.IntAdjustmentJournalId = detalis.IntAdjustmentJournalId;
                    detalisrow.StrAdjustmentJournalCode = detalis.StrAdjustmentJournalCode;
                    detalisrow.IntGeneralLedgerId = datas.GeneralLedgerId;
                    detalisrow.StrGeneralLedgerName = datas.GeneralLedgerName;
                    detalisrow.StrNarration = datas.Narration;
                    detalisrow.NumAmount = datas.Amount;

                    JournalRows.Add(detalisrow);
                }
                await _context.TblAdjustmentJournalRow.AddRangeAsync(JournalRows);
                await _context.SaveChangesAsync();

                var successmsg = new Message
                {
                    status = true,
                    message = "Adjustment Journal Voucher Created Successfully.",
                    data = postAdjustmentJournalCommonDTO
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> EditAdjustmentJournalVoucher(EditAdjustmentJournalCommonDTO putAdjustmentJournalCommon)
        {
            try
            {
                TblAdjustmentJournalHeader dataParent = _context.TblAdjustmentJournalHeader.First(x => x.IntAdjustmentJournalId == putAdjustmentJournalCommon.AdjustmentJournalHeader.AdjustmentJournalId && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsPosted == false 
                    && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsDirectPosting == true && putAdjustmentJournalCommon.AdjustmentJournalHeader.IsActive == true);

                dataParent.DteJournalDate = putAdjustmentJournalCommon.AdjustmentJournalHeader.JournalDate;
                dataParent.IntClientId = putAdjustmentJournalCommon.AdjustmentJournalHeader.ClientId;
                dataParent.IntBusinessUnitId = putAdjustmentJournalCommon.AdjustmentJournalHeader.BusinessUnitId;
                dataParent.IntBusinessAreaId = putAdjustmentJournalCommon.AdjustmentJournalHeader.BusinessAreaId;
                dataParent.NumDebitAmount = putAdjustmentJournalCommon.AdjustmentJournalHeader.DebitAmount;
                dataParent.NumCreditAmount = putAdjustmentJournalCommon.AdjustmentJournalHeader.CreditAmount;
                dataParent.StrNarration = putAdjustmentJournalCommon.AdjustmentJournalHeader.Narration;
                dataParent.IntAccountingJournalTypeId = putAdjustmentJournalCommon.AdjustmentJournalHeader.AccountingJournalTypeId;
                dataParent.IntActionBy = putAdjustmentJournalCommon.AdjustmentJournalHeader.ActionBy;
                dataParent.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAdjustmentJournalHeader.Update(dataParent);
                await _context.SaveChangesAsync();

                var JournalRows = new List<TblAdjustmentJournalRow>(putAdjustmentJournalCommon.AdjustmentJournalRowList.Count);
                foreach (var datas in putAdjustmentJournalCommon.AdjustmentJournalRowList)
                {
                    TblAdjustmentJournalRow rdata = _context.TblAdjustmentJournalRow.First(x => x.IntRowId == datas.RowId);
                    rdata.IntGeneralLedgerId = datas.GeneralLedgerId;
                    rdata.StrGeneralLedgerName = datas.GeneralLedgerName;
                    rdata.StrNarration = datas.Narration;
                    rdata.NumAmount = datas.Amount;

                    JournalRows.Add(rdata);
                }
                _context.TblAdjustmentJournalRow.UpdateRange(JournalRows);
                await _context.SaveChangesAsync();
                
                var successmsg = new
                {
                    status = true,
                    message = "Edited Successfully.",
                    data = putAdjustmentJournalCommon
                };
                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }        
    }
}
