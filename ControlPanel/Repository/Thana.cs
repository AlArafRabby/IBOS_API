using ControlPanel.DbContexts;
using ControlPanel.DTO.Thana;
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
    public class Thana : IThana
    {
        public readonly iBOSContext _context;
        public Thana(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetThanaAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Thana List ",
                    data = await Task.FromResult((from t in _context.TblThana
                                                  join d in _context.TblDistrict on t.IntDistrictId equals d.IntDistrictId
                                                  where t.IsActive == true
                                                  select new GetThanaDTO()
                                                  {
                                                      ThanaId = t.IntThanaId,
                                                      ThanaName = t.StrThanaName,
                                                      DistrictId = t.IntDistrictId, 
                                                      DistrictName = d.StrDistrictName,
                                                      ThanaBanglaName = t.StrThanaBanglaName,
                                                      Geocode = t.IntGeocode

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                Message m = new Message();
                Console.WriteLine(m.data);


                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetThanaById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Thana List By Id ",
                    data = await Task.FromResult((from t in _context.TblThana
                                                  join d in _context.TblDistrict on t.IntDistrictId equals d.IntDistrictId
                                                  where t.IsActive == true && t.IntThanaId == Id
                                                  select new GetThanaDTO()
                                                  {
                                                      ThanaId = t.IntThanaId,
                                                      ThanaName = t.StrThanaName,
                                                      DistrictId = t.IntDistrictId,
                                                      DistrictName = d.StrDistrictName,
                                                      ThanaBanglaName = t.StrThanaBanglaName,
                                                      Geocode = t.IntGeocode

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
    }
}
