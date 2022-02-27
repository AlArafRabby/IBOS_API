using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingJournalTypeBusinessUnit;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountingJournalTypeBusinessUnit : IAccountingJournalTypeBusinessUnit
    {
        public readonly iBOSContext _context;
        public AccountingJournalTypeBusinessUnit(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountingJournalTypeBusinessUnitAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AccountingJournalTypeBusinessUnit List ",
                    data = await Task.FromResult((from a in _context.TblAccountingJournalTypeBusinessUnit
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                                  where a.IsActive == true
                                                  select new GetAccountingJournalTypeBusinessUnitDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                                      Prefix = a.StrPrefix,
                                                      IsYear = a.IsYear,
                                                      IsMonth = a.IsMonth,
                                                      IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                                      MonthlyNumberLength = a.IntMonthlyNumberLength,
                                                      YearlyNumberLength = a.IntYearlyNumberLength,
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
        public async Task<Message> GetAccountingJournalTypeBusinessUnitByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AccountingJournalTypeBusinessUnit List by Client Id",
                    data = await Task.FromResult((from a in _context.TblAccountingJournalTypeBusinessUnit
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetAccountingJournalTypeBusinessUnitDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                                      Prefix = a.StrPrefix,
                                                      IsYear = a.IsYear,
                                                      IsMonth = a.IsMonth,
                                                      IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                                      MonthlyNumberLength = a.IntMonthlyNumberLength,
                                                      YearlyNumberLength = a.IntYearlyNumberLength,
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
        public async Task<Message> GetAccountingJournalTypeBusinessUnitById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AccountingJournalTypeBusinessUnit List by Id",
                    data = await Task.FromResult((from a in _context.TblAccountingJournalTypeBusinessUnit
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntConfigId == Id
                                                  select new GetAccountingJournalTypeBusinessUnitDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                                      Prefix = a.StrPrefix,
                                                      IsYear = a.IsYear,
                                                      IsMonth = a.IsMonth,
                                                      IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                                      MonthlyNumberLength = a.IntMonthlyNumberLength,
                                                      YearlyNumberLength = a.IntYearlyNumberLength,
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
        public async Task<Message> GetAccountingJournalTypeBusinessUnitByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AccountingJournalTypeBusinessUnit List by Unit Id",
                    data = await Task.FromResult((from a in _context.TblAccountingJournalTypeBusinessUnit
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                                  where a.IsActive == true && a.IntBusinessUnitId == UId
                                                  select new GetAccountingJournalTypeBusinessUnitDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                                      Prefix = a.StrPrefix,
                                                      IsYear = a.IsYear,
                                                      IsMonth = a.IsMonth,
                                                      IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                                      MonthlyNumberLength = a.IntMonthlyNumberLength,
                                                      YearlyNumberLength = a.IntYearlyNumberLength,
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
        public async Task<object> CreateAccountingJournalTypeBusinessUnit(CreateAccountingJournalTypeBusinessUnitDTO postAccountingJournalTypeBusinessUnit)
        {
            try
            {
                var detalis = new TblAccountingJournalTypeBusinessUnit
                {
                    IntClientId = postAccountingJournalTypeBusinessUnit.ClientId,
                    IntBusinessUnitId = postAccountingJournalTypeBusinessUnit.BusinessUnitId,
                    IntAccountingJournalTypeId = postAccountingJournalTypeBusinessUnit.AccountingJournalTypeId,
                    StrPrefix = postAccountingJournalTypeBusinessUnit.Prefix,
                    IsYear = postAccountingJournalTypeBusinessUnit.IsYear,
                    IsMonth = postAccountingJournalTypeBusinessUnit.IsMonth,
                    IntMonthlyNumberLength = postAccountingJournalTypeBusinessUnit.MonthlyNumberLength,
                    IntYearlyNumberLength = postAccountingJournalTypeBusinessUnit.YearlyNumberLength,
                    IsMonthlyNumberChange = postAccountingJournalTypeBusinessUnit.IsMonthlyNumberChange,
                    IntActionBy = postAccountingJournalTypeBusinessUnit.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblAccountingJournalTypeBusinessUnit.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAccountingJournalTypeBusinessUnit
                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                  join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                  where a.IsActive == true && a.IntAccountingJournalTypeId == detalis.IntAccountingJournalTypeId
                                  select new GetAccountingJournalTypeBusinessUnitDTO()
                                  {
                                      ConfigId = a.IntConfigId,
                                      ClientId = cl.IntClientId,
                                      ClientName = cl.StrClientName,
                                      BusinessUnitId = u.IntBusinessUnitId,
                                      BusinessUnitName = u.StrBusinessUnitName,
                                      AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                      AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                      Prefix = a.StrPrefix,
                                      IsYear = a.IsYear,
                                      IsMonth = a.IsMonth,
                                      IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                      MonthlyNumberLength = a.IntMonthlyNumberLength,
                                      YearlyNumberLength = a.IntYearlyNumberLength,
                                      ActionBy = a.IntActionBy,
                                      LastActionDateTime = a.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Accounting Journal Type Business Unit Created Successfully.",
                    data = detalisView
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
        public async Task<object> EditAccountingJournalTypeBusinessUnit(EditAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit)
        {
            try
            {
                TblAccountingJournalTypeBusinessUnit data = _context.TblAccountingJournalTypeBusinessUnit.First(x => x.IntConfigId == AccountingJournalTypeBusinessUnit.ConfigId);

                data.IntConfigId = AccountingJournalTypeBusinessUnit.ConfigId;
                data.IntClientId = AccountingJournalTypeBusinessUnit.ClientId;
                data.IntBusinessUnitId = AccountingJournalTypeBusinessUnit.BusinessUnitId;
                data.IntAccountingJournalTypeId = AccountingJournalTypeBusinessUnit.AccountingJournalTypeId;
                data.StrPrefix = AccountingJournalTypeBusinessUnit.Prefix;
                data.IsYear = AccountingJournalTypeBusinessUnit.IsYear;
                data.IsMonth = AccountingJournalTypeBusinessUnit.IsMonth;
                data.IntMonthlyNumberLength = AccountingJournalTypeBusinessUnit.MonthlyNumberLength;
                data.IntYearlyNumberLength = AccountingJournalTypeBusinessUnit.YearlyNumberLength;
                data.IsMonthlyNumberChange = AccountingJournalTypeBusinessUnit.IsMonthlyNumberChange;
                data.IntActionBy = AccountingJournalTypeBusinessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAccountingJournalTypeBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAccountingJournalTypeBusinessUnit
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                              where a.IsActive == true && a.IntConfigId == AccountingJournalTypeBusinessUnit.ConfigId
                              select new GetAccountingJournalTypeBusinessUnitDTO()
                              {
                                  ConfigId = a.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                  Prefix = a.StrPrefix,
                                  IsYear = a.IsYear,
                                  IsMonth = a.IsMonth,
                                  IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                  MonthlyNumberLength = a.IntMonthlyNumberLength,
                                  YearlyNumberLength = a.IntYearlyNumberLength,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Accounting Journal Type Business Unit Edited Successfully.",
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
        public async Task<object> CancelAccountingJournalTypeBusinessUnit(CancelAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit)
        {
            try
            {
                TblAccountingJournalTypeBusinessUnit data = _context.TblAccountingJournalTypeBusinessUnit.First(x => x.IntConfigId == AccountingJournalTypeBusinessUnit.ConfigId);
                data.IntActionBy = AccountingJournalTypeBusinessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblAccountingJournalTypeBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAccountingJournalTypeBusinessUnit
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                              where a.IsActive == false && a.IntConfigId == AccountingJournalTypeBusinessUnit.ConfigId
                              select new GetAccountingJournalTypeBusinessUnitDTO()
                              {
                                  ConfigId = a.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  AccountingJournalTypeId = t.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = t.StrAccountingJournalTypeName,
                                  Prefix = a.StrPrefix,
                                  IsYear = a.IsYear,
                                  IsMonth = a.IsMonth,
                                  IsMonthlyNumberChange = a.IsMonthlyNumberChange,
                                  MonthlyNumberLength = a.IntMonthlyNumberLength,
                                  YearlyNumberLength = a.IntYearlyNumberLength,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Accounting Journal Type Business Unit Cancelled Successfully.",
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
