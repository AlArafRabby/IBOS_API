using ControlPanel.DbContexts;
using ControlPanel.DTO.ShippingType;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class ShippingType : IShippingType
    {
        public readonly iBOSContext _context;
        public ShippingType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetShippingTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Shipping Type List: ",
                    data = await Task.FromResult((from so in _context.TblShippingType
                                                  where so.IsActive == true
                                                  select new GetShippingTypeDTO()
                                                  {
                                                      ShippingTypeId = so.IntShippingTypeId,
                                                      ShippingTypeName = so.StrShippingTypeName

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
        public async Task<Message> GetShippingTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Shipping Type List By  Id",
                    data = await Task.FromResult((from so in _context.TblShippingType
                                                  where so.IsActive == true && so.IntShippingTypeId == Id
                                                  select new GetShippingTypeDTO()
                                                  {
                                                      ShippingTypeId = so.IntShippingTypeId,
                                                      ShippingTypeName = so.StrShippingTypeName

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
