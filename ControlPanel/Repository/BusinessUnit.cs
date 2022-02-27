using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessUnit : IBusinessUnit
    {
        public readonly iBOSContext _context;

        public BusinessUnit(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessUnitAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit List.",
                    data = await Task.FromResult((from u in _context.TblBusinessUnit
                           join c in _context.TblClient on u.IntClientId equals c.IntClientId
                           where u.IsActive == true
                           select new GetBusinessUnitDTO
                           {
                               Id = u.IntBusinessUnitId,
                               Code = u.StrBusinessUnitCode,
                               Name = u.StrBusinessUnitName,
                               Address = u.StrBusinessUnitAddress,
                               ClientId = u.IntClientId,
                               ClientName = c.StrClientName,
                               ActionBy = u.IntActionBy,
                               dteLastActionDateTime = u.DteLastActionDateTime

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
        public async Task<Message> GetBusinessUnitById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Unit List By Id.",
                    data = await Task.FromResult((from u in _context.TblBusinessUnit
                                                  join c in _context.TblClient on u.IntClientId equals c.IntClientId
                                                  where u.IsActive == true && u.IntBusinessUnitId == Id
                                                  select new GetBusinessUnitDTO
                                                  {
                                                      Id = u.IntBusinessUnitId,
                                                      Code = u.StrBusinessUnitCode,
                                                      Name = u.StrBusinessUnitName,
                                                      Address = u.StrBusinessUnitAddress,
                                                      ClientId = u.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = u.IntActionBy,
                                                      dteLastActionDateTime = u.DteLastActionDateTime

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
        public async Task<Message> GetBusinessUnitByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Unit List By client Id.",
                    data = await Task.FromResult((from u in _context.TblBusinessUnit
                                                  join c in _context.TblClient on u.IntClientId equals c.IntClientId
                                                  where u.IsActive == true && u.IntClientId == CId
                                                  select new GetBusinessUnitDTO
                                                  {
                                                      Id = u.IntBusinessUnitId,
                                                      Code = u.StrBusinessUnitCode,
                                                      Name = u.StrBusinessUnitName,
                                                      Address = u.StrBusinessUnitAddress,
                                                      ClientId = u.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = u.IntActionBy,
                                                      dteLastActionDateTime = u.DteLastActionDateTime

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
        public async Task<object> CreateBusinessUnit(CreateBusinessUnitDTO postBusinessUnit)
        {
            try
            {
                var detalis = new TblBusinessUnit
                {
                    StrBusinessUnitCode = postBusinessUnit.Name.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrBusinessUnitName = postBusinessUnit.Name,
                    StrBusinessUnitAddress = postBusinessUnit.Address,
                    IntActionBy = postBusinessUnit.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntClientId = postBusinessUnit.ClientId
                };
                await _context.TblBusinessUnit.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from u in _context.TblBusinessUnit
                              join c in _context.TblClient on u.IntClientId equals c.IntClientId
                              where u.IsActive == true && u.IntBusinessUnitId == detalis.IntBusinessUnitId
                              select new GetBusinessUnitDTO
                              {
                                  Id = u.IntBusinessUnitId,
                                  Code = u.StrBusinessUnitCode,
                                  Name = u.StrBusinessUnitName,
                                  Address = u.StrBusinessUnitAddress,
                                  ClientId = u.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = u.IntActionBy,
                                  dteLastActionDateTime = u.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Unit Created Successfully.",
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
        public async Task<object> EditBusinessUnit(EditBusinessUnitDTO businessUnit)
        {
            try
            {
                TblBusinessUnit data = _context.TblBusinessUnit.First(x => x.IntBusinessUnitId == businessUnit.Id);
                data.StrBusinessUnitName = businessUnit.Name;
                data.StrBusinessUnitAddress = businessUnit.Address;
                data.IntActionBy = businessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from u in _context.TblBusinessUnit
                              join c in _context.TblClient on u.IntClientId equals c.IntClientId
                              where u.IsActive == true && u.IntBusinessUnitId == businessUnit.Id
                              select new GetBusinessUnitDTO
                              {
                                  Id = u.IntBusinessUnitId,
                                  Code = u.StrBusinessUnitCode,
                                  Name = u.StrBusinessUnitName,
                                  Address = u.StrBusinessUnitAddress,
                                  ClientId = u.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = u.IntActionBy,
                                  dteLastActionDateTime = u.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Unit Edited Successfully.",
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
        public async Task<object> CancelBusinessUnit(CancelBusinessUnitDTO businessUnit)
        {
            try
            {
                TblBusinessUnit data = _context.TblBusinessUnit.First(x => x.IntBusinessUnitId == businessUnit.Id);

                data.IntActionBy = businessUnit.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessUnit.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from u in _context.TblBusinessUnit
                              join c in _context.TblClient on u.IntClientId equals c.IntClientId
                              where u.IsActive == false && u.IntBusinessUnitId == businessUnit.Id
                              select new GetBusinessUnitDTO
                              {
                                  Id = u.IntBusinessUnitId,
                                  Code = u.StrBusinessUnitCode,
                                  Name = u.StrBusinessUnitName,
                                  Address = u.StrBusinessUnitAddress,
                                  ClientId = u.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = u.IntActionBy,
                                  dteLastActionDateTime = u.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Unit Cancelled Successfully.",
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
