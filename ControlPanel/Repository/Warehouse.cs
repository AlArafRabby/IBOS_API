using ControlPanel.DbContexts;
using ControlPanel.DTO.Warehouse;
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
    public class Warehouse : IWarehouse
    {
        public readonly iBOSContext _context;
        public Warehouse(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetWarehouseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "WareHouse List.",
                    data = await Task.FromResult((from bp in _context.TblWarehouse
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId 
                                                  where bp.IsActive == true
                                                   select new GetWarehouseDTO()
                                                   {
                                                       WarehouseId = bp.IntWarehouseId,
                                                       WarehouseCode = bp.StrWarehouseCode,
                                                       WarehouseName = bp.StrWarehouseName,
                                                       WarehouseAddress = bp.StrWarehouseAddress,
                                                       ClientId = bp.IntClientId ,
                                                       ClientName = c.StrClientName ,
                                                       BusinessUnitId = bp.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = bp.IntActionBy,
                                                       LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetWarehouseById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "WareHouse List By Id.",
                    data = await Task.FromResult((from bp in _context.TblWarehouse
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntWarehouseId == Id && bp.IsActive == true
                                                   select new GetWarehouseDTO()
                                                   {
                                                       WarehouseId = bp.IntWarehouseId,
                                                       WarehouseCode = bp.StrWarehouseCode,
                                                       WarehouseName = bp.StrWarehouseName,
                                                       WarehouseAddress = bp.StrWarehouseAddress,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = bp.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = bp.IntActionBy,
                                                       LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetWarehouseByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "WareHouse List By Unit Id.",
                    data = await Task.FromResult((from bp in _context.TblWarehouse
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && b.IntBusinessUnitId == UId
                                                  select new GetWarehouseDTO()
                                                  {
                                                      WarehouseId = bp.IntWarehouseId,
                                                      WarehouseCode = bp.StrWarehouseCode,
                                                      WarehouseName = bp.StrWarehouseName,
                                                      WarehouseAddress = bp.StrWarehouseAddress,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = bp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetWarehouseByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "WareHouse List By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblWarehouse
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && b.IntClientId == CId
                                                  select new GetWarehouseDTO()
                                                  {
                                                      WarehouseId = bp.IntWarehouseId,
                                                      WarehouseCode = bp.StrWarehouseCode,
                                                      WarehouseName = bp.StrWarehouseName,
                                                      WarehouseAddress = bp.StrWarehouseAddress,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = bp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<object> CreateWarehouse(CreateWarehouseDTO postWarehouse)
        {
            try
            {
                var detalis = new TblWarehouse
                {

                    StrWarehouseCode = postWarehouse.WarehouseCode.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    IntClientId = postWarehouse.ClientId,
                    StrWarehouseName = postWarehouse.WarehouseName,
                    StrWarehouseAddress = postWarehouse.WarehouseAddress,
                    IntBusinessUnitId = postWarehouse.BusinessUnitId,
                    IntActionBy = postWarehouse.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true


                };
                await _context.TblWarehouse.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblWarehouse
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntWarehouseId == detalis.IntWarehouseId
                                  select new GetWarehouseDTO()
                                  {
                                      WarehouseId = bp.IntWarehouseId,
                                      WarehouseCode = bp.StrWarehouseCode,
                                      WarehouseName = bp.StrWarehouseName,
                                      WarehouseAddress = bp.StrWarehouseAddress,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = bp.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime
                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Warehouse Created Successfully.",
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
        public async Task<object> EditWarehouse(EditWarehouseDTO warehouse)
        {
            try
            {
                TblWarehouse data = _context.TblWarehouse.First(x => x.IntWarehouseId == warehouse.WarehouseId);

                data.IntWarehouseId = warehouse.WarehouseId;
                data.StrWarehouseCode = warehouse.WarehouseCode;
                data.StrWarehouseName = warehouse.WarehouseName;
                data.StrWarehouseAddress = warehouse.WarehouseAddress;
                data.IntActionBy = warehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblWarehouse
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntWarehouseId == warehouse.WarehouseId
                              select new GetWarehouseDTO()
                              {
                                  WarehouseId = bp.IntWarehouseId,
                                  WarehouseCode = bp.StrWarehouseCode,
                                  WarehouseName = bp.StrWarehouseName,
                                  WarehouseAddress = bp.StrWarehouseAddress,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Warehouse has been Edited Successfully.",
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
        public async Task<object> CancelWarehouse(CancelWarehouseDTO warehouse)
        {
            try
            {
                TblWarehouse data = _context.TblWarehouse.First(x => x.IntWarehouseId == warehouse.WarehouseId);

                data.IntWarehouseId = warehouse.WarehouseId;
                data.IntActionBy = warehouse.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblWarehouse.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblWarehouse
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntWarehouseId == warehouse.WarehouseId
                              select new GetWarehouseDTO()
                              {
                                  WarehouseId = bp.IntWarehouseId,
                                  WarehouseCode = bp.StrWarehouseCode,
                                  WarehouseName = bp.StrWarehouseName,
                                  WarehouseAddress = bp.StrWarehouseAddress,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Warehouse Cancelled Successfully.",
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
