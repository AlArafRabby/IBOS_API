using ControlPanel.DbContexts;
using ControlPanel.DTO.BankBranchBusinessUnit;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BankBranchBusinessUnit : IBankBranchBusinessUnit
    {
        public readonly iBOSContext _context;
        public BankBranchBusinessUnit(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBankBranchBusinessUnitAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Branch Business Unit List ",
                    data = await Task.FromResult((from bbu in _context.TblBankBranchBusinessUnit
                                                  join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                                                  join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                                                  where bbu.IsActive == true
                                                  select new GetBankBranchBusinessUnitDTO()
                                                  {
                                                      ClientId = bbu.IntClientid,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      BusinessName = bbu.StrBusinessName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ActionBy = bbu.IntActionBy,
                                                      LastActionDateTime = bbu.DteLastActionDateTime


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
        public async Task<Message> GetBankBranchBusinessUnitById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Branch Business Unit List By Id ",
                    data = await Task.FromResult((from bbu in _context.TblBankBranchBusinessUnit
                                                  join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                                                  join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                                                  where bbu.IsActive == true && bbu.IntConfigId==Id
                                                  select new GetBankBranchBusinessUnitDTO()
                                                  {
                                                      ClientId = bbu.IntClientid,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      BusinessName = bbu.StrBusinessName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ActionBy = bbu.IntActionBy,
                                                      LastActionDateTime = bbu.DteLastActionDateTime

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
        public async Task<Message> GetBankBranchBusinessUnitByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Branch Business Unit List By Unit Id ",
                    data = await Task.FromResult((from bbu in _context.TblBankBranchBusinessUnit
                                                  join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                                                  join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                                                  where bbu.IsActive == true && bbu.IntBusinessUnitId==UId
                                                  select new GetBankBranchBusinessUnitDTO()
                                                  {
                                                      ClientId = bbu.IntClientid,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      BusinessName = bbu.StrBusinessName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ActionBy = bbu.IntActionBy,
                                                      LastActionDateTime = bbu.DteLastActionDateTime

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
        public async Task<Message> GetBankBranchBusinessUnitByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Bank Branch Business Unit List By Client Id ",
                    data = await Task.FromResult((from bbu in _context.TblBankBranchBusinessUnit
                                                  join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                                                  join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                                                  join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                                                  where bbu.IsActive == true && bbu.IntClientid == CId
                                                  select new GetBankBranchBusinessUnitDTO()
                                                  {
                                                      ClientId = bbu.IntClientid,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      BusinessName = bbu.StrBusinessName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      BankBranchId = br.IntBankBranchId,
                                                      BankBranchName = br.StrBankBranchName,
                                                      ActionBy = bbu.IntActionBy,
                                                      LastActionDateTime = bbu.DteLastActionDateTime

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
        public async Task<object> CreateBankBranchBusinessUnit(CreateBankBranchBusinessUnitDTO postBankBranchBusinessUnit)
        {
            try
            {
                var detalis = new TblBankBranchBusinessUnit
                {
                    IntClientid = postBankBranchBusinessUnit.Clientid,
                    IntBusinessUnitId = postBankBranchBusinessUnit.BusinessUnitId,
                    StrBusinessName = postBankBranchBusinessUnit.BusinessName,
                    IntBankId = postBankBranchBusinessUnit.BankId,
                    StrBankName = postBankBranchBusinessUnit.BankName,
                    IntBankBranchId = postBankBranchBusinessUnit.BankBranchId,
                    StrBankBranchName = postBankBranchBusinessUnit.BankBranchName,
                    IntActionBy = postBankBranchBusinessUnit.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBankBranchBusinessUnit.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bbu in _context.TblBankBranchBusinessUnit
                              join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                              join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                              where bbu.IsActive == true && bbu.IntConfigId == detalis.IntConfigId
                              select new GetBankBranchBusinessUnitDTO()
                              {
                                  ClientId = bbu.IntClientid,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  BusinessName = bbu.StrBusinessName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ActionBy = bbu.IntActionBy,
                                  LastActionDateTime = bbu.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Branch Business Unit Created Successfully.",
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
        public async Task<object> EditBankBranchBusinessUnit(EditBankBranchBusinessUnitDTO BankBranchBusinessUnit)
        {
            try
            {
                TblBankBranchBusinessUnit data = _context.TblBankBranchBusinessUnit.First(x => x.IntConfigId == BankBranchBusinessUnit.ConfigId);

                data.IntConfigId = BankBranchBusinessUnit.ConfigId;
                data.IntClientid = BankBranchBusinessUnit.Clientid;
                data.IntBusinessUnitId = BankBranchBusinessUnit.BusinessUnitId;
                data.StrBusinessName = BankBranchBusinessUnit.BusinessName;
                data.IntBankId = BankBranchBusinessUnit.BankId;
                data.StrBankName = BankBranchBusinessUnit.BankName;
                data.IntBankBranchId = BankBranchBusinessUnit.BankBranchId;
                data.StrBankBranchName = BankBranchBusinessUnit.BankBranchName;
                data.IntActionBy = BankBranchBusinessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBankBranchBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bbu in _context.TblBankBranchBusinessUnit
                              join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                              join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                              where bbu.IsActive == true && bbu.IntConfigId == BankBranchBusinessUnit.ConfigId
                              select new GetBankBranchBusinessUnitDTO()
                              {
                                  ClientId = bbu.IntClientid,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  BusinessName = bbu.StrBusinessName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ActionBy = bbu.IntActionBy,
                                  LastActionDateTime = bbu.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Branch Business Unit Edited Successfully.",
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
        public async Task<object> CancelBankBranchBusinessUnit(CancelBankBranchBusinessUnitDTO BankBranchBusinessUnit)
        {
            try
            {
                TblBankBranchBusinessUnit data = _context.TblBankBranchBusinessUnit.First(x => x.IntConfigId == BankBranchBusinessUnit.ConfigId);

                data.IntConfigId = BankBranchBusinessUnit.ConfigId;
                data.IntActionBy = BankBranchBusinessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBankBranchBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bbu in _context.TblBankBranchBusinessUnit
                              join bu in _context.TblBusinessUnit on bbu.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join b in _context.TblBank on bbu.IntBankId equals b.IntBankId
                              join br in _context.TblBankBranch on bbu.IntBankBranchId equals br.IntBankBranchId
                              join cl in _context.TblClient on bbu.IntClientid equals cl.IntClientId
                              where bbu.IsActive == false && bbu.IntConfigId == BankBranchBusinessUnit.ConfigId
                              select new GetBankBranchBusinessUnitDTO()
                              {
                                  ClientId = bbu.IntClientid,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  BusinessName = bbu.StrBusinessName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  BankBranchId = br.IntBankBranchId,
                                  BankBranchName = br.StrBankBranchName,
                                  ActionBy = bbu.IntActionBy,
                                  LastActionDateTime = bbu.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Branch Business Unit Cancelled Successfully.",
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
