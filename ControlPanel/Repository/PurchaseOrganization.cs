using ControlPanel.DbContexts;
using ControlPanel.DTO.PurchaseOrganization;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class PurchaseOrganization : IPurchaseOrganization
    {
        public readonly iBOSContext _context;
        public PurchaseOrganization(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPurchaseOrganizationAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Purchase Organization List ",
                    data = await Task.FromResult((from po in _context.TblPurchaseOrganization
                                                  join cl in _context.TblClient on po.IntClientId equals cl.IntClientId
                                                  where po.IsActive == true
                                                  select new GetPurchaseOrganizationDTO()
                                                  {
                                                      PurchaseOrganizationid= po.IntPurchaseOrganizationid,
                                                      PurchaseOrganization=po.StrPurchaseOrganization,
                                                      ClientId = cl.IntClientId, 
                                                      ClinetName = cl.StrClientName, 
                                                      IsActive = po.IsActive

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
        public async Task<Message> GetPurchaseOrganizationById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Purchase Organization List By Id.",
                    data = await Task.FromResult((from po in _context.TblPurchaseOrganization
                                                  join cl in _context.TblClient on po.IntClientId equals cl.IntClientId
                                                  where po.IsActive == true && po.IntPurchaseOrganizationid == Id
                                                  select new GetPurchaseOrganizationDTO()
                                                  {
                                                      PurchaseOrganizationid = po.IntPurchaseOrganizationid,
                                                      PurchaseOrganization = po.StrPurchaseOrganization,
                                                      ClientId = cl.IntClientId,
                                                      ClinetName = cl.StrClientName,
                                                      IsActive = po.IsActive

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
        public async Task<Message> GetPurchaseOrganizationByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Purchase Organization List By Client Id.",
                    data = await Task.FromResult((from po in _context.TblPurchaseOrganization
                                                  join cl in _context.TblClient on po.IntClientId equals cl.IntClientId
                                                  where po.IsActive == true && cl.IntClientId == CId
                                                  select new GetPurchaseOrganizationDTO()
                                                  {
                                                      PurchaseOrganizationid = po.IntPurchaseOrganizationid,
                                                      PurchaseOrganization = po.StrPurchaseOrganization,
                                                      ClientId = cl.IntClientId,
                                                      ClinetName = cl.StrClientName,
                                                      IsActive = po.IsActive

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
