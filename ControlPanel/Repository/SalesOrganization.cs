using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesOrganization;
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
    public class SalesOrganization : ISalesOrganization
    {
        public readonly iBOSContext _context;
        public SalesOrganization(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesOrganizationAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Organization List: ",
                    data = await Task.FromResult((from bp in _context.TblSalesOrganization
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                   select new GetSalesOrganizationDTO()
                                                   {
                                                       SalesOrganizationId = bp.IntSalesOrganizationId,
                                                       SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                                       SalesOrganizationName = bp.StrSalesOrganizationName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName ,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       BusinessAreaId = d.IntBusinessAreaId,
                                                       BusinessAreaName = d.StrBusinessAreaName,
                                                       ActionBy = b.IntActionBy, 
                                                       LastActionDateTime = b.DteLastActionDateTime

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
        public async Task<Message> GetSalesOrganizationById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Organization List by Id:",
                    data = await Task.FromResult((from bp in _context.TblSalesOrganization
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntSalesOrganizationId == Id
                                                  select new GetSalesOrganizationDTO()
                                                  {
                                                      SalesOrganizationId = bp.IntSalesOrganizationId,
                                                      SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                                      SalesOrganizationName = bp.StrSalesOrganizationName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = b.IntActionBy,
                                                      LastActionDateTime = b.DteLastActionDateTime

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
        public async Task<Message> GetSalesOrganizationByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Organization List by Unit:",
                    data = await Task.FromResult((from bp in _context.TblSalesOrganization
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntBusinessUnitId == UId
                                                  select new GetSalesOrganizationDTO()
                                                  {
                                                      SalesOrganizationId = bp.IntSalesOrganizationId,
                                                      SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                                      SalesOrganizationName = bp.StrSalesOrganizationName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = b.IntActionBy,
                                                      LastActionDateTime = b.DteLastActionDateTime

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
        public async Task<Message> GetSalesOrganizationByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Organization List by Client Id:",
                    data = await Task.FromResult((from bp in _context.TblSalesOrganization
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetSalesOrganizationDTO()
                                                  {
                                                      SalesOrganizationId = bp.IntSalesOrganizationId,
                                                      SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                                      SalesOrganizationName = bp.StrSalesOrganizationName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = b.IntActionBy,
                                                      LastActionDateTime = b.DteLastActionDateTime

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
        public async Task<object> CreateSalesOrganization(CreateSalesOrganizationDTO postSalesOrganization)
        {
            try
            {
                var detalis = new TblSalesOrganization
                {
                    StrSalesOrganizationCode = postSalesOrganization.SalesOrganizationCode,
                    StrSalesOrganizationName = postSalesOrganization.SalesOrganizationName,
                    IntBusinessUnitId = postSalesOrganization.BusinessUnitId,
                    IntBusinessAreaId = postSalesOrganization.BusinessAreaId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postSalesOrganization.ActionBy
                };
                await _context.TblSalesOrganization.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblSalesOrganization
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntSalesOrganizationId == detalis.IntSalesOrganizationId
                                  select new GetSalesOrganizationDTO()
                                  {
                                      SalesOrganizationId = bp.IntSalesOrganizationId,
                                      SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                      SalesOrganizationName = bp.StrSalesOrganizationName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      BusinessAreaId = d.IntBusinessAreaId,
                                      BusinessAreaName = d.StrBusinessAreaName,
                                      ActionBy = b.IntActionBy,
                                      LastActionDateTime = b.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Organization Created Successfully.",
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
        public async Task<object> EditSalesOrganization(EditSalesOrganizationDTO salesOrganization)
        {
            try
            {
                TblSalesOrganization data = _context.TblSalesOrganization.First(x => x.IntSalesOrganizationId == salesOrganization.SalesOrganizationId);
                data.IntSalesOrganizationId = salesOrganization.SalesOrganizationId;
                data.StrSalesOrganizationName = salesOrganization.SalesOrganizationName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = salesOrganization.ActionBy;

                _context.TblSalesOrganization.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblSalesOrganization
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntSalesOrganizationId == salesOrganization.SalesOrganizationId
                              select new GetSalesOrganizationDTO()
                              {
                                  SalesOrganizationId = bp.IntSalesOrganizationId,
                                  SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                  SalesOrganizationName = bp.StrSalesOrganizationName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = b.IntActionBy,
                                  LastActionDateTime = b.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Organization Edited Successfully.",
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
        public async Task<object> CancelSalesOrganization(CancelSalesOrganizationDTO salesOrganization)
        {
            try
            {
                TblSalesOrganization data = _context.TblSalesOrganization.First(x => x.IntSalesOrganizationId == salesOrganization.SalesOrganizationId);
                data.IntActionBy = salesOrganization.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblSalesOrganization.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblSalesOrganization
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntSalesOrganizationId == salesOrganization.SalesOrganizationId
                              select new GetSalesOrganizationDTO()
                              {
                                  SalesOrganizationId = bp.IntSalesOrganizationId,
                                  SalesOrganizationCode = bp.StrSalesOrganizationCode,
                                  SalesOrganizationName = bp.StrSalesOrganizationName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = b.IntActionBy,
                                  LastActionDateTime = b.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Organization Cancelled Successfully.",
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
