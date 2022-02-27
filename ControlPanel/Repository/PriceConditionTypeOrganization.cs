using ControlPanel.DbContexts;
using ControlPanel.DTO.PriceConditionTypeOrganization;
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
    public class PriceConditionTypeOrganization : IPriceConditionTypeOrganization
    {
        public readonly iBOSContext _context;
        public PriceConditionTypeOrganization(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPriceConditionTypeOrganizationAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All PriceConditionTypeOrganization Iteme List ",
                    data = await Task.FromResult((from c in _context.TblPriceConditionTypeOrganization
                                                  select new GetPriceConditionTypeOrganizationDTO()
                                                  {
                                                      PriceConditionTypeId = c.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = c.StrPriceConditionTypeName,
                                                      PriceConditionTypeCode = c.StrPriceConditionTypeCode,
                                                      AccessSequence = c.IntPriceConditionTypeId

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
        public async Task<Message> GetPriceConditionTypeOrganizationById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All PriceConditionTypeOrganization Item List By Id ",
                    data = await Task.FromResult((from c in _context.TblPriceConditionTypeOrganization
                                                  where c.IntPriceConditionTypeId == Id
                                                  select new GetPriceConditionTypeOrganizationDTO()
                                                  {
                                                      PriceConditionTypeId = c.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = c.StrPriceConditionTypeName,
                                                      PriceConditionTypeCode = c.StrPriceConditionTypeCode,
                                                      AccessSequence = c.IntPriceConditionTypeId

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
