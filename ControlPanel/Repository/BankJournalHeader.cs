using ControlPanel.DbContexts;
using ControlPanel.DTO.BankJournalHeader;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControlPanel.Repository
{
    public class BankJournalHeader : IBankJournalHeader
    {
        public readonly iBOSContext _context;
        public BankJournalHeader(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> BankJournalbyBusinessAreaId(long AreaId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Journal Header List by Area Id",
                    data = await Task.FromResult((from a in _context.TblBankJournalHeader
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntBusinessAreaId == AreaId
                                                  select new GetBankJournalHeaderDTO()
                                                  {
                                                      BankJournalId = a.IntBankJournalId,
                                                      BankJournalCode = a.StrBankJournalCode,
                                                      VoucherDate = a.DteVoucherDate,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName ,
                                                      BusinessAreaId = area.IntBusinessAreaId,
                                                      BusinessAreaName = area.StrBusinessAreaName ,
                                                      BankId = a.IntBankId,
                                                      BankName = a.StrBankName,
                                                      BankBranchId = a.IntBankBranchId,
                                                      BankBranchName = a.StrBankBranchName ,
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountNumber = a.StrBankAccountNumber ,
                                                      InstrumentTypeId = a.IntInstrumentTypeId ,
                                                      InstrumentName = a.StrInstrumentName ,
                                                      InstrumentNumber = a.StrInstrumentNumber,
                                                      InstrumentDate = a.DteInstrumentDate,
                                                      GeneralLedgerId = a.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName ,
                                                      Amount = a.NumAmount ,
                                                      Narration = a.StrNarration,
                                                      IsPosted = a.IsPosted,
                                                      BusinessPartnerName = a.StrBusinessPartnerName ,
                                                      AccountingJournalTypeId = a.IntAccountingJournalTypeId ,
                                                      AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                                      IsDirectPosting = a.IsDirectPosting ,
                                                      ActionBy = a.IntActionBy ,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<Message> BankJournalbyBusinessUnitId(long UnitId,bool isPosted)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Journal Header List by Unit Id ",
                    data = await Task.FromResult((from a in _context.TblBankJournalHeader
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntBusinessUnitId == UnitId && a.IsPosted == isPosted
                                                  select new GetBankJournalHeaderDTO()
                                                  {
                                                      BankJournalId = a.IntBankJournalId,
                                                      BankJournalCode = a.StrBankJournalCode,
                                                      VoucherDate = a.DteVoucherDate,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      BusinessAreaId = area.IntBusinessAreaId,
                                                      BusinessAreaName = area.StrBusinessAreaName,
                                                      BankId = a.IntBankId,
                                                      BankName = a.StrBankName,
                                                      BankBranchId = a.IntBankBranchId,
                                                      BankBranchName = a.StrBankBranchName,
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountNumber = a.StrBankAccountNumber,
                                                      InstrumentTypeId = a.IntInstrumentTypeId,
                                                      InstrumentName = a.StrInstrumentName,
                                                      InstrumentNumber = a.StrInstrumentNumber,
                                                      InstrumentDate = a.DteInstrumentDate,
                                                      GeneralLedgerId = a.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      Amount = a.NumAmount,
                                                      Narration = a.StrNarration,
                                                      IsPosted = a.IsPosted,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                                      IsDirectPosting = a.IsDirectPosting,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<Message> BankJournalbyClientId(long ClientId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Journal Header List by client Id",
                    data = await Task.FromResult((from a in _context.TblBankJournalHeader
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntClientId == ClientId
                                                  select new GetBankJournalHeaderDTO()
                                                  {
                                                      BankJournalId = a.IntBankJournalId,
                                                      BankJournalCode = a.StrBankJournalCode,
                                                      VoucherDate = a.DteVoucherDate,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      BusinessAreaId = area.IntBusinessAreaId,
                                                      BusinessAreaName = area.StrBusinessAreaName,
                                                      BankId = a.IntBankId,
                                                      BankName = a.StrBankName,
                                                      BankBranchId = a.IntBankBranchId,
                                                      BankBranchName = a.StrBankBranchName,
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountNumber = a.StrBankAccountNumber,
                                                      InstrumentTypeId = a.IntInstrumentTypeId,
                                                      InstrumentName = a.StrInstrumentName,
                                                      InstrumentNumber = a.StrInstrumentNumber,
                                                      InstrumentDate = a.DteInstrumentDate,
                                                      GeneralLedgerId = a.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      Amount = a.NumAmount,
                                                      Narration = a.StrNarration,
                                                      IsPosted = a.IsPosted,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                                      IsDirectPosting = a.IsDirectPosting,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<Message> BankJournalbyVoucherId(long VoucherId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Journal Header List by voucher Id ",
                    data = await Task.FromResult((from a in _context.TblBankJournalHeader
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntBankJournalId == VoucherId
                                                  select new GetBankJournalHeaderDTO()
                                                  {
                                                      BankJournalId = a.IntBankJournalId,
                                                      BankJournalCode = a.StrBankJournalCode,
                                                      VoucherDate = a.DteVoucherDate,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      BusinessAreaId = area.IntBusinessAreaId,
                                                      BusinessAreaName = area.StrBusinessAreaName,
                                                      BankId = a.IntBankId,
                                                      BankName = a.StrBankName,
                                                      BankBranchId = a.IntBankBranchId,
                                                      BankBranchName = a.StrBankBranchName,
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountNumber = a.StrBankAccountNumber,
                                                      InstrumentTypeId = a.IntInstrumentTypeId,
                                                      InstrumentName = a.StrInstrumentName,
                                                      InstrumentNumber = a.StrInstrumentNumber,
                                                      InstrumentDate = a.DteInstrumentDate,
                                                      GeneralLedgerId = a.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      Amount = a.NumAmount,
                                                      Narration = a.StrNarration,
                                                      IsPosted = a.IsPosted,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                                      IsDirectPosting = a.IsDirectPosting,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<object> CancelBankJournalVoucher(CancelBankJournalHeaderDTO BankJournalHeader)
        {
            try
            {
                TblBankJournalHeader data = _context.TblBankJournalHeader.First(x => x.IntBankJournalId == BankJournalHeader.BankJournalId);
                data.IntActionBy = BankJournalHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblBankJournalHeader.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblBankJournalHeader
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                              where a.IsActive == false && a.IntBankJournalId == BankJournalHeader.BankJournalId
                              select new GetBankJournalHeaderDTO()
                              {
                                  BankJournalId = a.IntBankJournalId,
                                  BankJournalCode = a.StrBankJournalCode,
                                  VoucherDate = a.DteVoucherDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = a.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaId = area.IntBusinessAreaId,
                                  BusinessAreaName = area.StrBusinessAreaName,
                                  BankId = a.IntBankId,
                                  BankName = a.StrBankName,
                                  BankBranchId = a.IntBankBranchId,
                                  BankBranchName = a.StrBankBranchName,
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountNumber = a.StrBankAccountNumber,
                                  InstrumentTypeId = a.IntInstrumentTypeId,
                                  InstrumentName = a.StrInstrumentName,
                                  InstrumentNumber = a.StrInstrumentNumber,
                                  InstrumentDate = a.DteInstrumentDate,
                                  GeneralLedgerId = a.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  Amount = a.NumAmount,
                                  Narration = a.StrNarration,
                                  IsPosted = a.IsPosted,
                                  BusinessPartnerName = a.StrBusinessPartnerName,
                                  AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                  IsDirectPosting = a.IsDirectPosting,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Journal Header Cancelled Successfully.",
                    data = detalis
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
        public async Task<object> CompleteBankJournalVoucher(EditBankJournalHeaderDTO BankJournalHeader)
        {
            try
            {
                TblBankJournalHeader data = _context.TblBankJournalHeader.First(x => x.IntBankJournalId == BankJournalHeader.BankJournalId);
                data.IntActionBy = BankJournalHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsPosted = true;
                _context.TblBankJournalHeader.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBankJournalHeader
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                              where a.IsActive == true && a.IsPosted == true && a.IsDirectPosting == true
                              select new GetBankJournalHeaderDTO()
                              {
                                  BankJournalId = a.IntBankJournalId,
                                  BankJournalCode = a.StrBankJournalCode,
                                  VoucherDate = a.DteVoucherDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = a.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaId = area.IntBusinessAreaId,
                                  BusinessAreaName = area.StrBusinessAreaName,
                                  BankId = a.IntBankId,
                                  BankName = a.StrBankName,
                                  BankBranchId = a.IntBankBranchId,
                                  BankBranchName = a.StrBankBranchName,
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountNumber = a.StrBankAccountNumber,
                                  InstrumentTypeId = a.IntInstrumentTypeId,
                                  InstrumentName = a.StrInstrumentName,
                                  InstrumentNumber = a.StrInstrumentNumber,
                                  InstrumentDate = a.DteInstrumentDate,
                                  GeneralLedgerId = a.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  Amount = a.NumAmount,
                                  Narration = a.StrNarration,
                                  IsPosted = a.IsPosted,
                                  BusinessPartnerName = a.StrBusinessPartnerName,
                                  AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                  IsDirectPosting = a.IsDirectPosting,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Journal Header Edited Successfully.",
                    data = detalis
                };
                return successmsg;
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
        public async Task<object> CreateBankJournalVoucher(CreateBankJournalHeaderCommonDTO postBankJournalHeaderCommon)
        {
            try
            {
                var detalis = new TblBankJournalHeader
                {
                     StrBankJournalCode = postBankJournalHeaderCommon.bankJournalHeader.BankJournalCode,
                     DteVoucherDate = postBankJournalHeaderCommon.bankJournalHeader.VoucherDate,
                     IntClientId = postBankJournalHeaderCommon.bankJournalHeader.ClientId,
                     IntBusinessUnitId = postBankJournalHeaderCommon.bankJournalHeader.BusinessUnitId,
                     IntBusinessAreaId = postBankJournalHeaderCommon.bankJournalHeader.BusinessAreaId,
                     IntBankId = postBankJournalHeaderCommon.bankJournalHeader.BankId,
                     StrBankName = postBankJournalHeaderCommon.bankJournalHeader.BankName,
                     IntBankBranchId = postBankJournalHeaderCommon.bankJournalHeader.BankBranchId,
                     StrBankBranchName = postBankJournalHeaderCommon.bankJournalHeader.BankBranchName,
                     IntBankAccountId = postBankJournalHeaderCommon.bankJournalHeader.BankAccountId,
                     StrBankAccountNumber = postBankJournalHeaderCommon.bankJournalHeader.BankAccountNumber,
                     IntInstrumentTypeId = postBankJournalHeaderCommon.bankJournalHeader.InstrumentTypeId,
                     StrInstrumentName = postBankJournalHeaderCommon.bankJournalHeader.InstrumentName,
                     StrInstrumentNumber = postBankJournalHeaderCommon.bankJournalHeader.InstrumentNumber,
                     DteInstrumentDate = postBankJournalHeaderCommon.bankJournalHeader.InstrumentDate,
                     IntGeneralLedgerId = postBankJournalHeaderCommon.bankJournalHeader.GeneralLedgerId,
                     NumAmount = postBankJournalHeaderCommon.bankJournalHeader.Amount,
                     StrNarration = postBankJournalHeaderCommon.bankJournalHeader.Narration,
                     IsPosted = false,
                     StrBusinessPartnerName = postBankJournalHeaderCommon.bankJournalHeader.BusinessPartnerName,
                     IntAccountingJournalTypeId = postBankJournalHeaderCommon.bankJournalHeader.AccountingJournalTypeId,
                     IsDirectPosting = postBankJournalHeaderCommon.bankJournalHeader.IsDirectPosting,
                     IntActionBy = postBankJournalHeaderCommon.bankJournalHeader.ActionBy,
                     DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblBankJournalHeader.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var JournalRows = new List<TblBankJournalRow>(postBankJournalHeaderCommon.bankJournalRow.Count);
                foreach (var datas in postBankJournalHeaderCommon.bankJournalRow)
                {
                    TblBankJournalRow detalisrow = new TblBankJournalRow { };

                    detalisrow.IntBankJournalId = detalis.IntBankJournalId;
                    detalisrow.StrBankJournalCode = datas.BankJournalCode;
                    detalisrow.IntGeneralLedgerId = datas.GeneralLedgerId;
                    detalisrow.StrGeneralLedgerCode = datas.GeneralLedgerCode;
                    detalisrow.StrGeneralLedgerName = datas.GeneralLedgerName;
                    detalisrow.NumAmount = datas.Amount;

                    JournalRows.Add(detalisrow);
                }
                await _context.TblBankJournalRow.AddRangeAsync(JournalRows);
                await _context.SaveChangesAsync();

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank journal Header Created Successfully.",
                    data = postBankJournalHeaderCommon
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
        public async Task<object> EditBankJournalVoucher(EditBankJournalHeaderCommonDTO BankJournalHeaderCommon)
        {
            try
            {
                TblBankJournalHeader data = _context.TblBankJournalHeader.First(x => x.IntBankJournalId == BankJournalHeaderCommon.bankJournalHeader.BankJournalId && BankJournalHeaderCommon.bankJournalHeader.IsPosted == false && BankJournalHeaderCommon.bankJournalHeader.IsDirectPosting == true);
                data.IntBankJournalId = BankJournalHeaderCommon.bankJournalHeader.BankJournalId;
                data.IntBusinessUnitId = BankJournalHeaderCommon.bankJournalHeader.BusinessUnitId;
                data.IntBusinessAreaId = BankJournalHeaderCommon.bankJournalHeader.BusinessAreaId;
                data.IntBankId = BankJournalHeaderCommon.bankJournalHeader.BankId;
                data.StrBankName = BankJournalHeaderCommon.bankJournalHeader.BankName; 
                data.IntBankBranchId = BankJournalHeaderCommon.bankJournalHeader.BankBranchId;
                data.StrBankBranchName = BankJournalHeaderCommon.bankJournalHeader.BankBranchName;
                data.IntBankAccountId = BankJournalHeaderCommon.bankJournalHeader.BankAccountId;
                data.StrBankAccountNumber = BankJournalHeaderCommon.bankJournalHeader.BankAccountNumber;
                data.IntInstrumentTypeId = BankJournalHeaderCommon.bankJournalHeader.InstrumentTypeId;
                data.StrInstrumentName = BankJournalHeaderCommon.bankJournalHeader.InstrumentName;
                data.StrInstrumentNumber = BankJournalHeaderCommon.bankJournalHeader.InstrumentNumber;
                data.DteInstrumentDate = BankJournalHeaderCommon.bankJournalHeader.InstrumentDate;
                data.IntGeneralLedgerId = BankJournalHeaderCommon.bankJournalHeader.GeneralLedgerId;
                data.NumAmount = BankJournalHeaderCommon.bankJournalHeader.Amount;
                data.StrNarration = BankJournalHeaderCommon.bankJournalHeader.Narration;
                data.StrBusinessPartnerName = BankJournalHeaderCommon.bankJournalHeader.BusinessPartnerName;
                data.IntAccountingJournalTypeId = BankJournalHeaderCommon.bankJournalHeader.AccountingJournalTypeId;
                data.IntActionBy = BankJournalHeaderCommon.bankJournalHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBankJournalHeader.Update(data); 
                await _context.SaveChangesAsync();

                var detalisrow = new TblBankJournalRow { };

                foreach (var datas in BankJournalHeaderCommon.bankJournalRow)
                {
                    TblBankJournalRow rdata = _context.TblBankJournalRow.First(x => x.IntRowId == datas.RowId && BankJournalHeaderCommon.bankJournalHeader.IsPosted == false && BankJournalHeaderCommon.bankJournalHeader.IsDirectPosting == true);
                    rdata.NumAmount = datas.Amount;
                    _context.TblBankJournalRow.Update(rdata);
                    await _context.SaveChangesAsync();
                }

                var detalis = from a in _context.TblBankJournalHeader
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join area in _context.TblBusinessArea on a.IntBusinessAreaId equals area.IntBusinessAreaId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join ajt in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals ajt.IntAccountingJournalTypeId
                              where a.IsActive == true && a.IsPosted == true && a.IsDirectPosting == true
                              select new GetBankJournalHeaderDTO()
                              {
                                  BankJournalId = a.IntBankJournalId,
                                  BankJournalCode = a.StrBankJournalCode,
                                  VoucherDate = a.DteVoucherDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = a.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaId = area.IntBusinessAreaId,
                                  BusinessAreaName = area.StrBusinessAreaName,
                                  BankId = a.IntBankId,
                                  BankName = a.StrBankName,
                                  BankBranchId = a.IntBankBranchId,
                                  BankBranchName = a.StrBankBranchName,
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountNumber = a.StrBankAccountNumber,
                                  InstrumentTypeId = a.IntInstrumentTypeId,
                                  InstrumentName = a.StrInstrumentName,
                                  InstrumentNumber = a.StrInstrumentNumber,
                                  InstrumentDate = a.DteInstrumentDate,
                                  GeneralLedgerId = a.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  Amount = a.NumAmount,
                                  Narration = a.StrNarration,
                                  IsPosted = a.IsPosted,
                                  BusinessPartnerName = a.StrBusinessPartnerName,
                                  AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = ajt.StrAccountingJournalTypeName,
                                  IsDirectPosting = a.IsDirectPosting,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Journal Header Edited Successfully.",
                    data = detalis
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
