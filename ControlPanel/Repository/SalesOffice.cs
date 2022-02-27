using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesOffice;
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
    public class SalesOffice : ISalesOffice
    {
        public readonly iBOSContext _context;
        public SalesOffice(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesOfficeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Office List: ",
                    data = await Task.FromResult((from so in _context.TblSalesOffice
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true
                                                  select new GetSalesOfficeDTO()
                                                  {
                                                      SalesOfficeId = so.IntSalesOfficeId,
                                                      SalesOfficeName = so.StrSalesOfficeName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesOfficeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Office List By  Id",
                    data = await Task.FromResult((from so in _context.TblSalesOffice
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntSalesOfficeId == Id
                                                  select new GetSalesOfficeDTO()
                                                  {
                                                      SalesOfficeId = so.IntSalesOfficeId,
                                                      SalesOfficeName = so.StrSalesOfficeName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesOfficeByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Office List By Client Id",
                    data = await Task.FromResult((from so in _context.TblSalesOffice
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntClientId == CId
                                                  select new GetSalesOfficeDTO()
                                                  {
                                                      SalesOfficeId = so.IntSalesOfficeId,
                                                      SalesOfficeName = so.StrSalesOfficeName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetSalesOfficeByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Office List By Unit Id",
                    data = await Task.FromResult((from so in _context.TblSalesOffice
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                                  where so.IsActive == true && so.IntBusinessUnitId == UId
                                                  select new GetSalesOfficeDTO()
                                                  {
                                                      SalesOfficeId = so.IntSalesOfficeId,
                                                      SalesOfficeName = so.StrSalesOfficeName,
                                                      BusinessUnitId = so.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = so.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<object> CreateSalesOffice(CreateSalesOfficeDTO postSalesOffice)
        {
            try
            {
                var detalis = new TblSalesOffice
                {
                    StrSalesOfficeName = postSalesOffice.SalesOfficeName,
                    IntClientId = postSalesOffice.ClientId,
                    IntBusinessUnitId = postSalesOffice.BusinessUnitId,
                    IntActionBy = postSalesOffice.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblSalesOffice.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from so in _context.TblSalesOffice
                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on so.IntClientId equals c.IntClientId
                                  where so.IsActive == true && so.IntSalesOfficeId == detalis.IntSalesOfficeId
                                  select new GetSalesOfficeDTO()
                                  {
                                      SalesOfficeId = so.IntSalesOfficeId,
                                      SalesOfficeName = so.StrSalesOfficeName,
                                      BusinessUnitId = so.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ClientId = so.IntClientId,
                                      ClientName = c.StrClientName,
                                      ActionBy = so.IntActionBy,
                                      LastActionDateTime = so.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Office Created Successfully.",
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
        public async Task<object> EditSalesOffice(EditSalesOfficeDTO SalesOffice)
        {
            try
            {
                TblSalesOffice data = _context.TblSalesOffice.First(x => x.IntSalesOfficeId == SalesOffice.SalesOfficeId);

                data.IntSalesOfficeId = SalesOffice.SalesOfficeId;
                data.StrSalesOfficeName = SalesOffice.SalesOfficeName;
                data.IntClientId = SalesOffice.ClientId;
                data.IntBusinessUnitId = SalesOffice.BusinessUnitId;
                data.IntActionBy = SalesOffice.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = SalesOffice.ActionBy;

                _context.TblSalesOffice.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblSalesOffice
                              join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == true && so.IntSalesOfficeId == SalesOffice.SalesOfficeId
                              select new GetSalesOfficeDTO()
                              {
                                  SalesOfficeId = so.IntSalesOfficeId,
                                  SalesOfficeName = so.StrSalesOfficeName,
                                  BusinessUnitId = so.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Force Edited Successfully.",
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
        public async Task<object> CancelSalesOffice(CancelSalesOfficeDTO SalesOffice)
        {
            try
            {
                TblSalesOffice data = _context.TblSalesOffice.First(x => x.IntSalesOfficeId == SalesOffice.SalesOfficeId);

                data.IntSalesOfficeId = SalesOffice.SalesOfficeId;
                data.IntActionBy = SalesOffice.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblSalesOffice.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from so in _context.TblSalesOffice
                              join b in _context.TblBusinessUnit on so.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on so.IntClientId equals c.IntClientId
                              where so.IsActive == false && so.IntSalesOfficeId == SalesOffice.SalesOfficeId
                              select new GetSalesOfficeDTO()
                              {
                                  SalesOfficeId = so.IntSalesOfficeId,
                                  SalesOfficeName = so.StrSalesOfficeName,
                                  BusinessUnitId = so.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = so.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = so.IntActionBy,
                                  LastActionDateTime = so.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Force Cancelled Successfully.",
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
