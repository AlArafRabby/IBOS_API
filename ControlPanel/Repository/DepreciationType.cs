using ControlPanel.DbContexts;
using ControlPanel.DTO.DepreciationType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class DepreciationType : IDepreciationType
    {
        public readonly iBOSContext _context;
        public DepreciationType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetDepreciationTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Depreciation Type List ",
                    data = await Task.FromResult((from po in _context.TblDepreciationType
                                                  select new GetDepreciationTypeDTO()
                                                  {
                                                      DepreciationId = po.IntDepreciationId,
                                                      DepreciationName = po.StrDepreciationName

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
        public async Task<Message> GetDepreciationTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Depreciation Type List By Id.",
                    data = await Task.FromResult((from po in _context.TblDepreciationType
                                                  where po.IntDepreciationId == Id
                                                  select new GetDepreciationTypeDTO()
                                                  {
                                                      DepreciationId = po.IntDepreciationId,
                                                      DepreciationName = po.StrDepreciationName

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
