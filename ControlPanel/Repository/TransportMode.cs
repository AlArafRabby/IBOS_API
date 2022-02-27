using ControlPanel.DbContexts;
using ControlPanel.DTO.TransportMode;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class TransportMode : ITransportMode
    {
        public readonly iBOSContext _context;
        public TransportMode(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTransportModeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Mode List: ",
                    data = await Task.FromResult((from so in _context.TblTransportMode
                                                  where so.IsActive == true
                                                  select new GetTransportModeDTO()
                                                  {
                                                      TransportModeId = so.IntTransportModeId,
                                                      TransportModeName = so.StrTransportModeName

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
        public async Task<Message> GetTransportModeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Mode List By Id",
                    data = await Task.FromResult((from so in _context.TblTransportMode
                                                  where so.IsActive == true &&  so.IntTransportModeId == Id
                                                  select new GetTransportModeDTO()
                                                  {
                                                      TransportModeId = so.IntTransportModeId,
                                                      TransportModeName = so.StrTransportModeName

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
