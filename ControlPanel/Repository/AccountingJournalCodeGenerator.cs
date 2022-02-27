using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingJournalCodeGenerator;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.Models.iBOS;

namespace ControlPanel.Repository
{
    public class AccountingJournalCodeGenerator : IAccountingJournalCodeGenerator
    {
        public readonly iBOSContext _context;
        public AccountingJournalCodeGenerator(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> CreateAccountingJournalCodeGenerator(CreateAccountingJournalCodeGenerator postAccountingJournalCodeGenerator)
        {
            try
            {
                var detalis = new TblAccountingJournalCodeGenerator
                {
                    IntClientId = postAccountingJournalCodeGenerator.ClientId,
                    IntBusinessUintId = postAccountingJournalCodeGenerator.BusinessUintId,
                    IntAccountingJournalTypeId = postAccountingJournalCodeGenerator.AccountingJournalTypeId,
                    StrAccountingJournalTypeName = postAccountingJournalCodeGenerator.AccountingJournalTypeName,
                    IntYear = postAccountingJournalCodeGenerator.Year,
                    IntMonth = postAccountingJournalCodeGenerator.Month,
                    IntCount = postAccountingJournalCodeGenerator.Count
                };
                await _context.TblAccountingJournalCodeGenerator.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAccountingJournalCodeGenerator                                
                                  where a.IntClientId == detalis.IntClientId && a.IntBusinessUintId == detalis.IntBusinessUintId && a.IntAccountingJournalTypeId == detalis.IntAccountingJournalTypeId
                                  select new GetAccountingJournalCodeGenerator()
                                  {
                                      ClientId = a.IntClientId,
                                      BusinessUintId = a.IntBusinessUintId,
                                      AccountingJournalTypeId = a.IntAccountingJournalTypeId,
                                      AccountingJournalTypeName = a.StrAccountingJournalTypeName,
                                      Year = a.IntYear,
                                      Month = a.IntMonth,
                                      Count = a.IntCount
                                  };
                var successmsg = new Message
                {
                    status = true,
                    message = "Accounting Journal Code Generator Save Successfully.",
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

        public Task<object> CreateAccountGroup(CreateAccountingJournalCodeGenerator postAccountingJournalCodeGeneratorlong, long UnitId)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> GetAccountingJournalCodeGeneratorId(CreateAccountingJournalCodeGenerator postAccountingJournalCodeGeneratorlong)
        {
            try
            {
                var data = _context.TblAccountingJournalCodeGenerator.Where(x => x.IntClientId == 1);
                var purchCount = (from purchase in _context.TblAccountingJournalCodeGenerator.Where(x => x.IntClientId == 1) select purchase).Count();
                if (data.Count() > 0)
                {
                    var detalis = new TblAccountingJournalCodeGenerator
                    {
                        IntClientId = postAccountingJournalCodeGeneratorlong.ClientId,
                        IntBusinessUintId = postAccountingJournalCodeGeneratorlong.BusinessUintId,
                        IntAccountingJournalTypeId = postAccountingJournalCodeGeneratorlong.AccountingJournalTypeId,
                        StrAccountingJournalTypeName = postAccountingJournalCodeGeneratorlong.AccountingJournalTypeName,
                        IntYear = postAccountingJournalCodeGeneratorlong.Year,
                        IntMonth = postAccountingJournalCodeGeneratorlong.Month,
                        IntCount = postAccountingJournalCodeGeneratorlong.Count + 1
                    };
                    await _context.TblAccountingJournalCodeGenerator.AddAsync(detalis);
                    await _context.SaveChangesAsync();

                }
               

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Category Get Successfully.",
                    data = postAccountingJournalCodeGeneratorlong
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

        public Task<Message> GetAccountingJournalCodeGeneratorId(long UnitId)
        {
            throw new NotImplementedException();
        }
    }
}
