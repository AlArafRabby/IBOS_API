using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.DTO.OrderReferanceType;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Repository
{
    public class OrderReferanceType : IOrderReferanceType
    {
        public readonly iBOSContext _context;
        public OrderReferanceType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetOrderReferanceTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Order Referance Type List ",
                    data = await Task.FromResult((from pt in _context.TblOrderReferanceType
                                                  where pt.IsActive == true
                                                  select new GetOrderReferanceTypeDTO()
                                                  {
                                                      OrderReferanceTypeId = pt.IntOrderReferanceTypeId,
                                                      OrderReferanceTypeName = pt.StrOrderReferanceTypeName


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
