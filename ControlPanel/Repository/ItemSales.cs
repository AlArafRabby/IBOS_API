using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemSales;
using ControlPanel.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using ControlPanellNew.Helper;

namespace ControlPanel.Repository
{
    public class ItemSales : IItemSales
    {
        public readonly iBOSContext _context;
        public ItemSales(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemSalesAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Sales ",
                    data = await Task.FromResult((from ip in _context.TblItemSales
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IsActive == true
                                                  select new GetItemSalesDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      ProductDivisionId = pd.IntProductDivisionId,
                                                      ProductDivisionName = pd.StrProductDivisionName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      SalesDescription=ip.StrSalesDescription,
                                                      MinOrderQuantity=ip.NumMinOrderQuantity, 
                                                      LotSize=ip.NumLotSize,
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
        public async Task<Message> GetItemSalesById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Sales Id  ",
                    data = await Task.FromResult((from ip in _context.TblItemSales
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                  select new GetItemSalesDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      ProductDivisionId = pd.IntProductDivisionId,
                                                      ProductDivisionName = pd.StrProductDivisionName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      SalesDescription = ip.StrSalesDescription,
                                                      MinOrderQuantity = ip.NumMinOrderQuantity,
                                                      LotSize = ip.NumLotSize,
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
        public async Task<Message> GetItemSalesByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Sales Bussiness Unit Id  ",
                    data = await Task.FromResult((from ip in _context.TblItemSales
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntBusinessUnitId == UId && ip.IsActive == true
                                                  select new GetItemSalesDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      ProductDivisionId = pd.IntProductDivisionId,
                                                      ProductDivisionName = pd.StrProductDivisionName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      SalesDescription = ip.StrSalesDescription,
                                                      MinOrderQuantity = ip.NumMinOrderQuantity,
                                                      LotSize = ip.NumLotSize,
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
        public async Task<Message> GetItemSalesByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Sales Bussiness Unit Client Id  ",
                    data = await Task.FromResult((from ip in _context.TblItemSales
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetItemSalesDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      ProductDivisionId = pd.IntProductDivisionId,
                                                      ProductDivisionName = pd.StrProductDivisionName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      SalesDescription = ip.StrSalesDescription,
                                                      MinOrderQuantity = ip.NumMinOrderQuantity,
                                                      LotSize = ip.NumLotSize,
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
        public async Task<Message> CreateItemSales(CreateItemSalesDTO postitemSales)
        {
            try { 
            var detalis = new TblItemSales
            {
                IntClientId = postitemSales.ClientId,
                IntBusinessUnitId = postitemSales.BusinessUnitId,
                IntSalesOrganizationId = postitemSales.SalesOrganizationId,
                IntProductDivisionId = postitemSales.ProductDivisionId,
                IntProfitCenterId=postitemSales.ProfitCenterId,
                IntItemId = postitemSales.ItemId,
                StrSalesDescription = postitemSales.SalesDescription,
                NumMinOrderQuantity = postitemSales.MinOrderQuantity,
                NumLotSize = postitemSales.LotSize,
                IntActionBy = postitemSales.ActionBy,
                DteLastActionDateTime = postitemSales.LastActionDateTime
            };
            await _context.TblItemSales.AddAsync(detalis);
            await _context.SaveChangesAsync();

            var detalisView = from ip in _context.TblItemSales
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              where ip.IntConfigId == detalis.IntConfigId && ip.IsActive == true
                              select new GetItemSalesDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationName = s.StrSalesOrganizationName,
                                  ProductDivisionId = pd.IntProductDivisionId,
                                  ProductDivisionName = pd.StrProductDivisionName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  SalesDescription = ip.StrSalesDescription,
                                  MinOrderQuantity = ip.NumMinOrderQuantity,
                                  LotSize = ip.NumLotSize,
                                  LastActionDateTime = ip.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute Create Successfully.",
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
        public async Task<Message> EditteItemSales(EditItemSalesDTO ItemSales)
        {
            try
            {
                TblItemSales data = _context.TblItemSales.First(x => x.IntConfigId == ItemSales.Id);
                data.IntSalesOrganizationId = ItemSales.SalesOrganizationId;
                data.IntProductDivisionId = ItemSales.ProductDivisionId;
                data.IntItemId = ItemSales.ItemId;
                data.StrSalesDescription = ItemSales.SalesDescription;
                data.NumMinOrderQuantity = ItemSales.MinOrderQuantity;
                data.IntProfitCenterId = ItemSales.ProfitCenterId;
                data.NumLotSize = ItemSales.LotSize;
                data.IntActionBy = ItemSales.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblItemSales.Update(data);
                await _context.SaveChangesAsync();
                var detalis =from ip in _context.TblItemSales
                                    join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                    join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                    join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                                    join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                    where ip.IntConfigId == ItemSales.Id  && ip.IsActive == true
                                    select new GetItemSalesDTO()
                                    {
                                        ConfigId = ip.IntConfigId,
                                        BusinessUnitId = b.IntBusinessUnitId,
                                        BusinessUnitName = b.StrBusinessUnitName,
                                        SalesOrganizationId = s.IntSalesOrganizationId,
                                        SalesOrganizationName = s.StrSalesOrganizationName,
                                        ProductDivisionId = pd.IntProductDivisionId,
                                        ProductDivisionName = pd.StrProductDivisionName,
                                        ItemId = i.IntItemId,
                                        ItemName = i.StrItemName,
                                        SalesDescription = ip.StrSalesDescription,
                                        MinOrderQuantity = ip.NumMinOrderQuantity,
                                        LotSize = ip.NumLotSize,
                                        LastActionDateTime = ip.DteLastActionDateTime
                                    };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Sales Edit Successfully.",
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
        public async Task<Message> CancelteItemSales(CancelItemSalesDTO ItemSales)
        {
            try
            {
                TblItemSales data = _context.TblItemSales.First(x => x.IntConfigId == ItemSales.Id);
                data.IntActionBy = ItemSales.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblItemSales.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemSales
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              join pd in _context.TblProductDivision on ip.IntProductDivisionId equals pd.IntProductDivisionId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              where ip.IntConfigId == ItemSales.Id && ip.IsActive == false
                              select new GetItemSalesDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationName = s.StrSalesOrganizationName,
                                  ProductDivisionId = pd.IntProductDivisionId,
                                  ProductDivisionName = pd.StrProductDivisionName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  SalesDescription = ip.StrSalesDescription,
                                  MinOrderQuantity = ip.NumMinOrderQuantity,
                                  LotSize = ip.NumLotSize,
                                  LastActionDateTime = ip.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Sales Cancel Successfully.",
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
