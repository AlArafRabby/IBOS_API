using ControlPanel.DbContexts;
using ControlPanel.DTO.BalanceCheckType;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BalanceCheckType : IBalanceCheckType
    {
        public readonly iBOSContext _context;
        public BalanceCheckType(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> GetBalanceCheckTypeAll()
        {
            try
            {

                return new Message
                {
                    status = true,
                    message = "All Balance Check Type List .",
                    data = await _context.TblBalanceCheckType.Where(x => x.IsActive == true).Select(t => new GetBalanceCheckTypeDTO()
                    {
                        BalanceCheckTypeId = t.IntBalanceCheckTypeId,
                        BalanceCheckName = t.StrBalanceCheckName

                    }).ToListAsync()
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
