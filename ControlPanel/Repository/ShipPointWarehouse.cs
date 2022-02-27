using ControlPanel.DbContexts;
using ControlPanel.DTO.ShipPointWarehouse;
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
    public class ShipPointWarehouse : IShipPointWarehouse
    {
        public readonly iBOSContext _context;
        public ShipPointWarehouse(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetShipPointWarehouseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point Warehouse List ",
                    data = await Task.FromResult((from spw in _context.TblShipPointWarehouse
                                                  join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                                                  join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                                                  join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                                                  where spw.IsActive == true
                                                  select new GetShipPointWarehouseDTO()
                                                  {
                                                      ConfigId = spw.IntConfigId,
                                                      ClientId = spw.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = spw.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      WarehouseId = spw.IntWarehouseId,
                                                      WarehouseName = w.StrWarehouseName,
                                                      ShipPointId = spw.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      ActionBy = spw.IntActionBy,
                                                      LastActionDateTime = spw.DteLastActionDateTime

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
        public async Task<Message> GetShipPointWarehouseById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point Warehouse List by Id ",
                    data = await Task.FromResult((from spw in _context.TblShipPointWarehouse
                                                  join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                                                  join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                                                  join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                                                  where spw.IsActive == true && spw.IntConfigId == Id
                                                  select new GetShipPointWarehouseDTO()
                                                  {
                                                      ConfigId = spw.IntConfigId,
                                                      ClientId = spw.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = spw.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      WarehouseId = spw.IntWarehouseId,
                                                      WarehouseName = w.StrWarehouseName,
                                                      ShipPointId = spw.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      ActionBy = spw.IntActionBy,
                                                      LastActionDateTime = spw.DteLastActionDateTime

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
        public async Task<Message> GetShipPointWarehouseByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point Warehouse List by Unit Id ",
                    data = await Task.FromResult((from spw in _context.TblShipPointWarehouse
                                                  join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                                                  join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                                                  join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                                                  where spw.IsActive == true && spw.IntBusinessUnitId == UId
                                                  select new GetShipPointWarehouseDTO()
                                                  {
                                                      ConfigId = spw.IntConfigId,
                                                      ClientId = spw.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = spw.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      WarehouseId = spw.IntWarehouseId,
                                                      WarehouseName = w.StrWarehouseName,
                                                      ShipPointId = spw.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      ActionBy = spw.IntActionBy,
                                                      LastActionDateTime = spw.DteLastActionDateTime

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
        public async Task<Message> GetShipPointWarehouseByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Ship Point Warehouse List by Client Id ",
                    data = await Task.FromResult((from spw in _context.TblShipPointWarehouse
                                                  join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                                                  join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                                                  join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                                                  where spw.IsActive == true && spw.IntConfigId == CId
                                                  select new GetShipPointWarehouseDTO()
                                                  {
                                                      ConfigId = spw.IntConfigId,
                                                      ClientId = spw.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = spw.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      WarehouseId = spw.IntWarehouseId,
                                                      WarehouseName = w.StrWarehouseName,
                                                      ShipPointId = spw.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      ActionBy = spw.IntActionBy,
                                                      LastActionDateTime = spw.DteLastActionDateTime

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
        public async Task<object> CreateShipPointWarehouse(CreateShipPointWarehouseDTO postShipPointWarehouse)
        {
            try
            {
                var detalis = new TblShipPointWarehouse
                {
                    IntClientId = postShipPointWarehouse.ClientId,
                    IntBusinessUnitId = postShipPointWarehouse.BusinessUnitId,
                    IntWarehouseId = postShipPointWarehouse.WarehouseId,
                    IntShipPointId = postShipPointWarehouse.ShipPointId,
                    IntActionBy = postShipPointWarehouse.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblShipPointWarehouse.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from spw in _context.TblShipPointWarehouse
                                  join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                                  join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                                  join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                                  where spw.IsActive == true && spw.IntConfigId == detalis.IntConfigId
                                  select new GetShipPointWarehouseDTO()
                                  {
                                      ConfigId = spw.IntConfigId,
                                      ClientId = spw.IntClientId,
                                      ClientName = cl.StrClientName,
                                      BusinessUnitId = spw.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      WarehouseId = spw.IntWarehouseId,
                                      WarehouseName = w.StrWarehouseName,
                                      ShipPointId = spw.IntShipPointId,
                                      ShipPointName = sp.StrShipPointName,
                                      ActionBy = spw.IntActionBy,
                                      LastActionDateTime = spw.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "ShipPointWarehouse Created Successfully.",
                    data = detalisView
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }
        public async Task<object> EditShipPointWarehouse(EditShipPointWarehouseDTO ShipPointWarehouse)
        {
            try
            {
                TblShipPointWarehouse data = _context.TblShipPointWarehouse.First(x => x.IntConfigId == ShipPointWarehouse.ConfigId);
                data.IntConfigId = ShipPointWarehouse.ConfigId;
                data.IntClientId = ShipPointWarehouse.ClientId;
                data.IntBusinessUnitId = ShipPointWarehouse.BusinessUnitId;
                data.IntWarehouseId = ShipPointWarehouse.WarehouseId;
                data.IntShipPointId = ShipPointWarehouse.ShipPointId;
                data.IntActionBy = ShipPointWarehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblShipPointWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from spw in _context.TblShipPointWarehouse
                              join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                              join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                              join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                              join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                              where spw.IsActive == true && spw.IntConfigId == ShipPointWarehouse.ConfigId
                              select new GetShipPointWarehouseDTO()
                              {
                                  ConfigId = spw.IntConfigId,
                                  ClientId = spw.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = spw.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  WarehouseId = spw.IntWarehouseId,
                                  WarehouseName = w.StrWarehouseName,
                                  ShipPointId = spw.IntShipPointId,
                                  ShipPointName = sp.StrShipPointName,
                                  ActionBy = spw.IntActionBy,
                                  LastActionDateTime = spw.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "ShipPointWarehouse Edited Successfully.",
                    data = detalis
                };
                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }
        public async Task<object> CancelShipPointWarehouse(CancelShipPointWarehouseDTO ShipPointWarehouse)
        {
            try
            {
                TblShipPointWarehouse data = _context.TblShipPointWarehouse.First(x => x.IntConfigId == ShipPointWarehouse.ConfigId);

                data.IntConfigId = ShipPointWarehouse.ConfigId;
                data.IntActionBy = ShipPointWarehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblShipPointWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from spw in _context.TblShipPointWarehouse
                              join sp in _context.TblShipPoint on spw.IntShipPointId equals sp.IntShipPointId
                              join w in _context.TblWarehouse on spw.IntWarehouseId equals w.IntWarehouseId
                              join b in _context.TblBusinessUnit on spw.IntBusinessUnitId equals b.IntBusinessUnitId
                              join cl in _context.TblClient on spw.IntClientId equals cl.IntClientId
                              where spw.IsActive == false && spw.IntConfigId == ShipPointWarehouse.ConfigId
                              select new GetShipPointWarehouseDTO()
                              {
                                  ConfigId = spw.IntConfigId,
                                  ClientId = spw.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = spw.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  WarehouseId = spw.IntWarehouseId,
                                  WarehouseName = w.StrWarehouseName,
                                  ShipPointId = spw.IntShipPointId,
                                  ShipPointName = sp.StrShipPointName,
                                  ActionBy = spw.IntActionBy,
                                  LastActionDateTime = spw.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "ShipPointWarehouse Cancelled Successfully.",
                    data = detalis
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }
    }
}
