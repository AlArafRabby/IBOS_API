using ControlPanel.DbContexts;
using ControlPanel.DTO.Division;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class Division : IDivision
    {
        public readonly iBOSContext _context;
        public Division(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetDivisionAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Division List ",
                    data = await Task.FromResult((from bp in _context.TblDivision
                                                  where bp.IsActive == true
                                                  select new GetDivisionDTO()
                                                  {
                                                      DivisionId = bp.IntDivisionId,
                                                      Divition = bp.StrDivition,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      DivitionBanglaName = bp.StrDivitionBanglaName

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
        public async Task<Message> GetDivisionByCountry(long CountryId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Division List by Country.",
                    data = await Task.FromResult((from bp in _context.TblDivision
                                                  where bp.IsActive == true && bp.IntCountryId == CountryId
                                                  select new GetDivisionDTO()
                                                  {
                                                      DivisionId = bp.IntDivisionId,
                                                      Divition = bp.StrDivition,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      DivitionBanglaName = bp.StrDivitionBanglaName

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
