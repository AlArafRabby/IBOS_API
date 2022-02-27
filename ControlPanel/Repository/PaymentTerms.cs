using ControlPanel.DbContexts;
using ControlPanel.DTO.PaymentTerms;
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
    public class PaymentTerms : IPaymentTerms
    {
        public readonly iBOSContext _context;
        public PaymentTerms(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPaymentTermsAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Payment Terms List ",
                    data = await Task.FromResult((from pt in _context.TblPaymentTerms
                                                  where pt.IsActive == true
                                                  select new GetPaymentTermsDTO()
                                                  {
                                                      PaymentTerms = pt.IntPaymentTerms,
                                                      PaymentTermsName = pt.StrPaymentTermsName,
                                                      PaymentTermsCode = pt.StrPaymentTermsCode


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
