using ControlPanel.DbContexts;
using ControlPanel.DTO.DeliveryType;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class DeliveryType : IDeliveryType
    {
        public readonly iBOSContext _context;
        public DeliveryType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetDeliveryTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Delivery Type List ",
                    data = await Task.FromResult((from c in _context.TblDeliveryType
                                                  where c.IsActive == true
                                                  select new GetDeliveryTypeDTO()
                                                  {
                                                      DeliveryTypeId = c.IntDeliveryTypeId,
                                                      DeliveryTypeName = c.StrDeliveryTypeName,
                                                      
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
