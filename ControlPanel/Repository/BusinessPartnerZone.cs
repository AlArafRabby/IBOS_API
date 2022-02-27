using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerZone;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessPartnerZone : IBusinessPartnerZone
    {
        public readonly iBOSContext _context;

        public BusinessPartnerZone(iBOSContext context)
        {
            _context = context;
        }

        public async Task<object> CancelBusinessPartnerZone(CancelBusinessPartnerZoneDTO putBusinessPartnerZone)
        {
            try
            {
                TblBusinessPartnerZone data = _context.TblBusinessPartnerZone.First(x => x.IntConfigId == putBusinessPartnerZone.ConfigId);
                data.IntConfigId = putBusinessPartnerZone.ConfigId;
                data.IntActionBy = putBusinessPartnerZone.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;


                _context.TblBusinessPartnerZone.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from pz in _context.TblBusinessPartnerZone
                              join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                              join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                              join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                              where pz.IntConfigId == data.IntConfigId && pz.IsActive == true
                              select new GetBusinessPartnerZoneDTO()
                              {
                                  ConfigId = pz.IntConfigId,
                                  ClientId = pz.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = pz.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessPartnerId = pz.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  TransportZoneId = pz.IntTransportZoneId,
                                  TransportZoneName = z.StrTransportZoneName,
                                  ActionBy = pz.IntActionBy,
                                  LastActionDateTime = pz.DteLastActionDateTime
                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Zone Cancelled Successfully.",
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

        public async Task<object> CreateBusinessPartnerZone(CreateBusinessPartnerZoneDTO postBusinessPartnerZone)
        {
            try
            {
                var detalis = new TblBusinessPartnerZone
                {
                    IntClientId = postBusinessPartnerZone.ClientId,
                    IntBusinessUnitId = postBusinessPartnerZone.BusinessUnitId,
                    IntBusinessPartnerId = postBusinessPartnerZone.BusinessPartnerId,
                    IntTransportZoneId = postBusinessPartnerZone.TransportZoneId,
                    IntActionBy = postBusinessPartnerZone.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblBusinessPartnerZone.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = (from pz in _context.TblBusinessPartnerZone
                                              join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                                              join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                                              join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                              join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                                              where pz.IntConfigId == detalis.IntConfigId && pz.IsActive == true
                                              select new GetBusinessPartnerZoneDTO()
                                              {
                                                  ConfigId = pz.IntConfigId,
                                                  ClientId = pz.IntClientId,
                                                  ClientName = c.StrClientName,
                                                  BusinessUnitId = pz.IntBusinessUnitId,
                                                  BusinessUnitName = b.StrBusinessUnitName,
                                                  BusinessPartnerId = pz.IntBusinessPartnerId,
                                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                                  TransportZoneId = pz.IntTransportZoneId,
                                                  TransportZoneName = z.StrTransportZoneName,
                                                  ActionBy = pz.IntActionBy,
                                                  LastActionDateTime = pz.DteLastActionDateTime
                                              });

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Zone Created Successfully.",
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

        public async Task<object> EditBusinessPartnerZone(EditBusinessPartnerZoneDTO putBusinessPartnerZone)
        {
            try
            {
                TblBusinessPartnerZone data = _context.TblBusinessPartnerZone.First(x => x.IntConfigId == putBusinessPartnerZone.ConfigId);

                data.IntConfigId = putBusinessPartnerZone.ConfigId;
                data.IntClientId = putBusinessPartnerZone.ClientId;
                data.IntBusinessUnitId = putBusinessPartnerZone.BusinessUnitId;
                data.IntBusinessPartnerId = putBusinessPartnerZone.BusinessPartnerId;
                data.IntTransportZoneId = putBusinessPartnerZone.TransportZoneId;
                data.IntActionBy = putBusinessPartnerZone.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessPartnerZone.Update(data);
                await _context.SaveChangesAsync();
                var detalis = from pz in _context.TblBusinessPartnerZone
                               join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                               join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                               join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                               join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                               where pz.IntConfigId == data.IntConfigId && pz.IsActive == true
                               select new GetBusinessPartnerZoneDTO()
                               {
                                   ConfigId = pz.IntConfigId,
                                   ClientId = pz.IntClientId,
                                   ClientName = c.StrClientName,
                                   BusinessUnitId = pz.IntBusinessUnitId,
                                   BusinessUnitName = b.StrBusinessUnitName,
                                   BusinessPartnerId = pz.IntBusinessPartnerId,
                                   BusinessPartnerName = bp.StrBusinessPartnerName,
                                   TransportZoneId = pz.IntTransportZoneId,
                                   TransportZoneName = z.StrTransportZoneName,
                                   ActionBy = pz.IntActionBy,
                                   LastActionDateTime = pz.DteLastActionDateTime
                               };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Zone Edited Successfully.",
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

        public async Task<Message> GetBusinessPartnerZoneByClientBusinessUnitId(long ClientId, long BusinessUnitId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Zone List By ClientId and BusinessUnitId.",
                    data = await Task.FromResult((from pz in _context.TblBusinessPartnerZone
                                                  join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                                                  join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                                                  where pz.IntClientId == ClientId && pz.IntBusinessUnitId == BusinessUnitId && pz.IsActive == true
                                                  select new GetBusinessPartnerZoneDTO()
                                                  {
                                                      ConfigId = pz.IntConfigId,
                                                      ClientId = pz.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = pz.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = pz.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      TransportZoneId = pz.IntTransportZoneId,
                                                      TransportZoneName = z.StrTransportZoneName,
                                                      ActionBy = pz.IntActionBy,
                                                      LastActionDateTime = pz.DteLastActionDateTime
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

        public async Task<Message> GetBusinessPartnerZoneByClientBusinessUnitPartnerId(long ClientId, long BusinessUnitId, long BusinessPartnerId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Zone List.",
                    data = await Task.FromResult((from pz in _context.TblBusinessPartnerZone
                                                  join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                                                  join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                                                  where pz.IntClientId == ClientId && pz.IntBusinessUnitId == BusinessUnitId && pz.IntBusinessPartnerId == BusinessPartnerId && pz.IsActive == true
                                                  select new GetBusinessPartnerZoneDTO()
                                                  {
                                                      ConfigId = pz.IntConfigId,
                                                      ClientId = pz.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = pz.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = pz.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      TransportZoneId = pz.IntTransportZoneId,
                                                      TransportZoneName = z.StrTransportZoneName,
                                                      ActionBy = pz.IntActionBy,
                                                      LastActionDateTime = pz.DteLastActionDateTime
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

        public async Task<Message> GetBusinessPartnerZoneById(long ConfigId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Zone List By Id.",
                    data = await Task.FromResult((from pz in _context.TblBusinessPartnerZone
                                                  join b in _context.TblBusinessUnit on pz.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join z in _context.TblTransportZone on pz.IntTransportZoneId equals z.IntTransportZoneId
                                                  join bp in _context.TblBusinessPartner on pz.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join c in _context.TblClient on pz.IntClientId equals c.IntClientId
                                                  where pz.IntConfigId == ConfigId && pz.IsActive == true
                                                  select new GetBusinessPartnerZoneDTO()
                                                  {
                                                      ConfigId = pz.IntConfigId,
                                                      ClientId = pz.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = pz.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessPartnerId = pz.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      TransportZoneId = pz.IntTransportZoneId,
                                                      TransportZoneName = z.StrTransportZoneName,
                                                      ActionBy = pz.IntActionBy,
                                                      LastActionDateTime = pz.DteLastActionDateTime
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
