using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.Country;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using ControlPanellNew.Helper;

namespace ControlPanel.Repository
{
    public class Country : ICountry
    {
        public readonly iBOSContext _context;
        public Country(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetCountryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Country List ",
                    data = await Task.FromResult((from bgl in _context.TblCountry
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true
                                                  select  new GetCountryDTO()
                                                  {
                                                        CountryId = bgl.IntCountryId,
                                                        CountryCode = bgl.StrCountryCode,
                                                        CountryName = bgl.StrCountryName,
                                                        ClientId = bgl.IntClientId,
                                                        ClientName = cl.StrClientName,
                                                        ActionBy = bgl.IntActionBy,
                                                        LastActionDateTime = bgl.DteLastActionDateTime
               
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
        public async Task<Message> GetCountryId(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = " Country List by Id",
                    data = await Task.FromResult((from bgl in _context.TblCountry
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true && bgl.IntCountryId == Id
                                                  select new GetCountryDTO()
                                                  {
                                                      CountryId = bgl.IntCountryId,
                                                      CountryCode = bgl.StrCountryCode,
                                                      CountryName = bgl.StrCountryName,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      ActionBy = bgl.IntActionBy,
                                                      LastActionDateTime = bgl.DteLastActionDateTime

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
        public async Task<Message> GetCountryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Country List by Client Id. ",
                    data = await Task.FromResult((from bgl in _context.TblCountry
                                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true && bgl.IntClientId == CId
                                                  select new GetCountryDTO()
                                                  {
                                                      CountryId = bgl.IntCountryId,
                                                      CountryCode = bgl.StrCountryCode,
                                                      CountryName = bgl.StrCountryName,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      ActionBy = bgl.IntActionBy,
                                                      LastActionDateTime = bgl.DteLastActionDateTime

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
        public async Task<object> CreateCountry(CreateCountryDTO postCountry)
        {
            try
            {
                var detalis = new TblCountry
                {
                    IntClientId = postCountry.ClientId,
                    StrCountryCode = postCountry.CountryName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrCountryName = postCountry.CountryName,
                    IntActionBy = postCountry.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblCountry.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bgl in _context.TblCountry
                                  join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                                  where bgl.IsActive == true && bgl.IntCountryId == detalis.IntCountryId
                                  select new GetCountryDTO()
                                  {
                                      CountryId = bgl.IntCountryId,
                                      CountryCode = bgl.StrCountryCode,
                                      CountryName = bgl.StrCountryName,
                                      ClientId = bgl.IntClientId,
                                      ClientName = cl.StrClientName,
                                      ActionBy = bgl.IntActionBy,
                                      LastActionDateTime = bgl.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Country Created Successfully.",
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
        public async Task<object> EditCountry(EditCountryDTO Country)
        {
            try
            {
                TblCountry data = _context.TblCountry.First(x => x.IntCountryId == Country.CountryId);

                data.StrCountryName = Country.CountryName;
                data.IntActionBy = Country.ActionBy;

                _context.TblCountry.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblCountry
                              join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                              where bgl.IsActive == true && bgl.IntCountryId == Country.CountryId
                              select new GetCountryDTO()
                              {
                                  CountryId = bgl.IntCountryId,
                                  CountryCode = bgl.StrCountryCode,
                                  CountryName = bgl.StrCountryName,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  ActionBy = bgl.IntActionBy,
                                  LastActionDateTime = bgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Country Edited Successfully.",
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
        public async Task<object> CancelCountry(CancelCountryDTO Country)
        {
            try
            {
                TblCountry data = _context.TblCountry.First(x => x.IntCountryId == Country.CountryId);

                data.IntActionBy = Country.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblCountry.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblCountry
                              join cl in _context.TblClient on bgl.IntClientId equals cl.IntClientId
                              where bgl.IsActive == false && bgl.IntCountryId == Country.CountryId
                              select new GetCountryDTO()
                              {
                                  CountryId = bgl.IntCountryId,
                                  CountryCode = bgl.StrCountryCode,
                                  CountryName = bgl.StrCountryName,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  ActionBy = bgl.IntActionBy,
                                  LastActionDateTime = bgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Country Edited Successfully.",
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
