using ControlPanel.DbContexts;
using ControlPanel.DTO.Outlet;
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
    public class Outlet : IOutlet
    {
        public readonly iBOSContext _context;
        public Outlet(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetOutletAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Outlet List.",
                    data = await Task.FromResult((from bp in _context.TblOutlet
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                  select new GetOutletDTO()
                                                  {
                                                      OutletId = bp.IntOutletId,
                                                      OutletCode = bp.StrOutletCode,
                                                      OutletName = bp.StrOutletName,
                                                      ClientId = bp.IntClientId ,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetOutletById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change by id ",
                    data = await Task.FromResult((from bp in _context.TblOutlet
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true &&  bp.IntOutletId == Id
                                                  select new GetOutletDTO()
                                                  {
                                                      OutletId = bp.IntOutletId,
                                                      OutletCode = bp.StrOutletCode,
                                                      OutletName = bp.StrOutletName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetOutletByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Log Territory Sales Force Change by Client id ",
                    data = await Task.FromResult((from bp in _context.TblOutlet
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetOutletDTO()
                                                  {
                                                      OutletId = bp.IntOutletId,
                                                      OutletCode = bp.StrOutletCode,
                                                      OutletName = bp.StrOutletName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<object> CreateOutlet(CreateOutletDTO postOutlet)
        {
            try
            {
                var detalis = new TblOutlet
                {
                    IntClientId = postOutlet.ClientId,
                    StrOutletCode = postOutlet.OutletName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrOutletName = postOutlet.OutletName,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postOutlet.ActionBy
                };
                await _context.TblOutlet.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblOutlet
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntOutletId == detalis.IntOutletId
                                  select new GetOutletDTO()
                                  {
                                      OutletId = bp.IntOutletId,
                                      OutletCode = bp.StrOutletCode,
                                      OutletName = bp.StrOutletName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Created Successfully.",
                    data = detalisView
                };

                return successmsg;
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
        public async Task<object> EditOutlet(EditOutletDTO outlet)
        {
            try
            {
                TblOutlet data = _context.TblOutlet.First(x => x.IntOutletId == outlet.OutletId);

                data.IntOutletId = outlet.OutletId;
                data.StrOutletName = outlet.OutletName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = outlet.ActionBy;

                _context.TblOutlet.Update(data);
                await _context.SaveChangesAsync();

                var Details = from bp in _context.TblOutlet
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntOutletId == outlet.OutletId
                              select new GetOutletDTO()
                              {
                                  OutletId = bp.IntOutletId,
                                  OutletCode = bp.StrOutletCode,
                                  OutletName = bp.StrOutletName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Edited Successfully.",
                    data = Details
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
        public async Task<object> CancelOutlet(CancelOutletDTO outlet)
        {
            try
            {
                TblOutlet data = _context.TblOutlet.First(x => x.IntOutletId == outlet.OutletId);

                data.IntActionBy = outlet.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblOutlet.Update(data);
                await _context.SaveChangesAsync();

                var Details = from bp in _context.TblOutlet
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntOutletId == outlet.OutletId
                              select new GetOutletDTO()
                              {
                                  OutletId = bp.IntOutletId,
                                  OutletCode = bp.StrOutletCode,
                                  OutletName = bp.StrOutletName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Outlet Cancelled Successfully.",
                    data = Details
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
