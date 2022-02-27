using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountClass;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountClass : IAccountClass
    {
        public readonly iBOSContext _context;
        public AccountClass(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountClassAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Account Class List ",
                    data = await Task.FromResult((from a in _context.TblAccountClass
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true
                                                  select new GetAccountClassDTO()
                                                  {
                                                      AccountClassId = a.IntAccountClassId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassName = a.StrAccountClassName,
                                                      AccountClassCode = a.StrAccountClassCode,
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
        public async Task<Message> GetAccountClassByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account class List By Client Id.",
                    data = await Task.FromResult((from a in _context.TblAccountClass
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetAccountClassDTO()
                                                  {
                                                      AccountClassId = a.IntAccountClassId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassName = a.StrAccountClassName,
                                                      AccountClassCode = a.StrAccountClassCode,
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
        public async Task<Message> GetAccountClassById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account class List By  Id.",
                    data = await Task.FromResult((from a in _context.TblAccountClass
                                                  join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntClientId == Id
                                                  select new GetAccountClassDTO()
                                                  {
                                                      AccountClassId = a.IntAccountClassId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupId = c.IntAccountGroupId,
                                                      AccountGroupName = c.StrAccountGroupName,
                                                      AccountClassName = a.StrAccountClassName,
                                                      AccountClassCode = a.StrAccountClassCode,
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
        public async Task<object> CreateAccountClass(CreateAccountClassDTO postAccountClass)
        {
            try
            {
                var detalis = new TblAccountClass
                {
                    IntClientId = postAccountClass.ClientId,
                    IntAccountGroupId = postAccountClass.AccountGroupId,
                    StrAccountClassCode = postAccountClass.AccountClassName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrAccountClassName = postAccountClass.AccountClassName,
                    IntActionBy = postAccountClass.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblAccountClass.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAccountClass
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountClassId == detalis.IntAccountClassId
                              select new GetAccountClassDTO()
                              {
                                  AccountClassId = a.IntAccountClassId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassName = a.StrAccountClassName,
                                  AccountClassCode = a.StrAccountClassCode,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Class Created Successfully.",
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
        public async Task<object> EditAccountClass(EditAccountClassDTO AccountClass)
        {
            try
            {
                TblAccountClass data = _context.TblAccountClass.First(x => x.IntAccountClassId == AccountClass.AccountClassId);

                data.IntAccountClassId = AccountClass.AccountClassId;
                data.IntClientId = AccountClass.ClientId;
                data.IntAccountGroupId = AccountClass.AccountGroupId;
                data.StrAccountClassName = AccountClass.AccountClassName;
                data.IntActionBy = AccountClass.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAccountClass.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAccountClass
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountClassId == AccountClass.AccountClassId
                              select new GetAccountClassDTO()
                              {
                                  AccountClassId = a.IntAccountClassId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassName = a.StrAccountClassName,
                                  AccountClassCode = a.StrAccountClassCode,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Class Edited Successfully.",
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
        public async Task<object> CancelAccountClass(CancelAccountClassDTO AccountClass)
        {
            try
            {
                TblAccountClass data = _context.TblAccountClass.First(x => x.IntAccountClassId == AccountClass.AccountClassId);
                data.IntActionBy = AccountClass.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblAccountClass.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblAccountClass
                              join c in _context.TblAccountGroup on a.IntAccountGroupId equals c.IntAccountGroupId
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == false && a.IntAccountClassId == AccountClass.AccountClassId
                              select new GetAccountClassDTO()
                              {
                                  AccountClassId = a.IntAccountClassId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupId = c.IntAccountGroupId,
                                  AccountGroupName = c.StrAccountGroupName,
                                  AccountClassName = a.StrAccountClassName,
                                  AccountClassCode = a.StrAccountClassCode,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Account Class cancelled Successfully.",
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
