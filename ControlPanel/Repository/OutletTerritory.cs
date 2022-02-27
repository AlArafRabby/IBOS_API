using ControlPanel.DbContexts;
using ControlPanel.DTO.OutletTerritory;
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
    public class OutletTerritory : IOutletTerritory
    {
        public readonly iBOSContext _context;
        public OutletTerritory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetOutletTerritoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Outlet Territory List: ",
                    data = await Task.FromResult((from ip in _context.TblOutletTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                  join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IsActive == true
                                                  select new GetOutletTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = d.IntTerritoryId,
                                                      TerritoryName = d.StrTerritoryName,
                                                      OutletId = s.IntOutletId,
                                                      OutletName = s.StrOutletName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime

                                                  }).ToList()),

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
        public async Task<Message> GetOutletTerritoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Outlet Territory List by Id: ",
                    data = await Task.FromResult((from ip in _context.TblOutletTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                  join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                   select new GetOutletTerritoryDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       TerritoryId = d.IntTerritoryId,
                                                       TerritoryName = d.StrTerritoryName,
                                                       OutletId = s.IntOutletId,
                                                       OutletName = s.StrOutletName,
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
        public async Task<Message> GetOutletTerritoryByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Outlet Territory List by Unit Id: ",
                    data = await Task.FromResult((from ip in _context.TblOutletTerritory
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                   join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IntBusinessUnitId == UId && ip.IsActive == true
                                                   select new GetOutletTerritoryDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       TerritoryId = d.IntTerritoryId,
                                                       TerritoryName = d.StrTerritoryName,
                                                       OutletId = s.IntOutletId,
                                                       OutletName = s.StrOutletName,
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
        public async Task<Message> GetOutletTerritoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Outlet Territory List by Client Id: ",
                    data = await Task.FromResult((from ip in _context.TblOutletTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                                  join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetOutletTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = d.IntTerritoryId,
                                                      TerritoryName = d.StrTerritoryName,
                                                      OutletId = s.IntOutletId,
                                                      OutletName = s.StrOutletName,
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
        public async Task<object> CreateOutletTerritory(CreateOutletTerritoryDTO postOutletTerritory)
        {
            try
            {
                var detalis = new TblOutletTerritory
                {
                    IntClientId = postOutletTerritory.ClientId,
                    IntBusinessUnitId = postOutletTerritory.BusinessUnitId,
                    IntTerritoryId = postOutletTerritory.TerritoryId,
                    IntOutletId = postOutletTerritory.OutletId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    DteServerDateTime = DateTime.UtcNow,
                    IntActionBy = postOutletTerritory.ActionBy
                };
                await _context.TblOutletTerritory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblOutletTerritory
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                                  join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetOutletTerritoryDTO()
                                  {

                                      ConfigId = ip.IntConfigId,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      TerritoryId = d.IntTerritoryId,
                                      TerritoryName = d.StrTerritoryName,
                                      OutletId = s.IntOutletId,
                                      OutletName = s.StrOutletName,
                                      ClientId = ip.IntClientId,
                                      ClientName = c.StrClientName,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Territory Created Successfully.",
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
        public async Task<object> EditOutletTerritory(EditOutletTerritoryDTO OutletTerritory)
        {
            try
            {
                TblOutletTerritory data = _context.TblOutletTerritory.First(x => x.IntConfigId == OutletTerritory.ConfigId);

                data.IntConfigId = OutletTerritory.ConfigId;
                data.IntTerritoryId = OutletTerritory.TerritoryId;
                data.IntOutletId = OutletTerritory.OutletId;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = OutletTerritory.ActionBy;

                _context.TblOutletTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblOutletTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                              join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == true && ip.IntConfigId == OutletTerritory.ConfigId
                              select new GetOutletTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = d.IntTerritoryId,
                                  TerritoryName = d.StrTerritoryName,
                                  OutletId = s.IntOutletId,
                                  OutletName = s.StrOutletName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Territory Edited Successfully.",
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
        public async Task<object> CancelOutletTerritory(CancelOutletTerritoryDTO OutletTerritory)
        {
            try
            {
                TblOutletTerritory data = _context.TblOutletTerritory.First(x => x.IntConfigId == OutletTerritory.ConfigId);

                data.IntActionBy = OutletTerritory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblOutletTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblOutletTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblTerritory on ip.IntTerritoryId equals d.IntTerritoryId
                              join s in _context.TblOutlet on ip.IntOutletId equals s.IntOutletId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == false && ip.IntConfigId == OutletTerritory.ConfigId
                              select new GetOutletTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = d.IntTerritoryId,
                                  TerritoryName = d.StrTerritoryName,
                                  OutletId = s.IntOutletId,
                                  OutletName = s.StrOutletName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Territory Cancelled Successfully.",
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
