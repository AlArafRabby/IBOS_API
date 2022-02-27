using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesArea;
using ControlPanellNew.Helper;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class SalesArea : ISalesArea
    {
        public readonly iBOSContext _context;
        public SalesArea(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesAreaAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Area List: ",
                    data = await Task.FromResult((from ip in _context.TblSalesArea
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId                                         
                                                   where ip.IsActive == true
                                                   select new GetSalesAreaDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ClientId = ip.IntClientId ,
                                                       ClientName = c.StrClientName,
                                                       DistributionChannelId = d.IntDistributionChannelId,
                                                       DistributionChannelName = d.StrDistributionChannelName,
                                                       ProductDivisionId = pd.IntProductDivisionId,
                                                       ProductDivisionName = pd.StrProductDivisionName,
                                                       SalesOrganizationId = s.IntSalesOrganizationId,
                                                       SalesOrganizationname = s.StrSalesOrganizationName,
                                                       ActionBy = ip.IntActionBy,
                                                       LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<Message> GetSalesAreaById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Area List by Id: ",
                    data = await Task.FromResult((from ip in _context.TblSalesArea
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                   where ip.IsActive == true && ip.IntConfigId== Id
                                                   select new GetSalesAreaDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       DistributionChannelId = d.IntDistributionChannelId,
                                                       DistributionChannelName = d.StrDistributionChannelName,
                                                       ProductDivisionId = pd.IntProductDivisionId,
                                                       ProductDivisionName = pd.StrProductDivisionName,
                                                       SalesOrganizationId = s.IntSalesOrganizationId,
                                                       SalesOrganizationname = s.StrSalesOrganizationName,
                                                       ActionBy = ip.IntActionBy,
                                                       LastActionDateTime = ip.DteLastActionDateTime


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
        public async Task<Message> GetSalesAreaByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Area List by Unit Id: ",
                    data = await Task.FromResult((from ip in _context.TblSalesArea
                                                   join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                                                   join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                   where ip.IsActive == true && ip.IntConfigId == UId
                                                   select new GetSalesAreaDTO()
                                                   {
                                                       ConfigId = ip.IntConfigId,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ClientId = ip.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       DistributionChannelId = d.IntDistributionChannelId,
                                                       DistributionChannelName = d.StrDistributionChannelName,
                                                       ProductDivisionId = pd.IntProductDivisionId,
                                                       ProductDivisionName = pd.StrProductDivisionName,
                                                       SalesOrganizationId = s.IntSalesOrganizationId,
                                                       SalesOrganizationname = s.StrSalesOrganizationName,
                                                       ActionBy = ip.IntActionBy,
                                                       LastActionDateTime = ip.DteLastActionDateTime


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
        public async Task<Message> GetSalesAreaByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Area List by Client Id: ",
                    data = await Task.FromResult((from ip in _context.TblSalesArea
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                  where ip.IsActive == true && ip.IntClientId == CId
                                                  select new GetSalesAreaDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      DistributionChannelId = d.IntDistributionChannelId,
                                                      DistributionChannelName = d.StrDistributionChannelName,
                                                      ProductDivisionId = pd.IntProductDivisionId,
                                                      ProductDivisionName = pd.StrProductDivisionName,
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationname = s.StrSalesOrganizationName,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime


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
        public async Task<object> CreateSalesArea(CreateSalesAreaDTO postSalesArea)
        {
            try
            { 
                var detalis = new TblSalesArea
                {
                    IntBusinessUnitId = postSalesArea.BusinessUnitId,
                    IntDistributionChannelId = postSalesArea.DistributionChannelId,
                    IntProductDivisionId = postSalesArea.ProductDivisionId,
                    IntSalesOrganizationId = postSalesArea.SalesOrganizationId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postSalesArea.ActionBy
                };
                await _context.TblSalesArea.AddAsync(detalis);
                await _context.SaveChangesAsync();


                var detalisView = from ip in _context.TblSalesArea
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                  where ip.IsActive == true && ip.IntConfigId ==detalis.IntConfigId
                                  select new GetSalesAreaDTO()
                                  {
                                      ConfigId = ip.IntConfigId,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ClientId = ip.IntClientId,
                                      ClientName = c.StrClientName,
                                      DistributionChannelId = d.IntDistributionChannelId,
                                      DistributionChannelName = d.StrDistributionChannelName,
                                      ProductDivisionId = pd.IntProductDivisionId,
                                      ProductDivisionName = pd.StrProductDivisionName,
                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                      SalesOrganizationname = s.StrSalesOrganizationName,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Area Created Successfully.",
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
        public async Task<object> EditSalesArea(EditSalesAreaDTO SalesArea)
        {
            try
            {
                TblSalesArea data = _context.TblSalesArea.First(x => x.IntConfigId == SalesArea.ConfigId);

                data.IntConfigId = SalesArea.ConfigId;
                data.IntDistributionChannelId = SalesArea.DistributionChannelId;
                data.IntProductDivisionId = SalesArea.ProductDivisionId;
                data.IntSalesOrganizationId = SalesArea.SalesOrganizationId;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = SalesArea.ActionBy;

                _context.TblSalesArea.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSalesArea
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                              where ip.IsActive == true && ip.IntConfigId == SalesArea.ConfigId
                              select new GetSalesAreaDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  DistributionChannelId = d.IntDistributionChannelId,
                                  DistributionChannelName = d.StrDistributionChannelName,
                                  ProductDivisionId = pd.IntProductDivisionId,
                                  ProductDivisionName = pd.StrProductDivisionName,
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationname = s.StrSalesOrganizationName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Area Edited Successfully.",
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
        public async Task<object> CancelSalesArea(CancelSalesAreaDTO SalesArea)
        {
            try
            {
                TblSalesArea data = _context.TblSalesArea.First(x => x.IntConfigId == SalesArea.ConfigId);

                data.IntActionBy = SalesArea.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblSalesArea.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblSalesArea
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblDistributionChannel on ip.IntDistributionChannelId equals d.IntDistributionChannelId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                              where ip.IsActive == false && ip.IntConfigId == SalesArea.ConfigId
                              select new GetSalesAreaDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  DistributionChannelId = d.IntDistributionChannelId,
                                  DistributionChannelName = d.StrDistributionChannelName,
                                  ProductDivisionId = pd.IntProductDivisionId,
                                  ProductDivisionName = pd.StrProductDivisionName,
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationname = s.StrSalesOrganizationName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Sales Area Cancelled Successfully.",
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
