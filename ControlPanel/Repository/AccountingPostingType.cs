using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingPostingType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountingPostingType : IAccountingPostingType
    {
        public readonly iBOSContext _context;
        public async Task<Message> GetAccountingPostingTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Depreciation Type List ",
                    data = await Task.FromResult((from aj in _context.TblAccountingPostingType

                                                  select new GetAccountingPostingTypeDTO()
                                                  {
                                                      AccountingPostingTypeId = aj.IntAccountingPostingTypeId,
                                                      AccountPostingTypeName = aj.StrAccountPostingTypeName

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
        public async Task<Message> GetAccountingPostingTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Depreciation Type List ",
                    data = await Task.FromResult((from aj in _context.TblAccountingPostingType
                                                  where aj.IntAccountingPostingTypeId == Id
                                                  select new GetAccountingPostingTypeDTO()
                                                  {
                                                      AccountingPostingTypeId = aj.IntAccountingPostingTypeId,
                                                      AccountPostingTypeName = aj.StrAccountPostingTypeName

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
