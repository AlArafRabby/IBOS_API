using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesOrderGroup;
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
    public class SalesOrderGroup : ISalesOrderGroup
    {
        public readonly iBOSContext _context;
        public SalesOrderGroup(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesOrderGroupAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Order Group List ",
                    data = await Task.FromResult((from so in _context.TblSalesOrderGroup
                                                  where so.IsActive == true
                                                  select new GetSalesOrderGroupDTO()
                                                  {
                                                      SalesOrderGroupId = so.IntSalesOrderGroupId,
                                                      SalesOrderGroupName = so.StrSalesOrderGroupName
                                                     
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
