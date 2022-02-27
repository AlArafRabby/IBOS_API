using ControlPanel.DbContexts;
using ControlPanel.DTO.BankAccount;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BankAccount : IBankAccount
    {
        public readonly iBOSContext _context;
        public BankAccount(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> GetBankAccountAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Account List ",
                    data = await Task.FromResult((from a in _context.TblBankAccount
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join b in _context.TblBank on a.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                                                  where a.IsActive == true
                                                  select new GetBankAccountDTO()
                                                  {
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountName = c.StrClientName,
                                                      BankAccountNo = a.StrBankAccountNo,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
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
        public async Task<Message> GetBankAccountByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Area List ",
                    data = await Task.FromResult((from a in _context.TblBankAccount
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join b in _context.TblBank on a.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetBankAccountDTO()
                                                  {
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountName = c.StrClientName,
                                                      BankAccountNo = a.StrBankAccountNo,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
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
        public async Task<Message> GetBankAccountById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Area List ",
                    data = await Task.FromResult((from a in _context.TblBankAccount
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join b in _context.TblBank on a.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                                                  where a.IsActive == true && a.IntClientId == Id
                                                  select new GetBankAccountDTO()
                                                  {
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountName = c.StrClientName,
                                                      BankAccountNo = a.StrBankAccountNo,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
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
        public async Task<Message> GetBankAccountByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Area List ",
                    data = await Task.FromResult((from a in _context.TblBankAccount
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join b in _context.TblBank on a.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                                                  where a.IsActive == true && a.IntClientId == UId
                                                  select new GetBankAccountDTO()
                                                  {
                                                      BankAccountId = a.IntBankAccountId,
                                                      BankAccountName = c.StrClientName,
                                                      BankAccountNo = a.StrBankAccountNo,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
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
        public async Task<object> CreateBankAccount(CreateBankAccountDTO postBankAccount)
        {
            try
            {
                var detalis = new TblBankAccount
                {
                    StrBankAccountName = postBankAccount.BankAccountName,
                    StrBankAccountNo = postBankAccount.BankAccountNo,
                    IntBankId = postBankAccount.BankId,
                    StrBankName = postBankAccount.BankName,
                    IntBankBranchId = postBankAccount.BankBranchId,
                    StrBankBranchName = postBankAccount.BankBranchName,
                    IntClientId = postBankAccount.ClientId,
                    IntBusinessUnitId = postBankAccount.BusinessUnitId,
                    IntActionBy = postBankAccount.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBankAccount.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblBankAccount
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join b in _context.TblBank on a.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                              where a.IsActive == true && a.IntBankAccountId == detalis.IntBankAccountId
                              select new GetBankAccountDTO()
                              {
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountName = c.StrClientName,
                                  BankAccountNo = a.StrBankAccountNo,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Account Created Successfully.",
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
        public async Task<object> EditBankAccount(EditBankAccountDTO BankAccount)
        {
            try
            {
                TblBankAccount data = _context.TblBankAccount.First(x => x.IntBankAccountId == BankAccount.BankAccountId);

                data.IntBankAccountId = BankAccount.BankAccountId;
                data.StrBankAccountName = BankAccount.BankAccountName;
                data.StrBankAccountNo = BankAccount.BankAccountNo;
                data.IntBankId = BankAccount.BankId;
                data.StrBankName = BankAccount.BankName;
                data.IntBankBranchId = BankAccount.BankBranchId;
                data.StrBankBranchName = BankAccount.BankBranchName;
                data.IntClientId = BankAccount.ClientId;
                data.IntBusinessUnitId = BankAccount.BusinessUnitId;
                data.IntActionBy = BankAccount.ActionBy;
                data.DteLastActionDateTime = BankAccount.LastActionDateTime;

                _context.TblBankAccount.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBankAccount
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join b in _context.TblBank on a.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                              where a.IsActive == true && a.IntBankAccountId == BankAccount.BankAccountId
                              select new GetBankAccountDTO()
                              {
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountName = c.StrClientName,
                                  BankAccountNo = a.StrBankAccountNo,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Account Edited Successfully.",
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
        public async Task<object> CancelBankAccount(CancelBankAccountDTO BankAccount)
        {
            try
            {
                TblBankAccount data = _context.TblBankAccount.First(x => x.IntBankAccountId == BankAccount.BankAccountId);
                data.IntActionBy = BankAccount.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblBankAccount.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblBankAccount
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join b in _context.TblBank on a.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on a.IntBankBranchId equals br.IntBankBranchId
                              where a.IsActive == false && a.IntBankAccountId == BankAccount.BankAccountId
                              select new GetBankAccountDTO()
                              {
                                  BankAccountId = a.IntBankAccountId,
                                  BankAccountName = c.StrClientName,
                                  BankAccountNo = a.StrBankAccountNo,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Account  Cancelled Successfully.",
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
