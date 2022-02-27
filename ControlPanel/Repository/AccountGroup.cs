using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountGroup;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountGroup : IAccountGroup
    {
        public readonly iBOSContext _context;
        public AccountGroup(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountGroupAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Account Group List ",
                    data = await Task.FromResult((from a in _context.TblAccountGroup
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true
                                                  select new GetAccountGroupDTO()
                                                  {
                                                      AccountGroupId = a.IntAccountGroupId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupCode = a.StrAccountGroupCode,
                                                      AccountGroupName = a.StrAccountGroupName,
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
        public async Task<Message> GetAccountGroupById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = " Account Group List by Id ",
                    data = await Task.FromResult((from a in _context.TblAccountGroup
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntAccountGroupId == Id
                                                  select new GetAccountGroupDTO()
                                                  {
                                                      AccountGroupId = a.IntAccountGroupId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupCode = a.StrAccountGroupCode,
                                                      AccountGroupName = a.StrAccountGroupName,
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
        public async Task<Message> GetAccountGroupByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Group List by Client Id ",
                    data = await Task.FromResult((from a in _context.TblAccountGroup
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetAccountGroupDTO()
                                                  {
                                                      AccountGroupId = a.IntAccountGroupId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      AccountGroupCode = a.StrAccountGroupCode,
                                                      AccountGroupName = a.StrAccountGroupName,
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
        public async Task<object> CreateAccountGroup(CreateAccountGroupDTO postAccountGroup)
        {
            try
            {
                var detalis = new TblAccountGroup
                {
                    IntClientId = postAccountGroup.ClientId,
                    StrAccountGroupName = postAccountGroup.AccountGroupName,
                    StrAccountGroupCode = postAccountGroup.AccountGroupName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    IntActionBy = postAccountGroup.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblAccountGroup.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAccountGroup
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountGroupId == detalis.IntAccountGroupId
                              select new GetAccountGroupDTO()
                              {
                                  AccountGroupId = a.IntAccountGroupId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupCode = a.StrAccountGroupCode,
                                  AccountGroupName = a.StrAccountGroupName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Group Created Successfully.",
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
        public async Task<object> EditAccountGroup(EditAccountGroupDTO AccountGroup)
        {
            try
            {
                TblAccountGroup data = _context.TblAccountGroup.First(x => x.IntAccountGroupId == AccountGroup.AccountGroupId);

                data.IntAccountGroupId = AccountGroup.AccountGroupId;
                data.IntClientId = AccountGroup.ClientId;
                data.IntAccountGroupId = AccountGroup.AccountGroupId;
                data.StrAccountGroupName = AccountGroup.AccountGroupName;
                data.IntActionBy = AccountGroup.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAccountGroup.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAccountGroup
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == true && a.IntAccountGroupId == AccountGroup.AccountGroupId
                              select new GetAccountGroupDTO()
                              {
                                  AccountGroupId = a.IntAccountGroupId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupCode = a.StrAccountGroupCode,
                                  AccountGroupName = a.StrAccountGroupName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Group Edited Successfully.",
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
        public async Task<object> CancelAccountGroup(CancelAccountGroupDTO AccountGroup)
        {
            try
            {
                TblAccountGroup data = _context.TblAccountGroup.First(x => x.IntAccountGroupId == AccountGroup.AccountGroupId);
                data.IntActionBy = AccountGroup.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblAccountGroup.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblAccountGroup
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              where a.IsActive == false && a.IntAccountGroupId == AccountGroup.AccountGroupId
                              select new GetAccountGroupDTO()
                              {
                                  AccountGroupId = a.IntAccountGroupId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  AccountGroupCode = a.StrAccountGroupCode,
                                  AccountGroupName = a.StrAccountGroupName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Account Group Cancelled Successfully.",
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
