using ControlPanel.DbContexts;
using ControlPanel.DTO.SoldToPartnerShipToPartner;
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
    public class SoldToPartnerShipToPartner : ISoldToPartnerShipToPartner
    {
        public readonly iBOSContext _context;
        public SoldToPartnerShipToPartner(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSoldToPartnerShipToPartnerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sold To PartnerShip To Partner List ",
                    data = await Task.FromResult((from ip in _context.TblSoldToPartnerShipToPartner
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join  c in _context.TblClient on ip.IntClientId equals c.IntClientId 
                                                  where ip.IsActive == true
                                                   select new GetSoldToPartnerShipToPartnerDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       SoldToPartnerId = ip.IntSoldToPartnerId,
                                                       SoldToPartnerName = ip.StrSoldToPartnerName,
                                                       ShipToPartnerId = ip.IntShipToPartnerId,
                                                       ShipToPartnerName = ip.StrShipToPartnerName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = ip.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy =ip.IntActionBy,
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
        public async Task<Message> GetSoldToPartnerShipToPartnerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner List By Id.",
                    data = await Task.FromResult((from ip in _context.TblSoldToPartnerShipToPartner
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IsActive == true &&  ip.IntConfigId== Id
                                                  select new GetSoldToPartnerShipToPartnerDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      SoldToPartnerId = ip.IntSoldToPartnerId,
                                                      SoldToPartnerName = ip.StrSoldToPartnerName,
                                                      ShipToPartnerId = ip.IntShipToPartnerId,
                                                      ShipToPartnerName = ip.StrShipToPartnerName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> GetSoldToPartnerShipToPartnerByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner by Unit Id.",
                    data = await Task.FromResult((from ip in _context.TblSoldToPartnerShipToPartner
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IsActive == true && ip.IntBusinessUnitId == UId
                                                  select new GetSoldToPartnerShipToPartnerDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      SoldToPartnerId = ip.IntSoldToPartnerId,
                                                      SoldToPartnerName = ip.StrSoldToPartnerName,
                                                      ShipToPartnerId = ip.IntShipToPartnerId,
                                                      ShipToPartnerName = ip.StrShipToPartnerName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> GetSoldToPartnerShipToPartnerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner by Client Id.",
                    data = await Task.FromResult((from ip in _context.TblSoldToPartnerShipToPartner
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  where ip.IsActive == true && ip.IntClientId == CId
                                                  select new GetSoldToPartnerShipToPartnerDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      SoldToPartnerId = ip.IntSoldToPartnerId,
                                                      SoldToPartnerName = ip.StrSoldToPartnerName,
                                                      ShipToPartnerId = ip.IntShipToPartnerId,
                                                      ShipToPartnerName = ip.StrShipToPartnerName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<object> CreateSoldToPartnerShipToPartner(CreateSoldToPartnerShipToPartnerDTO postSoldToPartnerShipToPartner)
        {
           try
           { 
                var detalis = new TblSoldToPartnerShipToPartner
                {
                    IntSoldToPartnerId = postSoldToPartnerShipToPartner.SoldToPartnerId,
                    StrSoldToPartnerName = postSoldToPartnerShipToPartner.SoldToPartnerName,
                    IntShipToPartnerId = postSoldToPartnerShipToPartner.ShipToPartnerId,
                    StrShipToPartnerName = postSoldToPartnerShipToPartner.ShipToPartnerName,
                    IntBusinessUnitId = postSoldToPartnerShipToPartner.BusinessUnitId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postSoldToPartnerShipToPartner.ActionBy
                };
                await _context.TblSoldToPartnerShipToPartner.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblSoldToPartnerShipToPartner
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetSoldToPartnerShipToPartnerDTO()
                                  {
                                      ConfigId = ip.IntConfigId,
                                      SoldToPartnerId = ip.IntSoldToPartnerId,
                                      SoldToPartnerName = ip.StrSoldToPartnerName,
                                      ShipToPartnerId = ip.IntShipToPartnerId,
                                      ShipToPartnerName = ip.StrShipToPartnerName,
                                      ClientId = ip.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = ip.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner Created Successfully.",
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
        public async Task<object> EditSoldToPartnerShipToPartner(EditSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner)
        {
            try
            {
                TblSoldToPartnerShipToPartner data = _context.TblSoldToPartnerShipToPartner.First(x => x.IntConfigId == SoldToPartnerShipToPartner.ConfigId);

                data.IntConfigId = SoldToPartnerShipToPartner.ConfigId;
                data.IntSoldToPartnerId = SoldToPartnerShipToPartner.SoldToPartnerId;
                data.StrSoldToPartnerName = SoldToPartnerShipToPartner.SoldToPartnerName;
                data.IntShipToPartnerId = SoldToPartnerShipToPartner.ShipToPartnerId;
                data.StrShipToPartnerName = SoldToPartnerShipToPartner.ShipToPartnerName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = SoldToPartnerShipToPartner.ActionBy;

                _context.TblSoldToPartnerShipToPartner.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSoldToPartnerShipToPartner
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == true && ip.IntConfigId == SoldToPartnerShipToPartner.ConfigId
                              select new GetSoldToPartnerShipToPartnerDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  SoldToPartnerId = ip.IntSoldToPartnerId,
                                  SoldToPartnerName = ip.StrSoldToPartnerName,
                                  ShipToPartnerId = ip.IntShipToPartnerId,
                                  ShipToPartnerName = ip.StrShipToPartnerName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner Edited Successfully.",
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
        public async Task<object> CancelSoldToPartnerShipToPartner(CancelSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner)
        {
            try
            {
                TblSoldToPartnerShipToPartner data = _context.TblSoldToPartnerShipToPartner.First(x => x.IntConfigId == SoldToPartnerShipToPartner.ConfigId);

                data.IntActionBy = SoldToPartnerShipToPartner.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblSoldToPartnerShipToPartner.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSoldToPartnerShipToPartner
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              where ip.IsActive == false && ip.IntConfigId == SoldToPartnerShipToPartner.ConfigId
                              select new GetSoldToPartnerShipToPartnerDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  SoldToPartnerId = ip.IntSoldToPartnerId,
                                  SoldToPartnerName = ip.StrSoldToPartnerName,
                                  ShipToPartnerId = ip.IntShipToPartnerId,
                                  ShipToPartnerName = ip.StrShipToPartnerName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sold To PartnerShip To Partner Cancelled Successfully.",
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
