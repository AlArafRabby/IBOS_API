using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessArea;
using ControlPanel.DTO.BusinessPartnerDistributionChannel;
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
    public class BusinessPartnerDistributionChannel : IBusinessPartnerDistributionChannel
    {
        public readonly iBOSContext _context;
        public BusinessPartnerDistributionChannel(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerDistributionChannelAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner Distribution channel List ",
                    data = await Task.FromResult((from bp in _context.TblBusinessPartnerDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                                                  where bp.IsActive == true
                                                  select new GetBusinessPartnerDistributionChannelDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      BusinessPartnerId = p.IntBusinessPartnerId,
                                                      BusinessPartnerName = p.StrBusinessPartnerName,
                                                      DistributionChannelId = d.IntDistributionChannelId,
                                                      DistributionChannelName = d.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
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
        public async Task<Message> GetBusinessPartnerDistributionChannelById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Distribution Channel List By Id.",
                    data = await Task.FromResult((from bp in _context.TblBusinessPartnerDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntConfigId == Id
                                                  select new GetBusinessPartnerDistributionChannelDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      BusinessPartnerId = p.IntBusinessPartnerId,
                                                      BusinessPartnerName = p.StrBusinessPartnerName,
                                                      DistributionChannelId = d.IntDistributionChannelId,
                                                      DistributionChannelName = d.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
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
        public async Task<Message> GetBusinessPartnerDistributionChannelByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Distribution Channel List By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblBusinessPartnerDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetBusinessPartnerDistributionChannelDTO()
                                                  {
                                                      ConfigId = bp.IntConfigId,
                                                      BusinessPartnerId = p.IntBusinessPartnerId,
                                                      BusinessPartnerName = p.StrBusinessPartnerName,
                                                      DistributionChannelId = d.IntDistributionChannelId,
                                                      DistributionChannelName = d.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
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
        public async Task<object> CreateBusinessPartnerDistributionChannel(CreateBusinessPartnerDistributionChannelDTO postBusinessPartnerDistributionChannel)
        {
            try
            {
                var detalis = new TblBusinessPartnerDistributionChannel
                {
                    IntClientId = postBusinessPartnerDistributionChannel.ClientId,
                    IntBusinessPartnerId = postBusinessPartnerDistributionChannel.BusinessPartnerId,
                    IntDistributionChannelId = postBusinessPartnerDistributionChannel.DistributionChannelId,
                    IntBusinessUnitId = postBusinessPartnerDistributionChannel.BusinessUnitId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    DteServerDateTime = DateTime.UtcNow,
                    IntActionBy = postBusinessPartnerDistributionChannel.ActionBy
                };
                await _context.TblBusinessPartnerDistributionChannel.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView  = from bp in _context.TblBusinessPartnerDistributionChannel
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                              join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntConfigId == detalis.IntConfigId
                              select new GetBusinessPartnerDistributionChannelDTO()
                              {
                                  ConfigId = bp.IntConfigId,
                                  BusinessPartnerId = p.IntBusinessPartnerId,
                                  BusinessPartnerName = p.StrBusinessPartnerName,
                                  DistributionChannelId = d.IntDistributionChannelId,
                                  DistributionChannelName = d.StrDistributionChannelName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Distribution Channel Created Successfully.",
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
        public async Task<object> EditBusinessPartnerDistributionChannel(EditBusinessPartnerDistributionChannelDTO putBusinessPartnerDistributionChannel)
        {
            try
            {
                TblBusinessPartnerDistributionChannel data = _context.TblBusinessPartnerDistributionChannel.First(x => x.IntConfigId == putBusinessPartnerDistributionChannel.ConfigId);

                data.IntConfigId = putBusinessPartnerDistributionChannel.ConfigId;
                data.IntBusinessPartnerId = putBusinessPartnerDistributionChannel.BusinessPartnerId;
                data.IntDistributionChannelId = putBusinessPartnerDistributionChannel.DistributionChannelId;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putBusinessPartnerDistributionChannel.ActionBy;

                _context.TblBusinessPartnerDistributionChannel.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblBusinessPartnerDistributionChannel
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                              join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntConfigId == putBusinessPartnerDistributionChannel.ConfigId
                              select new GetBusinessPartnerDistributionChannelDTO()
                              {
                                  ConfigId = bp.IntConfigId,
                                  BusinessPartnerId = p.IntBusinessPartnerId,
                                  BusinessPartnerName = p.StrBusinessPartnerName,
                                  DistributionChannelId = d.IntDistributionChannelId,
                                  DistributionChannelName = d.StrDistributionChannelName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Distribution Channel Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerDistributionChannel(CancelBusinessPartnerDistributionChannelDTO putBusinessPartnerDistributionChannel)
        {
            try
            {
                TblBusinessPartnerDistributionChannel data = _context.TblBusinessPartnerDistributionChannel.First(x => x.IntConfigId == putBusinessPartnerDistributionChannel.ConfigId);

                data.IntActionBy = putBusinessPartnerDistributionChannel.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerDistributionChannel.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblBusinessPartnerDistributionChannel
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblDistributionChannel on bp.IntDistributionChannelId equals d.IntDistributionChannelId
                              join p in _context.TblBusinessPartner on bp.IntBusinessPartnerId equals p.IntBusinessPartnerId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntConfigId == putBusinessPartnerDistributionChannel.ConfigId
                              select new GetBusinessPartnerDistributionChannelDTO()
                              {
                                  ConfigId = bp.IntConfigId,
                                  BusinessPartnerId = p.IntBusinessPartnerId,
                                  BusinessPartnerName = p.StrBusinessPartnerName,
                                  DistributionChannelId = d.IntDistributionChannelId,
                                  DistributionChannelName = d.StrDistributionChannelName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Distribution Channeled Cancelled Successfully.",
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
