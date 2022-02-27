using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemPlantWarehouse;
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
    public class ItemPlantWarehouse : IItemPlantWarehouse
    {
        public readonly iBOSContext _context;
        public ItemPlantWarehouse(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemPlantWarehouseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Plant Ware House List ",
                    data = await Task.FromResult((from ip in _context.TblItemPlantWarehouse
                                           join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                           join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                           join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                           join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                           select new GetItemPlantWarehouseDTO()
                                           {
                                               Id = ip.IntConfigId,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               PlantId = p.IntPlantId,
                                               PlantName = p.StrPlantName,
                                               ItemId = i.IntItemId,
                                               ItemName = i.StrItemName,
                                               WarehouseId = w.IntWarehouseId,
                                               WarehouseName = w.StrWarehouseName,
                                               LastActionDateTime = ip.DteLastActionDateTime,
                                               ActionBy = ip.IntActionBy

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
        public async Task<Message> GetItemPlantWarehouseById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = " Item Plant Ware House List by Id.",
                    data =  await Task.FromResult((from ip in _context.TblItemPlantWarehouse
                                           join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                           join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                           join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                           join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                           where ip.IntConfigId == Id && ip.IsActive == true
                                           select new GetItemPlantWarehouseDTO()
                                           {
                                               Id = ip.IntConfigId,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               PlantId = p.IntPlantId,
                                               PlantName = p.StrPlantName,
                                               ItemId = i.IntItemId,
                                               ItemName = i.StrItemName,
                                               WarehouseId = w.IntWarehouseId,
                                               WarehouseName = w.StrWarehouseName,
                                               LastActionDateTime = ip.DteLastActionDateTime,
                                               ActionBy = ip.IntActionBy

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
        public async Task<Message> GetItemPlantWarehouseByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Plant Ware House List ",
                    data  = await Task.FromResult((from ip in _context.TblItemPlantWarehouse
                                           join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                           join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                           join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                           join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                           where ip.IntBusinessUnitId == UId && ip.IsActive == true
                                           select new GetItemPlantWarehouseDTO()
                                           {
                                               Id = ip.IntConfigId,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               PlantId = p.IntPlantId,
                                               PlantName = p.StrPlantName,
                                               ItemId = i.IntItemId,
                                               ItemName = i.StrItemName,
                                               WarehouseId = w.IntWarehouseId,
                                               WarehouseName = w.StrWarehouseName,
                                               LastActionDateTime = ip.DteLastActionDateTime,
                                               ActionBy = ip.IntActionBy

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
        public async Task<Message> GetItemPlantWarehouseByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = " Item Plant Ware House List by Client Id.",
                    data = await Task.FromResult((from ip in _context.TblItemPlantWarehouse
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetItemPlantWarehouseDTO()
                                                  {
                                                      Id = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      WarehouseId = w.IntWarehouseId,
                                                      WarehouseName = w.StrWarehouseName,
                                                      LastActionDateTime = ip.DteLastActionDateTime,
                                                      ActionBy = ip.IntActionBy

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
        public async Task<object> CreateItemPlantWarehouse(CreateItemPlantWarehouseDTO postItemPlantWarehouse)
        {
            try
            {
                var detalis = new TblItemPlantWarehouse
                {
                    IntClientId = postItemPlantWarehouse.ClientId,
                    IntBusinessUnitId = postItemPlantWarehouse.BusinessUnitId,
                    IntPlantId = postItemPlantWarehouse.PlantId,
                    IntItemId = postItemPlantWarehouse.ItemId,
                    IntWarehouseId = postItemPlantWarehouse.WarehouseId,
                    IntActionBy = postItemPlantWarehouse.ActionBy,
                    DteLastActionDateTime = postItemPlantWarehouse.LastActionDateTime
                };
                await _context.TblItemPlantWarehouse.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblItemPlantWarehouse
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                              where ip.IntConfigId == detalis.IntConfigId && ip.IsActive == true
                              select new GetItemPlantWarehouseDTO()
                              {
                                  Id = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  WarehouseId = w.IntWarehouseId,
                                  WarehouseName = w.StrWarehouseName,
                                  LastActionDateTime = ip.DteLastActionDateTime,
                                  ActionBy = ip.IntActionBy

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Plant Ware House Create Successfully.",
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
        public async Task<object> EditItemPlantWarehouse(EidtItemPlantWarehouseDTO putItemPlantWarehouse)
        {
            try
            {
                TblItemPlantWarehouse data = _context.TblItemPlantWarehouse.First(x => x.IntConfigId == putItemPlantWarehouse.Id);                
                data.IntActionBy = putItemPlantWarehouse.ActionBy;
                data.IntPlantId=putItemPlantWarehouse.PlantId;
                data.IntItemId = putItemPlantWarehouse.ItemId;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntWarehouseId = putItemPlantWarehouse.WarehouseId;

                _context.TblItemPlantWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemPlantWarehouse
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                              where ip.IntConfigId == putItemPlantWarehouse.Id && ip.IsActive == true
                              select new GetItemPlantWarehouseDTO()
                              {
                                  Id = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  WarehouseId = w.IntWarehouseId,
                                  WarehouseName = w.StrWarehouseName,
                                  LastActionDateTime = ip.DteLastActionDateTime,
                                  ActionBy = ip.IntActionBy

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item plant ware house Edit Successfully.",
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
        public async Task<object> CancelItemPlantWarehouse(CancelItemPlantWarehouseDTO putItemPlantWarehouse)
        {
            try
            {
                TblItemPlantWarehouse data = _context.TblItemPlantWarehouse.First(x => x.IntConfigId == putItemPlantWarehouse.Id);
                
                data.IntActionBy = putItemPlantWarehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemPlantWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemPlantWarehouse
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              join w in _context.TblWarehouse on ip.IntWarehouseId equals w.IntWarehouseId
                              where ip.IntConfigId == putItemPlantWarehouse.Id && ip.IsActive == false
                              select new GetItemPlantWarehouseDTO()
                              {
                                  Id = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  WarehouseId = w.IntWarehouseId,
                                  WarehouseName = w.StrWarehouseName,
                                  LastActionDateTime = ip.DteLastActionDateTime,
                                  ActionBy = ip.IntActionBy

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Plant ware house Cancel Successfully.",
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
