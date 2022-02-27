using ControlPanel.DbContexts;
using ControlPanel.DTO.LogTerritorySalesForceChange;
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
    public class LogTerritorySalesForceChange: ILogTerritorySalesForceChange
    {
        public readonly iBOSContext _context;
        public LogTerritorySalesForceChange(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetLogTerritorySalesForceChangeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Log Territory Sales Force Change ",
                    data = await Task.FromResult((from bp in _context.TblLogTerritorySalesForceChange
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                                                  where bp.IsActive == true
                                                  select new GetLogTerritorySalesForceChangeDTO()
                                                  {
                                                      LogId = bp.IntLogId,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryName = tr.StrTerritoryName,
                                                      EmployeeId = bp.IntEmployeeId,
                                                      EmployeeName = u.StrUserName,
                                                      FromDate = bp.DteFromDate,
                                                      ToDate = bp.DteToDate,
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
        public async Task<Message> GetLogTerritorySalesForceChangeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change by id ",
                    data = await Task.FromResult((from bp in _context.TblLogTerritorySalesForceChange
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                                                  where bp.IsActive == true
                                                  select new GetLogTerritorySalesForceChangeDTO()
                                                  {
                                                      LogId = bp.IntLogId,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryName = tr.StrTerritoryName,
                                                      EmployeeId = bp.IntEmployeeId,
                                                      EmployeeName = u.StrUserName,
                                                      FromDate = bp.DteFromDate,
                                                      ToDate = bp.DteToDate,
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
        public async Task<Message> GetLogTerritorySalesForceChangeByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change by Unit id ",
                    data = await Task.FromResult((from bp in _context.TblLogTerritorySalesForceChange
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                                                  where bp.IsActive == true && bp.IntBusinessUnitId == UId
                                                  select new GetLogTerritorySalesForceChangeDTO()
                                                  {
                                                      LogId = bp.IntLogId,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryName = tr.StrTerritoryName,
                                                      EmployeeId = bp.IntEmployeeId,
                                                      EmployeeName = u.StrUserName,
                                                      FromDate = bp.DteFromDate,
                                                      ToDate = bp.DteToDate,
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
        public async Task<Message> GetLogTerritorySalesForceChangeByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change  by Client id ",
                    data = await Task.FromResult((from bp in _context.TblLogTerritorySalesForceChange
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetLogTerritorySalesForceChangeDTO()
                                                  {
                                                      LogId = bp.IntLogId,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryName = tr.StrTerritoryName,
                                                      EmployeeId = bp.IntEmployeeId,
                                                      EmployeeName = u.StrUserName,
                                                      FromDate = bp.DteFromDate,
                                                      ToDate = bp.DteToDate,
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
        public async Task<Message> CreateLogTerritorySalesForceChange(CreateLogTerritorySalesForceChangeDTO postLogTerritorySalesForceChange)
        {
            try
            {
                var detalis = new TblLogTerritorySalesForceChange
                {
                    IntClientId = postLogTerritorySalesForceChange.ClientId,
                    IntBusinessUnitId = postLogTerritorySalesForceChange.BusinessUnitId,
                    IntTerritoryId = postLogTerritorySalesForceChange.TerritoryId,
                    IntEmployeeId = postLogTerritorySalesForceChange.EmployeeId,
                    DteFromDate = postLogTerritorySalesForceChange.FromDate,
                    DteToDate = postLogTerritorySalesForceChange.ToDate,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postLogTerritorySalesForceChange.ActionBy
                };
                await _context.TblLogTerritorySalesForceChange.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblLogTerritorySalesForceChange
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                                  where bp.IsActive == true && bp.IntLogId == detalis.IntLogId
                                  select new GetLogTerritorySalesForceChangeDTO()
                                  {
                                      LogId = bp.IntLogId,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      TerritoryId = bp.IntTerritoryId,
                                      TerritoryName = tr.StrTerritoryName,
                                      EmployeeId = bp.IntEmployeeId,
                                      EmployeeName = u.StrUserName,
                                      FromDate = bp.DteFromDate,
                                      ToDate = bp.DteToDate,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime
                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change Created Successfully.",
                    data = detalisView
                };

                return successmsg;
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
        public async Task<Message> EditLogTerritorySalesForceChange(EditLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange)
        {
            try
            {
                TblLogTerritorySalesForceChange data = _context.TblLogTerritorySalesForceChange.First(x => x.IntLogId == LogTerritorySalesForceChange.LogId);

                data.IntLogId = LogTerritorySalesForceChange.LogId;
                data.IntTerritoryId = LogTerritorySalesForceChange.TerritoryId;
                data.IntEmployeeId = LogTerritorySalesForceChange.EmployeeId;
                data.DteFromDate = LogTerritorySalesForceChange.FromDate;
                data.DteToDate = LogTerritorySalesForceChange.ToDate;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = LogTerritorySalesForceChange.ActionBy;

                _context.TblLogTerritorySalesForceChange.Update(data);
                await _context.SaveChangesAsync();
                var Details = from bp in _context.TblLogTerritorySalesForceChange
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                              where bp.IsActive == true && bp.IntLogId == LogTerritorySalesForceChange.LogId
                              select new GetLogTerritorySalesForceChangeDTO()
                              {
                                  LogId = bp.IntLogId,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = bp.IntTerritoryId,
                                  TerritoryName = tr.StrTerritoryName,
                                  EmployeeId = bp.IntEmployeeId,
                                  EmployeeName = u.StrUserName,
                                  FromDate = bp.DteFromDate,
                                  ToDate = bp.DteToDate,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change Edited Successfully.",
                    data = Details
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
        public async Task<Message> CancelLogTerritorySalesForceChange(CancelLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange)
        {
            try
            {
                TblLogTerritorySalesForceChange data = _context.TblLogTerritorySalesForceChange.First(x => x.IntLogId == LogTerritorySalesForceChange.LogId);
                data.IntActionBy = LogTerritorySalesForceChange.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblLogTerritorySalesForceChange.Update(data);
                await _context.SaveChangesAsync();
                var Details = from bp in _context.TblLogTerritorySalesForceChange
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join tr in _context.TblTerritory on bp.IntTerritoryId equals tr.IntTerritoryId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              join u in _context.TblUser on bp.IntEmployeeId equals u.IntUserId
                              where bp.IsActive == false && bp.IntLogId == LogTerritorySalesForceChange.LogId
                              select new GetLogTerritorySalesForceChangeDTO()
                              {
                                  LogId = bp.IntLogId,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = bp.IntTerritoryId,
                                  TerritoryName = tr.StrTerritoryName,
                                  EmployeeId = bp.IntEmployeeId,
                                  EmployeeName = u.StrUserName,
                                  FromDate = bp.DteFromDate,
                                  ToDate = bp.DteToDate,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change Cancelled Successfully.",
                    data = Details
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


