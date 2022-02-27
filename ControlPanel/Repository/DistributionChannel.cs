using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.DistributionChannel;
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
    public class DistributionChannel : IDistributionChannel
    {
        public readonly iBOSContext _context;

        public DistributionChannel(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetDistributionChannelAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Distribution Channel List ",
                    data = await Task.FromResult((from bp in _context.TblDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                  select new GetDistributionChannelDTO()
                                                  {
                                                      DistributionChannelId = bp.IntDistributionChannelId,
                                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                                      DistributionChannelName = bp.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
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
        public async Task<Message> GetDistributionChannelById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Distribution Channel List By Id.",
                    data = await Task.FromResult((from bp in _context.TblDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntDistributionChannelId == Id && bp.IsActive == true
                                                  select new GetDistributionChannelDTO()
                                                  {
                                                      DistributionChannelId = bp.IntDistributionChannelId,
                                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                                      DistributionChannelName = bp.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
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
        public async Task<Message> GetDistributionChannelByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Distribution Channel List By Unit Id.",
                    data = await Task.FromResult((from bp in _context.TblDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntBusinessUnitId == UId && bp.IsActive == true
                                                  select new GetDistributionChannelDTO()
                                                  {
                                                      DistributionChannelId = bp.IntDistributionChannelId,
                                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                                      DistributionChannelName = bp.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
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
        public async Task<Message> GetDistributionChannelByAreaId(long AId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Distribution Channel List By Area Id.",
                    data = await Task.FromResult((from bp in _context.TblDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntBusinessAreaId == AId && bp.IsActive == true
                                                  select new GetDistributionChannelDTO()
                                                  {
                                                      DistributionChannelId = bp.IntDistributionChannelId,
                                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                                      DistributionChannelName = bp.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
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
        public async Task<Message> GetDistributionChannelByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Distribution Channel List By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblDistributionChannel
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetDistributionChannelDTO()
                                                  {
                                                      DistributionChannelId = bp.IntDistributionChannelId,
                                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                                      DistributionChannelName = bp.StrDistributionChannelName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
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
        public async Task<object> CreateDistributionChannel(CreateDistributionChannelDTO postDistributionChannel)
        {
            try
            {
                var detalis = new TblDistributionChannel
                {
                    IntClientId = postDistributionChannel.ClientId,
                    StrDistributionChannelCode = postDistributionChannel.DistributionChannelCode.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrDistributionChannelName = postDistributionChannel.DistributionChannelName,
                    IntBusinessUnitId = postDistributionChannel.BusinessUnitId,
                    IntBusinessAreaId = postDistributionChannel.BusinessAreaId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postDistributionChannel.ActionBy
                };
                await _context.TblDistributionChannel.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblDistributionChannel
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntDistributionChannelId == detalis.IntDistributionChannelId
                                  select new GetDistributionChannelDTO()
                                  {
                                      DistributionChannelId = bp.IntDistributionChannelId,
                                      DistributionChannelCode = bp.StrDistributionChannelCode,
                                      DistributionChannelName = bp.StrDistributionChannelName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      BusinessAreaId = d.IntBusinessAreaId,
                                      BusinessAreaName = d.StrBusinessAreaName,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Distribution Channel Created Successfully.",
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
        public async Task<object> EditDistributionChannel(EditDistributionChannelDTO distributionChannel)
        {
            try
            {
                TblDistributionChannel data = _context.TblDistributionChannel.First(x => x.IntDistributionChannelId == distributionChannel.DistributionChannelId);

                data.IntDistributionChannelId = distributionChannel.DistributionChannelId;
                data.StrDistributionChannelName = distributionChannel.DistributionChannelName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = distributionChannel.ActionBy;

                _context.TblDistributionChannel.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblDistributionChannel
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntDistributionChannelId == distributionChannel.DistributionChannelId
                              select new GetDistributionChannelDTO()
                              {
                                  DistributionChannelId = bp.IntDistributionChannelId,
                                  DistributionChannelCode = bp.StrDistributionChannelCode,
                                  DistributionChannelName = bp.StrDistributionChannelName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Distribution Channel Edited Successfully.",
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
        public async Task<object> CancelDistributionChannel(CancelDistributionChannelDTO distributionChannel)
        {
            try
            {
                TblDistributionChannel data = _context.TblDistributionChannel.First(x => x.IntDistributionChannelId == distributionChannel.DistributionChannelId);

                data.IntActionBy = distributionChannel.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblDistributionChannel.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblDistributionChannel
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntDistributionChannelId == distributionChannel.DistributionChannelId
                              select new GetDistributionChannelDTO()
                              {
                                  DistributionChannelId = bp.IntDistributionChannelId,
                                  DistributionChannelCode = bp.StrDistributionChannelCode,
                                  DistributionChannelName = bp.StrDistributionChannelName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Distribution Channel Cancelled Successfully.",
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
