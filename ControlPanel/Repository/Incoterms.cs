using ControlPanel.DbContexts;
using ControlPanel.DTO.IncoTerms;
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
    public class Incoterms: IIncoterms
    {
        public readonly iBOSContext _context;
        public Incoterms(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetIncoTermsAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Co Terms List ",
                    data = await Task.FromResult((from sp in _context.TblIncoTerms
                                                  where sp.IsActive == true
                                                  select new GetIncoTermsDTO()
                                                  {
                                                      IncotermsId = sp.IntIncotermsId,
                                                      IncotermsName = sp.StrIncotermsName,
                                                      IncotermsCode = sp.StrIncotermsCode
                                                      
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
    }
}
