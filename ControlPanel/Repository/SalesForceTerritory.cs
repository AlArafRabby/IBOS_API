using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesForceTerritory;
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
    public class SalesForceTerritory : ISalesForceTerritory
    {
        public readonly iBOSContext _context;
        public SalesForceTerritory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesForceTerritoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Force Territory List: ",
                    data = await Task.FromResult((from ip in _context.TblSalesForceTerritory
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                   join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                                                   join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                   where ip.IsActive == true
                                                   select new GetSalesForceTerritoryDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = ip.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       TerritoryId = d.IntTerritoryId,
                                                       TerritoryName = d.StrTerritoryName,
                                                       EmployeeId = ip.IntEmployeeId,
                                                       EmployeeName = s.StrUserName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesForceTerritoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Force Territory List by Id: ",
                    data = await Task.FromResult((from ip in _context.TblSalesForceTerritory
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                   join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                                                   join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                   where ip.IntConfigId == Id && ip.IsActive == true
                                                   select new GetSalesForceTerritoryDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = ip.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       TerritoryId = d.IntTerritoryId,
                                                       TerritoryName = d.StrTerritoryName,
                                                       EmployeeId = ip.IntEmployeeId,
                                                       EmployeeName = s.StrUserName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesForceTerritoryByUnitId(long UId)
        {
        try
        {
            return new Message
            {
                status = true,
                message = "All Sales Force Territory List by Unit: ",
                data = await Task.FromResult((from ip in _context.TblSalesForceTerritory
                                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                              join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                              where ip.IntConfigId == UId && ip.IsActive == true
                                              select new GetSalesForceTerritoryDTO()
                                              {
                                                   ConfigId = ip.IntConfigId,
                                                   BusinessUnitId = ip.IntBusinessUnitId,
                                                   BusinessUnitName = b.StrBusinessUnitName,
                                                   TerritoryId = d.IntTerritoryId,
                                                   TerritoryName = d.StrTerritoryName,
                                                   EmployeeId = ip.IntEmployeeId,
                                                   EmployeeName = s.StrUserName,
                                                   ClientId = ip.IntClientId,
                                                   ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesForceTerritoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Force Territory List by Client Id: ",
                    data = await Task.FromResult((from ip in _context.TblSalesForceTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                  join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetSalesForceTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = d.IntTerritoryId,
                                                      TerritoryName = d.StrTerritoryName,
                                                      EmployeeId = ip.IntEmployeeId,
                                                      EmployeeName = s.StrUserName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<object> CreateSalesForceTerritory(CreateSalesForceTerritoryDTO postSalesForceTerritory)
        {
            try
            {
                var detalis = new TblSalesForceTerritory
                {
                    IntBusinessUnitId = postSalesForceTerritory.BusinessUnitId,
                    IntTerritoryId = postSalesForceTerritory.TerritoryId,
                    IntEmployeeId = postSalesForceTerritory.EmployeeId,
                    YsnManager = postSalesForceTerritory.YsnManager,
                    IntActionBy = postSalesForceTerritory.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                    
                };
                await _context.TblSalesForceTerritory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblSalesForceTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                              join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                              select new GetSalesForceTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = d.IntTerritoryId,
                                  TerritoryName = d.StrTerritoryName,
                                  EmployeeId = ip.IntEmployeeId,
                                  EmployeeName = s.StrUserName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Force Territory Created Successfully.",
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
        public async Task<object> EditSalesForceTerritory(EditSalesForceTerritoryDTO SalesForceTerritory)
        {
            try
            {
                TblSalesForceTerritory data = _context.TblSalesForceTerritory.First(x => x.IntConfigId == SalesForceTerritory.ConfigId);

                data.IntConfigId = SalesForceTerritory.ConfigId;
                data.IntTerritoryId = SalesForceTerritory.TerritoryId;
                data.IntEmployeeId = SalesForceTerritory.EmployeeId;
                data.YsnManager = SalesForceTerritory.YsnManager;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = SalesForceTerritory.ActionBy;

                _context.TblSalesForceTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSalesForceTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                              join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == true && ip.IntConfigId == SalesForceTerritory.ConfigId
                              select new GetSalesForceTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = d.IntTerritoryId,
                                  TerritoryName = d.StrTerritoryName,
                                  EmployeeId = ip.IntEmployeeId,
                                  EmployeeName = s.StrUserName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Force Territory Edited Successfully.",
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
        public async Task<object> CancelSalesForceTerritory(CancelSalesForceTerritoryDTO SalesForceTerritory)
        {
            try
            {
                TblSalesForceTerritory data = _context.TblSalesForceTerritory.First(x => x.IntConfigId == SalesForceTerritory.ConfigId);

                data.IntActionBy = SalesForceTerritory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblSalesForceTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSalesForceTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                              join s in _context.TblUser on ip.IntEmployeeId equals s.IntUserId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == false && ip.IntConfigId == SalesForceTerritory.ConfigId
                              select new GetSalesForceTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = d.IntTerritoryId,
                                  TerritoryName = d.StrTerritoryName,
                                  EmployeeId = ip.IntEmployeeId,
                                  EmployeeName = s.StrUserName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Force Territory Cancelled Successfully.",
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
