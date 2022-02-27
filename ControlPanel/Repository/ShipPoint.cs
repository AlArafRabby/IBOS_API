using ControlPanel.DbContexts;
using ControlPanel.DTO.ShipPoint;
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
    public class ShipPoint : IShipPoint
    {
        public readonly iBOSContext _context;
        public ShipPoint(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetShipPointAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point List ",
                    data = await Task.FromResult((from sp in _context.TblShipPoint
                                                  join b in _context.TblBusinessUnit on sp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on sp.IntClientId equals cl.IntClientId
                                                  where sp.IsActive == true
                                                  select new GetShipPointDTO()
                                                  {
                                                      ShipPointId = sp.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      Address = sp.StrAddress,
                                                      ClientId = sp.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = sp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = sp.IntActionBy,
                                                      LastActionDateTime = sp.DteLastActionDateTime

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
        public async Task<Message> GetShipPointById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point List By Id ",
                    data = await Task.FromResult((from sp in _context.TblShipPoint
                                                  join b in _context.TblBusinessUnit on sp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on sp.IntClientId equals cl.IntClientId
                                                  where sp.IsActive == true && sp.IntShipPointId == Id
                                                  select new GetShipPointDTO()
                                                  {
                                                      ShipPointId = sp.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      Address = sp.StrAddress,
                                                      ClientId = sp.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = sp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = sp.IntActionBy,
                                                      LastActionDateTime = sp.DteLastActionDateTime

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
        public async Task<Message> GetShipPointByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point List By Client Id ",
                    data = await Task.FromResult((from sp in _context.TblShipPoint
                                                  join b in _context.TblBusinessUnit on sp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on sp.IntClientId equals cl.IntClientId
                                                  where sp.IsActive == true && sp.IntClientId == CId
                                                  select new GetShipPointDTO()
                                                  {
                                                      ShipPointId = sp.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      Address = sp.StrAddress,
                                                      ClientId = sp.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = sp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = sp.IntActionBy,
                                                      LastActionDateTime = sp.DteLastActionDateTime

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
        public async Task<Message> GetShipPointByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point List By Unit Id ",
                    data = await Task.FromResult((from sp in _context.TblShipPoint
                                                  join b in _context.TblBusinessUnit on sp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on sp.IntClientId equals cl.IntClientId
                                                  where sp.IsActive == true && sp.IntBusinessUnitId == UId
                                                  select new GetShipPointDTO()
                                                  {
                                                      ShipPointId = sp.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      Address = sp.StrAddress,
                                                      ClientId = sp.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = sp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = sp.IntActionBy,
                                                      LastActionDateTime = sp.DteLastActionDateTime

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
