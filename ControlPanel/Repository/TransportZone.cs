using ControlPanel.DbContexts;
using ControlPanel.DTO.TransportZone;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class TransportZone : ITransportZone
    {
        public readonly iBOSContext _context;
        public TransportZone(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTransportZoneAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Zone List: ",
                    data = await Task.FromResult((from so in _context.TblTransportZone
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintid equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true
                                                  select new GetTransportZoneDTO()
                                                  {
                                                      TransportZoneId = so.IntTransportZoneId,
                                                      TransportZoneName = so.StrTransportZoneName,
                                                      BusinessUintid = so.IntBusinessUintid,
                                                      BusinessUintName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetTransportZoneById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Zone List By  Id",
                    data = await Task.FromResult((from so in _context.TblTransportZone
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintid equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntTransportZoneId == Id
                                                  select new GetTransportZoneDTO()
                                                  {
                                                      TransportZoneId = so.IntTransportZoneId,
                                                      TransportZoneName = so.StrTransportZoneName,
                                                      BusinessUintid = so.IntBusinessUintid,
                                                      BusinessUintName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetTransportZoneByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Zone List By  Id",
                    data = await Task.FromResult((from so in _context.TblTransportZone
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintid equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntClientId == CId
                                                  select new GetTransportZoneDTO()
                                                  {
                                                      TransportZoneId = so.IntTransportZoneId,
                                                      TransportZoneName = so.StrTransportZoneName,
                                                      BusinessUintid = so.IntBusinessUintid,
                                                      BusinessUintName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetTransportZoneByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Transport Zone List By  Id",
                    data = await Task.FromResult((from so in _context.TblTransportZone
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintid equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntBusinessUintid == UId
                                                  select new GetTransportZoneDTO()
                                                  {
                                                      TransportZoneId = so.IntTransportZoneId,
                                                      TransportZoneName = so.StrTransportZoneName,
                                                      BusinessUintid = so.IntBusinessUintid,
                                                      BusinessUintName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
