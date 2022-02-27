using ControlPanel.DbContexts;
using ControlPanel.DTO.Currency;
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
    public class Currency : ICurrency
    {
        public readonly iBOSContext _context;

        public Currency(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetCurrencyAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Currency Iteme List ",
                    data = await Task.FromResult((from c in _context.TblCurrency
                                                  where c.IsActive == true
                                                  select new GetCurrencyDTO()
                                                  {
                                                      CurrencyId = c.IntCurrencyId,
                                                      CurrencyName = c.StrCurrencyName,
                                                      CurrencyCode = c.StrCurrencyCode

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                Message m = new Message();
                Console.WriteLine(m.data);
                 

                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetCurrencyById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Currency Iteme List By Id ",
                    data = await Task.FromResult((from c in _context.TblCurrency
                                                  where c.IsActive == true && c.IntCurrencyId == Id
                                                  select new GetCurrencyDTO()
                                                  {
                                                      CurrencyId = c.IntCurrencyId,
                                                      CurrencyName = c.StrCurrencyName,
                                                      CurrencyCode = c.StrCurrencyCode

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
