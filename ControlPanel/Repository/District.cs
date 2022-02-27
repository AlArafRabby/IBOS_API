using ControlPanel.DbContexts;
using ControlPanel.DTO.District;
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
    public class District : IDistrict
    {
        public readonly iBOSContext _context;
        public District(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetDistrictAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All District List ",
                    data = await Task.FromResult((from bp in _context.TblDistrict
                                                  join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                  select new GetDistrictDTO()
                                                  {
                                                      DistrictId = bp.IntDistrictId,
                                                      DistrictCode = bp.StrDistrictCode,
                                                      DistrictName = bp.StrDistrictName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = b.StrCountryName,
                                                      ActionBy = b.IntActionBy,
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
        public async Task<Message> GetDistrictId(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "District List By Id.",
                    data = await Task.FromResult((from bp in _context.TblDistrict
                                                  join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntDistrictId == Id
                                                  select new GetDistrictDTO()
                                                  {
                                                      DistrictId = bp.IntDistrictId,
                                                      DistrictCode = bp.StrDistrictCode,
                                                      DistrictName = bp.StrDistrictName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = b.StrCountryName,
                                                      ActionBy = b.IntActionBy,
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
        public async Task<Message> GetDistrictByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "District List By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblDistrict
                                                  join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetDistrictDTO()
                                                  {
                                                      DistrictId = bp.IntDistrictId,
                                                      DistrictCode = bp.StrDistrictCode,
                                                      DistrictName = bp.StrDistrictName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = b.StrCountryName,
                                                      ActionBy = b.IntActionBy,
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
        public async Task<object> CreateDistrict(CreateDistrictDTO postDistrict)
        {
            try
            {
                var detalis = new TblDistrict
                {
                    IntClientId = postDistrict.ClientId,
                    StrDistrictCode = postDistrict.DistrictName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrDistrictName = postDistrict.DistrictName,
                    IntCountryId = postDistrict.CountryId,
                    IntActionBy = postDistrict.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblDistrict.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblDistrict
                                  join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntDistrictId == detalis.IntDistrictId
                                  select new GetDistrictDTO()
                                  {
                                      DistrictId = bp.IntDistrictId,
                                      DistrictCode = bp.StrDistrictCode,
                                      DistrictName = bp.StrDistrictName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      CountryId = bp.IntCountryId,
                                      CountryName = b.StrCountryName,
                                      ActionBy = b.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "District Created Successfully.",
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
        public async Task<object> EditDistrict(EditDistrictDTO district)
        {
            try
            {
                TblDistrict data = _context.TblDistrict.First(x => x.IntDistrictId == district.DistrictId);
                data.IntDistrictId = district.DistrictId;
                data.StrDistrictName = district.DistrictName;
                data.IntCountryId = district.CountryId;
                data.IntActionBy = district.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblDistrict.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblDistrict
                              join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntDistrictId == district.DistrictId
                              select new GetDistrictDTO()
                              {
                                  DistrictId = bp.IntDistrictId,
                                  DistrictCode = bp.StrDistrictCode,
                                  DistrictName = bp.StrDistrictName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  CountryId = bp.IntCountryId,
                                  CountryName = b.StrCountryName,
                                  ActionBy = b.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "District Edited Successfully.",
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
        public async Task<object> CancelDistrict(CancelDistrictDTO district)
        {
            try
            {
                TblDistrict data = _context.TblDistrict.First(x => x.IntDistrictId == district.DistrictId);

                data.IntDistrictId = district.DistrictId;
                data.IntActionBy = district.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblDistrict.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblDistrict
                              join b in _context.TblCountry on bp.IntCountryId equals b.IntCountryId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntDistrictId == district.DistrictId
                              select new GetDistrictDTO()
                              {
                                  DistrictId = bp.IntDistrictId,
                                  DistrictCode = bp.StrDistrictCode,
                                  DistrictName = bp.StrDistrictName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  CountryId = bp.IntCountryId,
                                  CountryName = b.StrCountryName,
                                  ActionBy = b.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "District Cancelled Successfully.",
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
