using ControlPanel.DbContexts;
using ControlPanel.DTO.PlantWarehouse;
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
    public class PlantWarehouse : IPlantWarehouse
    {
        public readonly iBOSContext _context;
        public PlantWarehouse(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPlantWarehouseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Plant Warehouse List: ",
                    data = await Task.FromResult((from ip in _context.TblPlantWarehouse
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                   join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId 
                                                  where ip.IsActive == true
                                                   select new GetPlantWarehouseDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       WarehouseId = ip.IntWarehouseId,
                                                       WarehouseName = ip.StrWarehouseName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       PlantId =p.IntPlantId,
                                                       PlantName = ip.StrPlantName,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = ip.IntActionBy,
                                                       LastActionDateTime = ip.DteLastActionDateTime
                                               
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
        public async Task<Message> GetPlantWarehouseById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All PlantWarehouse List by Id: ",
                    data  = await Task.FromResult((from ip in _context.TblPlantWarehouse
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                   join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                                   join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                   where ip.IsActive == true && ip.IntConfigId == Id
                                                   select new GetPlantWarehouseDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       WarehouseId = ip.IntWarehouseId,
                                                       WarehouseName = ip.StrWarehouseName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       PlantId = p.IntPlantId,
                                                       PlantName = ip.StrPlantName,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = ip.IntActionBy,
                                                       LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<Message> GetPlantWarehouseByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All PlantWarehouse List by Client Id: ",
                    data = await Task.FromResult((from ip in _context.TblPlantWarehouse
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                                  where ip.IsActive == true && ip.IntConfigId == CId
                                                  select new GetPlantWarehouseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      WarehouseId = ip.IntWarehouseId,
                                                      WarehouseName = ip.StrWarehouseName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = ip.StrPlantName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<object> CreatePlantWarehouse(CreatePlantWarehouseDTO postPlantWarehouse)
        {
            try
            { 
                var detalis = new TblPlantWarehouse
                {
                    IntClientId = postPlantWarehouse.ClientId,
                    IntWarehouseId = postPlantWarehouse.WarehouseId,
                    StrWarehouseName = postPlantWarehouse.WarehouseName,
                    IntPlantId = postPlantWarehouse.PlantId,
                    StrPlantName = postPlantWarehouse.PlantName,
                    IntBusinessUnitId = postPlantWarehouse.BusinessUnitId,
                    IntActionBy = postPlantWarehouse.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                    
                };
                await _context.TblPlantWarehouse.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblPlantWarehouse
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                  join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetPlantWarehouseDTO()
                                  {
                                      ConfigId = ip.IntConfigId,
                                      WarehouseId = ip.IntWarehouseId,
                                      WarehouseName = ip.StrWarehouseName,
                                      ClientId = ip.IntClientId,
                                      ClientName = c.StrClientName,
                                      PlantId = p.IntPlantId,
                                      PlantName = ip.StrPlantName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Warehouse Created Successfully.",
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
        public async Task<object> EditPlantWarehouse(EditPlantWarehouseDTO PlantWarehouse)
        {
            try
            {
                TblPlantWarehouse data = _context.TblPlantWarehouse.First(x => x.IntConfigId == PlantWarehouse.ConfigId);
                data.IntConfigId = PlantWarehouse.ConfigId;
                data.IntWarehouseId = PlantWarehouse.WarehouseId;
                data.StrWarehouseName = PlantWarehouse.WarehouseName;
                data.IntPlantId = PlantWarehouse.PlantId;
                data.StrPlantName = PlantWarehouse.PlantName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = PlantWarehouse.ActionBy;

                _context.TblPlantWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblPlantWarehouse
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == true && ip.IntConfigId == PlantWarehouse.ConfigId
                              select new GetPlantWarehouseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  WarehouseId = ip.IntWarehouseId,
                                  WarehouseName = ip.StrWarehouseName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  PlantId = p.IntPlantId,
                                  PlantName = ip.StrPlantName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Warehouse Edited Successfully.",
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
        public async Task<object> CancelPlantWarehouse(CancelPlantWarehouseDTO PlantWarehouse)
        {
            try
            {
                TblPlantWarehouse data = _context.TblPlantWarehouse.First(x => x.IntConfigId == PlantWarehouse.ConfigId);
                data.IntActionBy = PlantWarehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblPlantWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblPlantWarehouse
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == false && ip.IntConfigId == PlantWarehouse.ConfigId
                              select new GetPlantWarehouseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  WarehouseId = ip.IntWarehouseId,
                                  WarehouseName = ip.StrWarehouseName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  PlantId = p.IntPlantId,
                                  PlantName = ip.StrPlantName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Warehouse Cancelled Successfully.",
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
