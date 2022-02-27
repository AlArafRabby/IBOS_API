using ControlPanel.DbContexts;
using ControlPanel.DTO.GeneralLedger;
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
    public class GeneralLedger : IGeneralLedger
    {
        public readonly iBOSContext _context;
        public GeneralLedger(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetGeneralLedgerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All GeneralLedger List ",
                    data = await Task.FromResult((from bp in _context.TblGeneralLedger
                                                  join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                                                  join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                                                  join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                                                  join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                                                  where bp.IsActive == true
                                                  select new GetGeneralLedgerDTO()
                                                  {
                                                        GeneralLedgerId = bp.IntGeneralLedgerId,
                                                        ClientId = b.IntClientId,
                                                        ClientName = b.StrClientName,
                                                        AccountGroupId = ag.IntAccountGroupId,
                                                        AccountGroupName = ag.StrAccountGroupName,
                                                        AccountClassId = ac.IntAccountClassId,
                                                        AccountClassName = ac.StrAccountClassName,
                                                        AccountCategoryId = acat.IntAccountCategoryId,
                                                        AccountCategoryName = acat.StrAccountCategoryName,
                                                        GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                                        GeneralLedgerName = bp.StrGeneralLedgerName,
                                                        ActionBy = bp.IntActionBy,
                                                        LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetGeneralLedgerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "GeneralLedger List By Id.",
                    data = await Task.FromResult((from bp in _context.TblGeneralLedger
                                                  join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                                                  join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                                                  join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                                                  join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                                                  where bp.IsActive == true && bp.IntGeneralLedgerId == Id
                                                  select new GetGeneralLedgerDTO()
                                                  {
                                                      GeneralLedgerId = bp.IntGeneralLedgerId,
                                                      ClientId = b.IntClientId,
                                                      ClientName = b.StrClientName,
                                                      AccountGroupId = ag.IntAccountGroupId,
                                                      AccountGroupName = ag.StrAccountGroupName,
                                                      AccountClassId = ac.IntAccountClassId,
                                                      AccountClassName = ac.StrAccountClassName,
                                                      AccountCategoryId = acat.IntAccountCategoryId,
                                                      AccountCategoryName = acat.StrAccountCategoryName,
                                                      GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                                      GeneralLedgerName = bp.StrGeneralLedgerName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetGeneralLedgerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "GeneralLedger List By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblGeneralLedger
                                                  join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                                                  join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                                                  join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                                                  join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetGeneralLedgerDTO()
                                                  {
                                                      GeneralLedgerId = bp.IntGeneralLedgerId,
                                                      ClientId = b.IntClientId,
                                                      ClientName = b.StrClientName,
                                                      AccountGroupId = ag.IntAccountGroupId,
                                                      AccountGroupName = ag.StrAccountGroupName,
                                                      AccountClassId = ac.IntAccountClassId,
                                                      AccountClassName = ac.StrAccountClassName,
                                                      AccountCategoryId = acat.IntAccountCategoryId,
                                                      AccountCategoryName = acat.StrAccountCategoryName,
                                                      GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                                      GeneralLedgerName = bp.StrGeneralLedgerName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<object> CreateGeneralLedger(CreateGeneralLedgerDTO postGeneralLedger)
        {
            try
            {
                var detalis = new TblGeneralLedger
                {
                    IntClientId = postGeneralLedger.ClientId,
                    IntAccountGroupId= postGeneralLedger.AccountGroupId, 
                    IntAccountClassId=postGeneralLedger.AccountClassId,
                    IntAccountCategoryId=postGeneralLedger.AccountCategoryId,
                    StrGeneralLedgerCode = postGeneralLedger.GeneralLedgerName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrGeneralLedgerName = postGeneralLedger.GeneralLedgerName,
                    IntActionBy = postGeneralLedger.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblGeneralLedger.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblGeneralLedger
                                  join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                                  join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                                  join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                                  join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                                  where bp.IsActive == true && bp.IntGeneralLedgerId == detalis.IntGeneralLedgerId
                                  select new GetGeneralLedgerDTO()
                                  {
                                      GeneralLedgerId = bp.IntGeneralLedgerId,
                                      ClientId = b.IntClientId,
                                      ClientName = b.StrClientName,
                                      AccountGroupId = ag.IntAccountGroupId,
                                      AccountGroupName = ag.StrAccountGroupName,
                                      AccountClassId = ac.IntAccountClassId,
                                      AccountClassName = ac.StrAccountClassName,
                                      AccountCategoryId = acat.IntAccountCategoryId,
                                      AccountCategoryName = acat.StrAccountCategoryName,
                                      GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                      GeneralLedgerName = bp.StrGeneralLedgerName,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "GeneralLedger Created Successfully.",
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
        public async Task<object> EditGeneralLedger(EditGeneralLedgerDTO generalledger)
        {
            try
            {
                TblGeneralLedger data = _context.TblGeneralLedger.First(x => x.IntGeneralLedgerId == generalledger.GeneralLedgerId);
                data.IntAccountGroupId = generalledger.AccountGroupId;
                data.IntAccountClassId = generalledger.AccountClassId;
                data.IntAccountCategoryId = generalledger.AccountCategoryId;
                data.StrGeneralLedgerCode = generalledger.GeneralLedgerCode;
                data.StrGeneralLedgerName = generalledger.GeneralLedgerName;
                data.IntActionBy = generalledger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblGeneralLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblGeneralLedger
                              join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                              join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                              join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                              join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                              where bp.IsActive == true && bp.IntGeneralLedgerId == generalledger.GeneralLedgerId
                              select new GetGeneralLedgerDTO()
                              {
                                  GeneralLedgerId = bp.IntGeneralLedgerId,
                                  ClientId = b.IntClientId,
                                  ClientName = b.StrClientName,
                                  AccountGroupId = ag.IntAccountGroupId,
                                  AccountGroupName = ag.StrAccountGroupName,
                                  AccountClassId = ac.IntAccountClassId,
                                  AccountClassName = ac.StrAccountClassName,
                                  AccountCategoryId = acat.IntAccountCategoryId,
                                  AccountCategoryName = acat.StrAccountCategoryName,
                                  GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                  GeneralLedgerName = bp.StrGeneralLedgerName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "GeneralLedger Edited Successfully.",
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
        public async Task<object> CancelGeneralLedger(CancelGeneralLedgerDTO generalledger)
        {
            try
            {
                TblGeneralLedger data = _context.TblGeneralLedger.First(x => x.IntGeneralLedgerId == generalledger.GeneralLedgerId);

                data.IntGeneralLedgerId = generalledger.GeneralLedgerId;
                data.IntActionBy = generalledger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                

                _context.TblGeneralLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblGeneralLedger
                              join b in _context.TblClient on bp.IntClientId equals b.IntClientId
                              join ag in _context.TblAccountGroup on bp.IntAccountGroupId equals ag.IntAccountGroupId
                              join ac in _context.TblAccountClass on bp.IntAccountClassId equals ac.IntAccountClassId
                              join acat in _context.TblAccountCategory on bp.IntAccountCategoryId equals acat.IntAccountCategoryId
                              where bp.IsActive == false && bp.IntGeneralLedgerId == generalledger.GeneralLedgerId
                              select new GetGeneralLedgerDTO()
                              {
                                  GeneralLedgerId = bp.IntGeneralLedgerId,
                                  ClientId = b.IntClientId,
                                  ClientName = b.StrClientName,
                                  AccountGroupId = ag.IntAccountGroupId,
                                  AccountGroupName = ag.StrAccountGroupName,
                                  AccountClassId = ac.IntAccountClassId,
                                  AccountClassName = ac.StrAccountClassName,
                                  AccountCategoryId = acat.IntAccountCategoryId,
                                  AccountCategoryName = acat.StrAccountCategoryName,
                                  GeneralLedgerCode = bp.StrGeneralLedgerCode,
                                  GeneralLedgerName = bp.StrGeneralLedgerName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "GeneralLedger Cancelled Successfully.",
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
