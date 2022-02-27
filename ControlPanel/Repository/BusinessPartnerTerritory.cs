using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessArea;
using ControlPanel.DTO.BusinessPartnerTerritory;
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
    public class BusinessPartnerTerritory : IBusinessPartnerTerritory
    {
        public readonly iBOSContext _context;

        public BusinessPartnerTerritory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerTerritoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner Territory List ",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  where ip.IsActive == true
                                                  select new GetBusinessPartnerTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = t.IntTerritoryId,
                                                      TerritoryName = t.StrTerritoryName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
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
        public async Task<Message> GetBusinessPartnerTerritoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Territory List By Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                  select new GetBusinessPartnerTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = t.IntTerritoryId,
                                                      TerritoryName = t.StrTerritoryName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
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
        public async Task<Message> GetBusinessPartnerTerritoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Territory List By Client Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerTerritory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetBusinessPartnerTerritoryDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      TerritoryId = t.IntTerritoryId,
                                                      TerritoryName = t.StrTerritoryName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
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
        public async Task<object> CreateBusinessPartnerTerritory(CreateBusinessPartnerTerritoryDTO postBusinessPartnerTerritory)
        {
            try
            {
                var detalis = new TblBusinessPartnerTerritory
                {
                    IntClientId = postBusinessPartnerTerritory.ClientId,
                    IntBusinessUnitId = postBusinessPartnerTerritory.BusinessUnitId,
                    IntTerritoryId = postBusinessPartnerTerritory.TerritoryId,
                    IntBusinessPartnerId = postBusinessPartnerTerritory.BusinessPartnerId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postBusinessPartnerTerritory.ActionBy
                };
                await _context.TblBusinessPartnerTerritory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblBusinessPartnerTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                              select new GetBusinessPartnerTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = t.IntTerritoryId,
                                  TerritoryName = t.StrTerritoryName,
                                  BusinessPartnerId = bp.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Territory Created Successfully.",
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
        public async Task<object> EditBusinessPartnerTerritory(EditBusinessPartnerTerritoryDTO putBusinessPartnerTerritory)
        {
            try
            {
                TblBusinessPartnerTerritory data = _context.TblBusinessPartnerTerritory.First(x => x.IntConfigId == putBusinessPartnerTerritory.ConfigId);

                data.IntConfigId = putBusinessPartnerTerritory.ConfigId;
                data.IntTerritoryId = putBusinessPartnerTerritory.TerritoryId;
                data.IntBusinessPartnerId = putBusinessPartnerTerritory.BusinessPartnerId;                
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putBusinessPartnerTerritory.ActionBy;

                _context.TblBusinessPartnerTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              where ip.IsActive == true && ip.IntConfigId == putBusinessPartnerTerritory.ConfigId
                              select new GetBusinessPartnerTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = t.IntTerritoryId,
                                  TerritoryName = t.StrTerritoryName,
                                  BusinessPartnerId = bp.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Territory Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerTerritory(CancelBusinessPartnerTerritoryDTO putBusinessPartnerTerritory)
        {
            try
            {
                TblBusinessPartnerTerritory data = _context.TblBusinessPartnerTerritory.First(x => x.IntConfigId == putBusinessPartnerTerritory.ConfigId);

                data.IntActionBy = putBusinessPartnerTerritory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerTerritory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join t in _context.TblTerritory on ip.IntTerritoryId equals t.IntTerritoryId
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              where ip.IsActive == false && ip.IntConfigId == putBusinessPartnerTerritory.ConfigId
                              select new GetBusinessPartnerTerritoryDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  TerritoryId = t.IntTerritoryId,
                                  TerritoryName = t.StrTerritoryName,
                                  BusinessPartnerId = bp.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Territory Cancelled Successfully.",
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
