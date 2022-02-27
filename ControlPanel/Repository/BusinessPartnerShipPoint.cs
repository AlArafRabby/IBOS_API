using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerShipPoint;
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
    public class BusinessPartnerShipPoint : IBusinessPartnerShipPoint
    {
        public readonly iBOSContext _context;
        public BusinessPartnerShipPoint(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerShipPointAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner Ship Point List",
                    data = await Task.FromResult((from so in _context.TblBusinessPartnerShipPoint
                                                  join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true
                                                  select new GetBusinessPartnerShipPointDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = so.IntBusinessPartnerId,
                                                      BusinessPartnerName = b.StrBusinessUnitName,
                                                      ShipPointId = so.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      DistanceKm = so.NumDistanceKm,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerShipPointById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List",
                    data = await Task.FromResult((from so in _context.TblBusinessPartnerShipPoint
                                                  join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntConfigId == Id
                                                  select new GetBusinessPartnerShipPointDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = so.IntBusinessPartnerId,
                                                      BusinessPartnerName = b.StrBusinessUnitName,
                                                      ShipPointId = so.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      DistanceKm = so.NumDistanceKm,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerShipPointByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List",
                    data = await Task.FromResult((from so in _context.TblBusinessPartnerShipPoint
                                                  join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntClientId == CId
                                                  select new GetBusinessPartnerShipPointDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = so.IntBusinessPartnerId,
                                                      BusinessPartnerName = b.StrBusinessUnitName,
                                                      ShipPointId = so.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      DistanceKm = so.NumDistanceKm,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerShipPointByUnittId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List",
                    data = await Task.FromResult((from so in _context.TblBusinessPartnerShipPoint
                                                  join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntBusinessUnitId == UId
                                                  select new GetBusinessPartnerShipPointDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = so.IntBusinessPartnerId,
                                                      BusinessPartnerName = b.StrBusinessUnitName,
                                                      ShipPointId = so.IntShipPointId,
                                                      ShipPointName = sp.StrShipPointName,
                                                      DistanceKm = so.NumDistanceKm,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

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
        public async Task<object> CreateBusinessPartnerShipPoint(CreateBusinessPartnerShipPointDTO postBusinessPartnerShipPoint)
        {
            try
            {
                var detalis = new TblBusinessPartnerShipPoint
                {

                    IntClientId = postBusinessPartnerShipPoint.ClientId,
                    IntBusinessUnitId = postBusinessPartnerShipPoint.BusinessUnitId,
                    IntBusinessPartnerId = postBusinessPartnerShipPoint.BusinessPartnerId,
                    IntShipPointId = postBusinessPartnerShipPoint.ShipPointId,
                    NumDistanceKm = postBusinessPartnerShipPoint.DistanceKm,
                    IntActionBy = postBusinessPartnerShipPoint.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblBusinessPartnerShipPoint.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from so in _context.TblBusinessPartnerShipPoint
                                  join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                  join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                  where so.IsActive == true && so.IntConfigId == detalis.IntConfigId
                                  select new GetBusinessPartnerShipPointDTO()
                                  {
                                      ConfigId = so.IntConfigId,
                                      ClientId = so.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = so.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      BusinessPartnerId = so.IntBusinessPartnerId,
                                      BusinessPartnerName = b.StrBusinessUnitName,
                                      ShipPointId = so.IntShipPointId,
                                      ShipPointName = sp.StrShipPointName,
                                      DistanceKm = so.NumDistanceKm,
                                      ActionBy = so.IntActionBy,
                                      LastActionDateTime = so.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner ShipPoint Created Successfully.",
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
        public async Task<object> EditBusinessPartnerShipPoint(EditBusinessPartnerShipPointDTO putBusinessPartnerShipPoint)
        {
            try
            {
                TblBusinessPartnerShipPoint data = _context.TblBusinessPartnerShipPoint.First(x => x.IntConfigId == putBusinessPartnerShipPoint.ConfigId);

                data.IntConfigId = putBusinessPartnerShipPoint.ConfigId;
                data.IntClientId = putBusinessPartnerShipPoint.ClientId;
                data.IntBusinessUnitId = putBusinessPartnerShipPoint.BusinessUnitId;
                data.IntBusinessPartnerId = putBusinessPartnerShipPoint.BusinessPartnerId;
                data.IntShipPointId = putBusinessPartnerShipPoint.ShipPointId;
                data.NumDistanceKm = putBusinessPartnerShipPoint.DistanceKm;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putBusinessPartnerShipPoint.ActionBy;

                _context.TblBusinessPartnerShipPoint.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblBusinessPartnerShipPoint
                              join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                              join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == true && so.IntConfigId == putBusinessPartnerShipPoint.ConfigId
                              select new GetBusinessPartnerShipPointDTO()
                              {
                                  ConfigId = so.IntConfigId,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = so.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessPartnerId = so.IntBusinessPartnerId,
                                  BusinessPartnerName = b.StrBusinessUnitName,
                                  ShipPointId = so.IntShipPointId,
                                  ShipPointName = sp.StrShipPointName,
                                  DistanceKm = so.NumDistanceKm,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner ShipPoint Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerShipPoint(CancelBusinessPartnerShipPointDTO putBusinessPartnerShipPoint)
        {
            try
            {
                TblBusinessPartnerShipPoint data = _context.TblBusinessPartnerShipPoint.First(x => x.IntConfigId == putBusinessPartnerShipPoint.ConfigId);

                data.IntConfigId = putBusinessPartnerShipPoint.ConfigId;
                data.IntActionBy = putBusinessPartnerShipPoint.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerShipPoint.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblBusinessPartnerShipPoint
                              join bp in _context.TblBusinessPartner on so.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join sp in _context.TblShipPoint on so.IntShipPointId equals sp.IntShipPointId
                              join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == false && so.IntConfigId == putBusinessPartnerShipPoint.ConfigId
                              select new GetBusinessPartnerShipPointDTO()
                              {
                                  ConfigId = so.IntConfigId,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = so.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessPartnerId = so.IntBusinessPartnerId,
                                  BusinessPartnerName = b.StrBusinessUnitName,
                                  ShipPointId = so.IntShipPointId,
                                  ShipPointName = sp.StrShipPointName,
                                  DistanceKm = so.NumDistanceKm,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner ShipPoint Cancelled Successfully.",
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
