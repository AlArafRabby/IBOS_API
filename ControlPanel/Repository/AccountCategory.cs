using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountCategory;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountCategory : IAccountCategory
    {
        public readonly iBOSContext _context;
        public AccountCategory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountCategoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Account Category List ",
                    data = await Task.FromResult((from a in _context.TblAccountCategory
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true
                                                  select new GetAccountCategoryDTO()
                                                  {
                                                      AccountCategoryId = a.IntAccountCategoryId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassId = u.IntAccountGroupId,
                                                      AccountClassName = u.StrAccountClassName,
                                                      AccountCategoryCode = a.StrAccountCategoryCode,
                                                      AccountCategoryName = a.StrAccountCategoryName,
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
                    message = ex.Message+" Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetAccountCategoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Category List By Id.",
                    data = await Task.FromResult((from a in _context.TblAccountCategory
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntAccountCategoryId == Id
                                                  select new GetAccountCategoryDTO()
                                                  {
                                                      AccountCategoryId = a.IntAccountCategoryId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassId = u.IntAccountGroupId,
                                                      AccountClassName = u.StrAccountClassName,
                                                      AccountCategoryCode = a.StrAccountCategoryCode,
                                                      AccountCategoryName = a.StrAccountCategoryName,
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
        public async Task<Message> GetAccountCategoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Category List By Client Id.",
                    data = await Task.FromResult((from a in _context.TblAccountCategory
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetAccountCategoryDTO()
                                                  {
                                                      AccountCategoryId = a.IntAccountCategoryId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassId = u.IntAccountGroupId,
                                                      AccountClassName = u.StrAccountClassName,
                                                      AccountCategoryCode = a.StrAccountCategoryCode,
                                                      AccountCategoryName = a.StrAccountCategoryName,
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
        public async Task<object> CreateAccountCategory(CreateAccountCategoryDTO postAccountCategory)
        {
            try
            {
                var detalis = new TblAccountCategory
                {
                    IntClientId = postAccountCategory.ClientId,
                    IntAccountGroupId = postAccountCategory.AccountGroupId,
                    IntAccountClassId = postAccountCategory.AccountClassId,
                    StrAccountCategoryCode = postAccountCategory.AccountCategoryName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrAccountCategoryName = postAccountCategory.AccountCategoryName,
                    IntActionBy = postAccountCategory.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblAccountCategory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAccountCategory
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountCategoryId == detalis.IntAccountCategoryId
                              select new GetAccountCategoryDTO()
                              {
                                  AccountCategoryId = a.IntAccountCategoryId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassId = u.IntAccountGroupId,
                                  AccountClassName = u.StrAccountClassName,
                                  AccountCategoryCode = a.StrAccountCategoryCode,
                                  AccountCategoryName = a.StrAccountCategoryName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Created Successfully.",
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
        public async Task<object> EditAccountCategory(EditAccountCategoryDTO AccountCategory)
        {
            try
            {
                TblAccountCategory data = _context.TblAccountCategory.First(x => x.IntAccountCategoryId == AccountCategory.AccountCategoryId);

                data.IntAccountCategoryId = AccountCategory.AccountCategoryId;
                data.IntClientId = AccountCategory.ClientId;
                data.IntAccountGroupId = AccountCategory.AccountGroupId;
                data.IntAccountClassId = AccountCategory.AccountClassId;
                data.StrAccountCategoryName = AccountCategory.AccountCategoryName;
                data.IntActionBy = AccountCategory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAccountCategory.Update(data);
                await _context.SaveChangesAsync();
                
                var detalis = from a in _context.TblAccountCategory
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountCategoryId == AccountCategory.AccountCategoryId
                              select new GetAccountCategoryDTO()
                              {
                                  AccountCategoryId = a.IntAccountCategoryId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassId = u.IntAccountGroupId,
                                  AccountClassName = u.StrAccountClassName,
                                  AccountCategoryCode = a.StrAccountCategoryCode,
                                  AccountCategoryName = a.StrAccountCategoryName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Edited Successfully.",
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
        public async Task<object> CancelAccountCategory(CancelAccountCategoryDTO AccountCategory)
        {
            try
            {
                TblAccountCategory data = _context.TblAccountCategory.First(x => x.IntAccountCategoryId == AccountCategory.AccountCategoryId);
                data.IntActionBy = AccountCategory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblAccountCategory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAccountCategory
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join u in _context.TblAccountClass on a.IntAccountClassId equals u.IntAccountClassId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == false && a.IntAccountCategoryId == AccountCategory.AccountCategoryId
                              select new GetAccountCategoryDTO()
                              {
                                  AccountCategoryId = a.IntAccountCategoryId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassId = u.IntAccountGroupId,
                                  AccountClassName = u.StrAccountClassName,
                                  AccountCategoryCode = a.StrAccountCategoryCode,
                                  AccountCategoryName = a.StrAccountCategoryName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Cancelled Successfully.",
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
