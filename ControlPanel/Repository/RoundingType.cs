using ControlPanel.DbContexts;
using ControlPanel.DTO.RoundingType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class RoundingType : IRoundingType
    {
        public readonly iBOSContext _context;
        public RoundingType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetRoundingTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Rounding Type List ",
                    data = await Task.FromResult((from po in _context.TblRoundingType
                                                
                                                  select new GetRoundingTypeDTO()
                                                  {
                                                      RoundingTypeId = po.IntRoundingTypeId, 
                                                      RoundingTypeName = po.StrRoundingTypeName


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
        public async Task<Message> GetRoundingTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Rounding Type List By Id.",
                    data = await Task.FromResult((from po in _context.TblRoundingType
                                                  where po.IntRoundingTypeId == Id
                                                  select new GetRoundingTypeDTO()
                                                  {
                                                      RoundingTypeId = po.IntRoundingTypeId,
                                                      RoundingTypeName = po.StrRoundingTypeName

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
