using ControlPanel.DbContexts;
using ControlPanel.DTO.RouteTransportzone;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class RouteTransportzone : IRouteTransportzone
    {
        public readonly iBOSContext _context;
        public RouteTransportzone(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetRouteTransportzoneAll()
        {
            try
            {

                return new Message
                {
                    status = true,
                    message = "All RouteTransportzone List .",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<Message> GetRouteTransportzoneByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "RouteTransportzone List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<Message> GetRouteTransportzoneById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "RouteTransportzone List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntConfigId == Id
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<Message> GetRouteTransportzoneByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "RouteTransportzone List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntBusinessUnitId == UId
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<Message> GetRouteTransportzoneByTransportzoneId(long TZId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "RouteTransportzone List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntTransportZoneId == TZId
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<Message> GetRouteTransportzoneByRouteId(long RId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "RouteTransportzone List by ID.",
                    data = await Task.FromResult((from bp in _context.TblRouteTransportzone
                                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntRouteId == RId
                                                  select new GetRouteTransportzoneDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      TransportZoneId = bp.IntTransportZoneId,
                                                      TransportZoneName = tz.StrTransportZoneName,
                                                      RouteId = bp.IntRouteId,
                                                      RouteName = r.StrRouteName,
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
        public async Task<object> CreateRouteTransportzone(CreateRouteTransportzoneDTO postRouteTransportzone)
        {
            try
            {
                var detalis = new TblRouteTransportzone
                {
                    IntTransportZoneId = postRouteTransportzone.TransportZoneId,
                    IntRouteId = postRouteTransportzone.RouteId,
                    IntClientId = postRouteTransportzone.ClientId,
                    IntBusinessUnitId = postRouteTransportzone.BusinessUnitId,
                    IntActionBy = postRouteTransportzone.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true
                };
                await _context.TblRouteTransportzone.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblRouteTransportzone
                                  join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                                  join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntConfigId == detalis.IntConfigId
                                  select new GetRouteTransportzoneDTO()
                                  {
                                      ConfigId = bp.IntConfigId,
                                      TransportZoneId = bp.IntTransportZoneId,
                                      TransportZoneName = tz.StrTransportZoneName,
                                      RouteId = bp.IntRouteId,
                                      RouteName = r.StrRouteName,
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
                    message = "RouteTransportzone Created Successfully.",
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
        public async Task<object> EditRouteTransportzone(EditRouteTransportzoneDTO RouteTransportzone)
        {
            try
            {
                TblRouteTransportzone data = _context.TblRouteTransportzone.First(x => x.IntConfigId == RouteTransportzone.ConfigId);
                data.IntTransportZoneId = RouteTransportzone.TransportZoneId;
                data.IntRouteId = RouteTransportzone.RouteId;
                data.IntBusinessUnitId = RouteTransportzone.BusinessUnitId;
                data.IntActionBy = RouteTransportzone.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblRouteTransportzone.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblRouteTransportzone
                              join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                              join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntConfigId == RouteTransportzone.ConfigId
                              select new GetRouteTransportzoneDTO()
                              {
                                  ConfigId = bp.IntConfigId,
                                  TransportZoneId = bp.IntTransportZoneId,
                                  TransportZoneName = tz.StrTransportZoneName,
                                  RouteId = bp.IntRouteId,
                                  RouteName = r.StrRouteName,
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
                    message = "RouteTransportzone Edited Successfully.",
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
        public async Task<object> CancelRouteTransportzone(CancelRouteTransportzoneDTO RouteTransportzone)
        {
            try
            {
                TblRouteTransportzone data = _context.TblRouteTransportzone.First(x => x.IntConfigId == RouteTransportzone.ConfigId);

                data.IntActionBy = RouteTransportzone.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblRouteTransportzone.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblRouteTransportzone
                              join tz in _context.TblTransportZone on bp.IntTransportZoneId equals tz.IntTransportZoneId
                              join r in _context.TblRoute on bp.IntRouteId equals r.IntRouteId
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntConfigId == RouteTransportzone.ConfigId
                              select new GetRouteTransportzoneDTO()
                              {
                                  ConfigId = bp.IntConfigId,
                                  TransportZoneId = bp.IntTransportZoneId,
                                  TransportZoneName = tz.StrTransportZoneName,
                                  RouteId = bp.IntRouteId,
                                  RouteName = r.StrRouteName,
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
                    message = "Route Transport zone Cancelled Successfully.",
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
