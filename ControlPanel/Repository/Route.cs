using ControlPanel.DbContexts;
using ControlPanel.DTO.Route;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class Route : IRoute
    {
        public readonly iBOSContext _context;
        public Route(iBOSContext context)
        {
            _context = context;
        }


        public async Task<Message> GetRouteAll()
        {
            try
            {

                return new Message
                {
                    status = true,
                    message = "All Route List .",
                    data = await Task.FromResult((from bp in _context.TblRoute
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true 
                                                  select new GetRouteDTO()
                                                  {
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = bp.StrRouteName,
                                                      RouteAddress = bp.StrRouteAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetRouteByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Route List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRoute
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetRouteDTO()
                                                  {
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = bp.StrRouteName,
                                                      RouteAddress = bp.StrRouteAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetRouteById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Route List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRoute
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntRouteId == Id
                                                  select new GetRouteDTO()
                                                  {
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = bp.StrRouteName,
                                                      RouteAddress = bp.StrRouteAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetRouteByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Route List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRoute
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntBusinessUnitId == UId
                                                  select new GetRouteDTO()
                                                  {
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = bp.StrRouteName,
                                                      RouteAddress = bp.StrRouteAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<object> CreateRoute(CreateRouteDTO postRoute)
        {
            try
            {
                var detalis = new TblRoute
                {
                    StrRouteName = postRoute.RouteName,
                    StrRouteAddress = postRoute.RouteAddress,
                    IntClientId = postRoute.ClientId,
                    IntBusinessUnitId=postRoute.BusinessUnitId,
                    IntActionBy = postRoute.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true
                };
                await _context.TblRoute.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblRoute
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntRouteId == detalis.IntRouteId
                                  select new GetRouteDTO()
                                  {
                                      RouteId = bp.IntRouteId,
                                      RouteName = bp.StrRouteName,
                                      RouteAddress = bp.StrRouteAddress,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Route Created Successfully.",
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
        public async Task<object> EditRoute(EditRouteDTO Route)
        {
            try
            {
                TblRoute data = _context.TblRoute.First(x => x.IntRouteId == Route.RouteId);
                data.StrRouteName = Route.RouteName;
                data.IntActionBy = Route.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblRoute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblRoute
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntRouteId == Route.RouteId
                              select new GetRouteDTO()
                              {
                                  RouteId = bp.IntRouteId,
                                  RouteName = bp.StrRouteName,
                                  RouteAddress = bp.StrRouteAddress,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Route Edited Successfully.",
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
        public async Task<object> CancelRoute(CancelRouteDTO Route)
        {
            try
            {
                TblRoute data = _context.TblRoute.First(x => x.IntRouteId == Route.RouteId);

                data.IntActionBy = Route.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblRoute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblRoute
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntRouteId == Route.RouteId
                              select new GetRouteDTO()
                              {
                                  RouteId = bp.IntRouteId,
                                  RouteName = bp.StrRouteName,
                                  RouteAddress = bp.StrRouteAddress,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Route Cancelled Successfully.",
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
