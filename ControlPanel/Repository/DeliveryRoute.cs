using ControlPanel.DbContexts;
using ControlPanel.DTO.DeliveryRoute;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class DeliveryRoute : IDeliveryRoute
    {
        public readonly iBOSContext _context;
        public DeliveryRoute(iBOSContext context)
        {
            _context = context;
        }

        public async Task<object> CreateDeliveryRoute(CreateDeliveryRouteDTO postDeliveryRoute)
        {
            try
            {
                var detalis = new TblDeliveryRoute
                {
                    StrDeliverRouteName = postDeliveryRoute.DeliveryRouteName,
                    IntBusinessUnitId = postDeliveryRoute.BusinessUnitId,
                    IntClientId = postDeliveryRoute.ClientId,
                    IntActionBy = postDeliveryRoute.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblDeliveryRoute.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bgl in _context.TblDeliveryRoute
                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                  join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                                  where bgl.IsActive == true && bgl.IntDeliveryRouteId == detalis.IntDeliveryRouteId
                                  select new GetDeliveryRouteDTO()
                                  {
                                      DeliveryRouteId = bgl.IntDeliveryRouteId,
                                      DeliverRouteName = bgl.StrDeliverRouteName,
                                      BusinessUnitId = bgl.IntBusinessUnitId,
                                      BusinessUnitName = u.StrBusinessUnitName,
                                      ClientId = bgl.IntClientId,
                                      ClientName = cl.StrClientName,
                                      ActionBy = bgl.IntActionBy,
                                      LastActionDateTime = bgl.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Delivery Route Created Successfully.",
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
        public async Task<object> EditDeliveryRoute(EditDeliveryRouteDTO DeliveryRoute)
        {
            try
            {
                TblDeliveryRoute data = _context.TblDeliveryRoute.First(x => x.IntDeliveryRouteId == DeliveryRoute.DeliveryRouteId);

                data.StrDeliverRouteName = DeliveryRoute.DeliverRouteName;
                data.IntBusinessUnitId = DeliveryRoute.BusinessUnitId;
                data.IntActionBy = DeliveryRoute.ActionBy;

                _context.TblDeliveryRoute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblDeliveryRoute
                              join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                              where bgl.IsActive == true && bgl.IntDeliveryRouteId == DeliveryRoute.DeliveryRouteId
                              select new GetDeliveryRouteDTO()
                              {
                                  DeliveryRouteId = bgl.IntDeliveryRouteId,
                                  DeliverRouteName = bgl.StrDeliverRouteName,
                                  BusinessUnitId = bgl.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  ActionBy = bgl.IntActionBy,
                                  LastActionDateTime = bgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "DeliveryRoute Edited Successfully.",
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
        public async Task<object> CancelDeliveryRoute(CancelDeliveryRouteDTO DeliveryRoute)
        {
            try
            {
                TblDeliveryRoute data = _context.TblDeliveryRoute.First(x => x.IntDeliveryRouteId == DeliveryRoute.DeliveryRouteId);

                data.IntActionBy = DeliveryRoute.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblDeliveryRoute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblDeliveryRoute
                              join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                              where bgl.IsActive == false && bgl.IntDeliveryRouteId == DeliveryRoute.DeliveryRouteId
                              select new GetDeliveryRouteDTO()
                              {
                                  DeliveryRouteId = bgl.IntDeliveryRouteId,
                                  DeliverRouteName = bgl.StrDeliverRouteName,
                                  BusinessUnitId = bgl.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  ActionBy = bgl.IntActionBy,
                                  LastActionDateTime = bgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "DeliveryRoute Edited Successfully.",
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

        public async Task<Message> GetDeliveryRouteAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Delivery Route List ",
                    data = await Task.FromResult((from bgl in _context.TblDeliveryRoute
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where bgl.IsActive == true
                                                  select new GetDeliveryRouteDTO()
                                                  {
                                                      DeliveryRouteId = bgl.IntDeliveryRouteId,
                                                      DeliverRouteName = bgl.StrDeliverRouteName,
                                                      BusinessUnitId = bgl.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      ActionBy = bgl.IntActionBy,
                                                      LastActionDateTime = bgl.DteLastActionDateTime

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
        public async Task<Message> GetDeliveryRouteById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Delivery Route List By Id ",
                    data = await Task.FromResult((from bgl in _context.TblDeliveryRoute
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where bgl.IsActive == true && bgl.IntDeliveryRouteId == Id
                                                  select new GetDeliveryRouteDTO()
                                                  {
                                                      DeliveryRouteId = bgl.IntDeliveryRouteId,
                                                      DeliverRouteName = bgl.StrDeliverRouteName,
                                                      BusinessUnitId = bgl.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      ActionBy = bgl.IntActionBy,
                                                      LastActionDateTime = bgl.DteLastActionDateTime

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
        public async Task<Message> GetDeliveryRouteByClientBusinessUnitId(long CId, long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Delivery Route List by Client Id",
                    data = await Task.FromResult((from bgl in _context.TblDeliveryRoute
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where bgl.IsActive == true && bgl.IntClientId == CId && bgl.IntBusinessUnitId == UId
                                                  select new GetDeliveryRouteDTO()
                                                  {
                                                      DeliveryRouteId = bgl.IntDeliveryRouteId,
                                                      DeliverRouteName = bgl.StrDeliverRouteName,
                                                      BusinessUnitId = bgl.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      ActionBy = bgl.IntActionBy,
                                                      LastActionDateTime = bgl.DteLastActionDateTime

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
    }
}
