using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessUnitSalesOrganizationIncoterms;
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
    public class BusinessUnitSalesOrganizationIncoterms : IBusinessUnitSalesOrganizationIncoterms
    {
        public readonly iBOSContext _context;
        public BusinessUnitSalesOrganizationIncoterms(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessUnitSalesOrganizationIncotermsAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List",
                    data = await Task.FromResult((from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true
                                                  select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUintId = so.IntBusinessUintId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      IncotermsId = so.IntIncotermsId,
                                                      IncotermsName = so.StrIncotermsName,
                                                      SalesOrganizationId = so.IntSalesOrganizationId,
                                                      SalesOrganizationName = so.StrSalesOrganizationName,
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
        public async Task<Message> GetBusinessUnitSalesOrganizationIncotermsById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List by Id",
                    data = await Task.FromResult((from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntConfigId == Id
                                                  select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUintId = so.IntBusinessUintId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      IncotermsId = so.IntIncotermsId,
                                                      IncotermsName = so.StrIncotermsName,
                                                      SalesOrganizationId = so.IntSalesOrganizationId,
                                                      SalesOrganizationName = so.StrSalesOrganizationName,
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
        public async Task<Message> GetBusinessUnitSalesOrganizationIncotermsByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List By Client Id",
                    data = await Task.FromResult((from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntClientId ==  CId
                                                  select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUintId = so.IntBusinessUintId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      IncotermsId = so.IntIncotermsId,
                                                      IncotermsName = so.StrIncotermsName,
                                                      SalesOrganizationId = so.IntSalesOrganizationId,
                                                      SalesOrganizationName = so.StrSalesOrganizationName,
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
        public async Task<Message> GetBusinessUnitSalesOrganizationIncotermsByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Sales Organization Incoterms List by Id",
                    data = await Task.FromResult((from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntBusinessUintId == UId
                                                  select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                                                  {
                                                      ConfigId = so.IntConfigId,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUintId = so.IntBusinessUintId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      IncotermsId = so.IntIncotermsId,
                                                      IncotermsName = so.StrIncotermsName,
                                                      SalesOrganizationId = so.IntSalesOrganizationId,
                                                      SalesOrganizationName = so.StrSalesOrganizationName,
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
        public async Task<object> CreateBusinessUnitSalesOrganizationIncoterms(CreateBusinessUnitSalesOrganizationIncotermsDTO postBusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                var detalis = new TblBusinessUnitSalesOrganizationIncoterms
                {
                    IntClientId = postBusinessUnitSalesOrganizationIncoterms.ClientId,
                    IntBusinessUintId = postBusinessUnitSalesOrganizationIncoterms.BusinessUintId,
                    StrBusinessUnitName = postBusinessUnitSalesOrganizationIncoterms.BusinessUnitName,
                    IntIncotermsId = postBusinessUnitSalesOrganizationIncoterms.IncotermsId,
                    StrIncotermsName = postBusinessUnitSalesOrganizationIncoterms.IncotermsName,
                    IntSalesOrganizationId = postBusinessUnitSalesOrganizationIncoterms.SalesOrganizationId,
                    StrSalesOrganizationName = postBusinessUnitSalesOrganizationIncoterms.SalesOrganizationName,
                    IntActionBy = postBusinessUnitSalesOrganizationIncoterms.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblBusinessUnitSalesOrganizationIncoterms.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                                  join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                  where so.IsActive == true && so.IntConfigId == detalis.IntConfigId
                                  select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                                  {
                                      ConfigId = so.IntConfigId,
                                      ClientId = so.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUintId = so.IntBusinessUintId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      IncotermsId = so.IntIncotermsId,
                                      IncotermsName = so.StrIncotermsName,
                                      SalesOrganizationId = so.IntSalesOrganizationId,
                                      SalesOrganizationName = so.StrSalesOrganizationName,
                                      ActionBy = so.IntActionBy,
                                      LastActionDateTime = so.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business UnitSales Organization Incoterms Created Successfully.",
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
        public async Task<object> EditBusinessUnitSalesOrganizationIncoterms(EditBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                TblBusinessUnitSalesOrganizationIncoterms data = _context.TblBusinessUnitSalesOrganizationIncoterms.First(x => x.IntConfigId == BusinessUnitSalesOrganizationIncoterms.ConfigId);

                data.IntConfigId = BusinessUnitSalesOrganizationIncoterms.ConfigId;
                data.IntClientId = BusinessUnitSalesOrganizationIncoterms.ClientId;
                data.IntBusinessUintId = BusinessUnitSalesOrganizationIncoterms.BusinessUintId;
                data.StrBusinessUnitName = BusinessUnitSalesOrganizationIncoterms.BusinessUnitName;
                data.IntIncotermsId = BusinessUnitSalesOrganizationIncoterms.IncotermsId;
                data.StrIncotermsName = BusinessUnitSalesOrganizationIncoterms.IncotermsName;
                data.IntSalesOrganizationId = BusinessUnitSalesOrganizationIncoterms.SalesOrganizationId;
                data.StrSalesOrganizationName = BusinessUnitSalesOrganizationIncoterms.SalesOrganizationName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = BusinessUnitSalesOrganizationIncoterms.ActionBy;

                _context.TblBusinessUnitSalesOrganizationIncoterms.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                              join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == true && so.IntConfigId == BusinessUnitSalesOrganizationIncoterms.ConfigId
                              select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                              {
                                  ConfigId = so.IntConfigId,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUintId = so.IntBusinessUintId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  IncotermsId = so.IntIncotermsId,
                                  IncotermsName = so.StrIncotermsName,
                                  SalesOrganizationId = so.IntSalesOrganizationId,
                                  SalesOrganizationName = so.StrSalesOrganizationName,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "BusinessUnitSalesOrganizationIncoterms Edited Successfully.",
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
        public async Task<object> CancelBusinessUnitSalesOrganizationIncoterms(CancelBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms)
        {
            try
            {
                TblBusinessUnitSalesOrganizationIncoterms data = _context.TblBusinessUnitSalesOrganizationIncoterms.First(x => x.IntConfigId == BusinessUnitSalesOrganizationIncoterms.ConfigId);

                data.IntConfigId = BusinessUnitSalesOrganizationIncoterms.ConfigId;
                data.IntActionBy = BusinessUnitSalesOrganizationIncoterms.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessUnitSalesOrganizationIncoterms.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblBusinessUnitSalesOrganizationIncoterms
                              join b in _context.TblBusinessUnit on so.IntBusinessUintId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == false && so.IntConfigId == BusinessUnitSalesOrganizationIncoterms.ConfigId
                              select new GetBusinessUnitSalesOrganizationIncotermsDTO()
                              {
                                  ConfigId = so.IntConfigId,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUintId = so.IntBusinessUintId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  IncotermsId = so.IntIncotermsId,
                                  IncotermsName = so.StrIncotermsName,
                                  SalesOrganizationId = so.IntSalesOrganizationId,
                                  SalesOrganizationName = so.StrSalesOrganizationName,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business UnitSales Organization Incoterms Cancelled Successfully.",
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
