using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessArea;
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
    public class BusinessArea : IBusinessArea
    {
        public readonly iBOSContext _context;
        public BusinessArea (iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessAreaAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Area List ",
                    data = await Task.FromResult((from a in _context.TblBusinessArea
                                           join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                           join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                           where a.IsActive == true
                                           select new GetBusinessAreaDTO()
                                           {
                                               BusinessAreaId = a.IntBusinessAreaId,
                                               ClientId = c.IntClientId,
                                               ClientName = c.StrClientName,
                                               BusinessUnitId = u.IntBusinessUnitId,
                                               BusinessUnitName = u.StrBusinessUnitName,
                                               BusinessAreaCode = a.StrBusinessAreaCode,
                                               BusinessAreaName = a.StrBusinessAreaName,
                                               ActionBy = a.IntActionBy,
                                               LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetBusinessAreaById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Area List By Id.",
                    data = await Task.FromResult((from a in _context.TblBusinessArea
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where a.IntBusinessAreaId == Id && a.IsActive == true
                                                  select new GetBusinessAreaDTO()
                                                  {
                                                      BusinessAreaId = a.IntBusinessAreaId,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      BusinessAreaCode = a.StrBusinessAreaCode,
                                                      BusinessAreaName = a.StrBusinessAreaName,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetBusinessAreaByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Area List By Client Id.",
                    data = await Task.FromResult((from a in _context.TblBusinessArea
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where a.IntClientId == CId && a.IsActive == true
                                                  select new GetBusinessAreaDTO()
                                                  {
                                                      BusinessAreaId = a.IntBusinessAreaId,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      BusinessAreaCode = a.StrBusinessAreaCode,
                                                      BusinessAreaName = a.StrBusinessAreaName,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<object> CreateBusinessArea(CreateBusinessAreaDTO postBusinessArea)
        {
            try
            {
                var detalis = new TblBusinessArea
                {
                    IntClientId = postBusinessArea.ClientId,
                    IntBusinessUnitId = postBusinessArea.BusinessUnitId,
                    StrBusinessAreaCode = postBusinessArea.BusinessAreaCode.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrBusinessAreaName = postBusinessArea.BusinessAreaName,
                    IntActionBy = postBusinessArea.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBusinessArea.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblBusinessArea
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              where a.IsActive == true && a.IntBusinessAreaId == detalis.IntBusinessAreaId
                              select new GetBusinessAreaDTO()
                              {
                                  BusinessAreaId = a.IntBusinessAreaId,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaCode = a.StrBusinessAreaCode,
                                  BusinessAreaName = a.StrBusinessAreaName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Area Created Successfully.",
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
        public async Task<object> EditBusinessArea(EditBusinessAreaDTO businessArea)
        {
            try
            {
                TblBusinessArea data = _context.TblBusinessArea.First(x => x.IntBusinessAreaId == businessArea.BusinessAreaId);
                data.StrBusinessAreaName = businessArea.BusinessAreaName;
                data.IntBusinessUnitId = businessArea.BusinessUnitId;
                data.IntActionBy = businessArea.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessArea.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBusinessArea
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              where a.IsActive == true && a.IntBusinessAreaId == businessArea.BusinessAreaId
                              select new GetBusinessAreaDTO()
                              {
                                  BusinessAreaId = a.IntBusinessAreaId,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaCode = a.StrBusinessAreaCode,
                                  BusinessAreaName = a.StrBusinessAreaName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Area Edited Successfully.",
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
        public async Task<object> CancelBusinessArea(CancelBusinessAreaDTO businessArea)
        {
            try
            {
                TblBusinessArea data = _context.TblBusinessArea.First(x => x.IntBusinessAreaId == businessArea.BusinessAreaId);
                data.IntActionBy = businessArea.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblBusinessArea.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblBusinessArea
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              where a.IsActive == false && a.IntBusinessAreaId == businessArea.BusinessAreaId
                              select new GetBusinessAreaDTO()
                              {
                                  BusinessAreaId = a.IntBusinessAreaId,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  BusinessAreaCode = a.StrBusinessAreaCode,
                                  BusinessAreaName = a.StrBusinessAreaName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime
                              };



                var successmsg = new Message
                {
                    status = true,
                    message = "Business Area Cancelled Successfully.",
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
