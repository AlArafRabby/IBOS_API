using ControlPanel.DbContexts;
using ControlPanel.DTO.Vehicle;
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
    public class Vehicle : IVehicle
    {
        public readonly iBOSContext _context;
        public Vehicle(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetVehicleAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Vehicle List.",
                    data = await Task.FromResult((from v in _context.TblVehicle
                                                  join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on v.IntClientId equals c.IntClientId
                                                  where v.IsActive == true
                                                  select new GetVehicleDTO()
                                                  {
                                                      VehicleId = v.IntVehicleId,
                                                      VehicleCode = v.StrVehicleCode,
                                                      VehicleNo = v.StrVehicleNo,
                                                      BusinessUnitId = v.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = v.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = v.IntActionBy,
                                                      LastActionDateTime = v.DteLastActionDateTime

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
        public async Task<Message> GetVehicleByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Vehicle List.",
                    data = await Task.FromResult((from v in _context.TblVehicle
                                                  join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on v.IntClientId equals c.IntClientId
                                                  where v.IsActive == true && c.IntClientId == CId
                                                  select new GetVehicleDTO()
                                                  {
                                                      VehicleId = v.IntVehicleId,
                                                      VehicleCode = v.StrVehicleCode,
                                                      VehicleNo = v.StrVehicleNo,
                                                      BusinessUnitId = v.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = v.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = v.IntActionBy,
                                                      LastActionDateTime = v.DteLastActionDateTime

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
        public async Task<Message> GetVehicleById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Vehicle List.",
                    data = await Task.FromResult((from v in _context.TblVehicle
                                                  join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on v.IntClientId equals c.IntClientId
                                                  where v.IsActive == true && v.IntVehicleId == Id
                                                  select new GetVehicleDTO()
                                                  {
                                                      VehicleId = v.IntVehicleId,
                                                      VehicleCode = v.StrVehicleCode,
                                                      VehicleNo = v.StrVehicleNo,
                                                      BusinessUnitId = v.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = v.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = v.IntActionBy,
                                                      LastActionDateTime = v.DteLastActionDateTime

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
        public async Task<Message> GetVehicleByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Vehicle List.",
                    data = await Task.FromResult((from v in _context.TblVehicle
                                                  join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on v.IntClientId equals c.IntClientId
                                                  where v.IsActive == true && v.IntBusinessUnitId == UId
                                                  select new GetVehicleDTO()
                                                  {
                                                      VehicleId = v.IntVehicleId,
                                                      VehicleCode = v.StrVehicleCode,
                                                      VehicleNo = v.StrVehicleNo,
                                                      BusinessUnitId = v.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = v.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      ActionBy = v.IntActionBy,
                                                      LastActionDateTime = v.DteLastActionDateTime

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
        public async Task<object> CreateVehicle(CreateVehicleDTO postVehicle)
        {
            try
            {
                var detalis = new TblVehicle
                {
                    StrVehicleNo= postVehicle.VehicleNo,
                    StrVehicleCode = postVehicle.VehicleNo.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    IntBusinessUnitId = postVehicle.BusinessUnitId,
                    IntClientId = postVehicle.ClientId,
                    IntActionBy = postVehicle.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblVehicle.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from v in _context.TblVehicle
                                  join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on v.IntClientId equals c.IntClientId
                                  where v.IsActive == true && v.IntBusinessUnitId == detalis.IntVehicleId
                                  select new GetVehicleDTO()
                                  {
                                      VehicleId = v.IntVehicleId,
                                      VehicleCode = v.StrVehicleCode,
                                      VehicleNo = v.StrVehicleNo,
                                      BusinessUnitId = v.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ClientId = v.IntClientId,
                                      ClientName = c.StrClientName,
                                      ActionBy = v.IntActionBy,
                                      LastActionDateTime = v.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Vehicle Created Successfully.",
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
        public async Task<object> EditVehicle(EditVehicleDTO putVehicle)
        {
            try
            {
                TblVehicle data = _context.TblVehicle.First(x => x.IntVehicleId == putVehicle.VehicleId);

                data.IntVehicleId = putVehicle.VehicleId;
                data.StrVehicleNo = putVehicle.VehicleNo;
                data.IntBusinessUnitId = putVehicle.BusinessUnitId;
                data.IntClientId = putVehicle.ClientId;
                data.IntActionBy = putVehicle.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblVehicle.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from v in _context.TblVehicle
                              join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on v.IntClientId equals c.IntClientId
                              where v.IsActive == true && v.IntBusinessUnitId == putVehicle.VehicleId
                              select new GetVehicleDTO()
                              {
                                  VehicleId = v.IntVehicleId,
                                  VehicleCode = v.StrVehicleCode,
                                  VehicleNo = v.StrVehicleNo,
                                  BusinessUnitId = v.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = v.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = v.IntActionBy,
                                  LastActionDateTime = v.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Vehicle has been Edited Successfully.",
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
        public async Task<object> CancelVehicle(CancelVehicleDTO putVehicle)
        {
            try
            {
                TblVehicle data = _context.TblVehicle.First(x => x.IntVehicleId == putVehicle.VehicleId);

                data.IntVehicleId = putVehicle.VehicleId;
                data.IntActionBy = putVehicle.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblVehicle.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from v in _context.TblVehicle
                              join b in _context.TblBusinessUnit on v.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on v.IntClientId equals c.IntClientId
                              where v.IsActive == true && v.IntBusinessUnitId == putVehicle.VehicleId
                              select new GetVehicleDTO()
                              {
                                  VehicleId = v.IntVehicleId,
                                  VehicleCode = v.StrVehicleCode,
                                  VehicleNo = v.StrVehicleNo,
                                  BusinessUnitId = v.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = v.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = v.IntActionBy,
                                  LastActionDateTime = v.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Vehicle Cancelled Successfully.",
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
