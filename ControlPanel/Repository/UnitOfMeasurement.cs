using ControlPanel.DbContexts;
using ControlPanel.DTO.UnitOfMeasurement;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class UnitOfMeasurement : IUnitOfMeasurement
    {
        public readonly iBOSContext _context;
        public UnitOfMeasurement(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetUnitOfMeasurementAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Unit Of Measurement List.",
                    data = await Task.FromResult((from t in _context.TblUnitOfMeasurement
                                                   join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                   where t.IsActive == true 
                                                   select new GetUnitOfMeasurementDTO()
                                                   {
                                                       Uomid = t.IntUomid,
                                                       ClientId = t.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       Uomname = t.StrUomname,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = t.IntActionBy,
                                                       LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetUnitOfMeasurementById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "UnitOfMeasurement List by Id.",
                    data  = await Task.FromResult((from t in _context.TblUnitOfMeasurement
                                                   join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                   where t.IsActive == true && t.IntUomid == Id
                                                   select new GetUnitOfMeasurementDTO()
                                                   {
                                                       Uomid = t.IntUomid,
                                                       ClientId = t.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       Uomname = t.StrUomname,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = t.IntActionBy,
                                                       LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetUnitOfMeasurementByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Unit Of Measurement List by Id.",
                    data = await Task.FromResult((from t in _context.TblUnitOfMeasurement
                                                   join b in _context.TblBusinessUnit on t.IntBusinessUnitId  equals b.IntBusinessUnitId
                                                   join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                   where t.IsActive == true && b.IntBusinessUnitId == UId
                                                   select new GetUnitOfMeasurementDTO()
                                                   {
                                                       Uomid = t.IntUomid,
                                                       ClientId = t.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       Uomname = t.StrUomname,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ActionBy = t.IntActionBy,
                                                       LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetUnitOfMeasurementByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Unit Of Measurement List by Client Id.",
                    data = await Task.FromResult((from t in _context.TblUnitOfMeasurement
                                                  join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                  where t.IsActive == true && b.IntClientId == CId
                                                  select new GetUnitOfMeasurementDTO()
                                                  {
                                                      Uomid = t.IntUomid,
                                                      ClientId = t.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      Uomname = t.StrUomname,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = t.IntActionBy,
                                                      LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<object> CreateUnitOfMeasurement(CreateUnitOfMeasurementDTO postUnitOfMeasurement)
        {
            try
            {
                var detalis = new TblUnitOfMeasurement
                {
                    IntClientId = postUnitOfMeasurement.ClientId,
                    StrUomname = postUnitOfMeasurement.Uomname,
                    IntBusinessUnitId = postUnitOfMeasurement.BusinessUnitId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postUnitOfMeasurement.ActionBy
                };
                await _context.TblUnitOfMeasurement.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from t in _context.TblUnitOfMeasurement
                                  join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                  where t.IsActive == true && t.IntUomid == detalis.IntUomid
                                  select new GetUnitOfMeasurementDTO()
                                  {
                                      Uomid = t.IntUomid,
                                      ClientId = t.IntClientId,
                                      ClientName = c.StrClientName,
                                      Uomname = t.StrUomname,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ActionBy = t.IntActionBy,
                                      LastActionDateTime = t.DteLastActionDateTime
                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Unit Of Measurement Created Successfully.",
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
        public async Task<object> EditUnitOfMeasurement(EditUnitOfMeasurementDTO UnitOfMeasurement)
        {
            try
            {
                TblUnitOfMeasurement data = _context.TblUnitOfMeasurement.First(x => x.IntUomid == UnitOfMeasurement.Uomid);

                data.IntUomid = UnitOfMeasurement.Uomid;
                data.IntClientId = UnitOfMeasurement.ClientId;
                data.StrUomname = UnitOfMeasurement.Uomname;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = UnitOfMeasurement.ActionBy;

                _context.TblUnitOfMeasurement.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from t in _context.TblUnitOfMeasurement
                              join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on t.IntClientId equals c.IntClientId
                              where t.IsActive == true && t.IntUomid == UnitOfMeasurement.Uomid
                              select new GetUnitOfMeasurementDTO()
                              {
                                  Uomid = t.IntUomid,
                                  ClientId = t.IntClientId,
                                  ClientName = c.StrClientName,
                                  Uomname = t.StrUomname,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = t.IntActionBy,
                                  LastActionDateTime = t.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Unit Of Measurement Edited Successfully.",
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
        public async Task<object> CancelUnitOfMeasurement(CancelUnitOfMeasurementDTO UnitOfMeasurement)
        {
            try
            {
                TblUnitOfMeasurement data = _context.TblUnitOfMeasurement.First(x => x.IntUomid == UnitOfMeasurement.Uomid);

                data.IntActionBy = UnitOfMeasurement.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblUnitOfMeasurement.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from t in _context.TblUnitOfMeasurement
                              join b in _context.TblBusinessUnit on t.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on t.IntClientId equals c.IntClientId
                              where t.IsActive == false && t.IntUomid == UnitOfMeasurement.Uomid
                              select new GetUnitOfMeasurementDTO()
                              {
                                  Uomid = t.IntUomid,
                                  ClientId = t.IntClientId,
                                  ClientName = c.StrClientName,
                                  Uomname = t.StrUomname,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = t.IntActionBy,
                                  LastActionDateTime = t.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Unit Of Measurement Cancelled Successfully.",
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
