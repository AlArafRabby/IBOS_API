using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingJournalType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountingJournalType : IAccountingJournalType
    {
        public readonly iBOSContext _context;
        public AccountingJournalType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountingJournalTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Depreciation Type List ",
                    data = await Task.FromResult((from aj in _context.TblAccountingJournalType
                                                  select new GetAccountingJournalTypeDTO()
                                                  {
                                                      AccountingJournalTypeId = aj.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = aj.StrAccountingJournalTypeName

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
        public async Task<Message> GetAccountingJournalTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Depreciation Type List ",
                    data = await Task.FromResult((from aj in _context.TblAccountingJournalType
                                                  where aj.IntAccountingJournalTypeId == Id
                                                  select new GetAccountingJournalTypeDTO()
                                                  {
                                                      AccountingJournalTypeId = aj.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = aj.StrAccountingJournalTypeName

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

    }
}
