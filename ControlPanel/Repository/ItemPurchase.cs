using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemPurchase;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class ItemPurchase : IItemPurchase
    { public readonly iBOSContext _context;
        public ItemPurchase(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> getItemPurchaseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Plant Ware House List ",
                    data = await Task.FromResult((from ip in _context.TblItemPurchase
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IsActive == true
                                                  select new GetItemPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      PurchaseDescription = ip.StrPurchaseDescription,
                                                      Hscode = ip.StrHscode,
                                                      MaxLeadDays = ip.NumMaxLeadDays,
                                                      MinLeadDays = ip.NumMinLeadDays,
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
        public async Task<Message> getItemPurchasebyId(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Plant Ware House List by Id",
                    data = await Task.FromResult((from ip in _context.TblItemPurchase
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                  select new GetItemPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      PurchaseDescription = ip.StrPurchaseDescription,
                                                      Hscode = ip.StrHscode,
                                                      MaxLeadDays = ip.NumMaxLeadDays,
                                                      MinLeadDays = ip.NumMinLeadDays,
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
        public async Task<Message> getItemPurchasebybusinsessunit(long businsessunitId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Plant Ware House List by Unit Id ",
                    data = await Task.FromResult((from ip in _context.TblItemPurchase
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntBusinessUnitId == businsessunitId
                                                  select new GetItemPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      PurchaseDescription = ip.StrPurchaseDescription,
                                                      Hscode = ip.StrHscode,
                                                      MaxLeadDays = ip.NumMaxLeadDays,
                                                      MinLeadDays = ip.NumMinLeadDays,
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
        public async Task<object> CreateItemPurchase(CreateItemPurchaseDTO ItemPurchase)
        {
            try
            {
                var detalis = new TblItemPurchase
                {
                    IntClientId = ItemPurchase.ClientId,
                    IntBusinessUnitId = ItemPurchase.BusinessUnitId,
                    IntPlantId = ItemPurchase.PlantId,
                    IntPurchaseOrganizationId = ItemPurchase.PurchaseOrganizationId,
                    IntItemId = ItemPurchase.ItemId,
                    StrPurchaseDescription = ItemPurchase.PurchaseDescription,
                    StrHscode = ItemPurchase.Hscode,
                    NumMaxLeadDays = ItemPurchase.MaxLeadDays,
                    NumMinLeadDays = ItemPurchase.MinLeadDays,
                    NumMinOrderQuantity = ItemPurchase.MinOrderQuantity,
                    NumLotSize = ItemPurchase.LotSize,
                    IntActionBy = ItemPurchase.ActionBy,
                    DteLastActionDateTime = ItemPurchase.LastActionDateTime
                };
                await _context.TblItemPurchase.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblItemPurchase
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetItemPurchaseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  PurchaseDescription = ip.StrPurchaseDescription,
                                  Hscode = ip.StrHscode,
                                  MaxLeadDays = ip.NumMaxLeadDays,
                                  MinLeadDays = ip.NumMinLeadDays,
                                  MinOrderQuantity = ip.NumMinOrderQuantity,
                                  LotSize = ip.NumLotSize,
                                  LastActionDateTime = ip.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Purchase Create Successfully.",
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
        public async Task<object> EditItemPurchase(EidtItemPurchaseDTO putItemPurchase)
        {
            try
            {
                TblItemPurchase data = _context.TblItemPurchase.First(x => x.IntConfigId == putItemPurchase.Id);
                data.IntPlantId = putItemPurchase.PlantId;
                data.IntItemId = putItemPurchase.ItemId;
                data.IntActionBy = putItemPurchase.ActionBy;
                data.StrPurchaseDescription = putItemPurchase.PurchaseDescription;
                data.StrHscode = putItemPurchase.Hscode;
                data.NumMaxLeadDays = putItemPurchase.MaxLeadDays;
                data.NumMinLeadDays = putItemPurchase.MinLeadDays;
                data.NumMinOrderQuantity = putItemPurchase.MinOrderQuantity;
                data.NumLotSize = putItemPurchase.LotSize;
                data.IntActionBy = putItemPurchase.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblItemPurchase.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemPurchase
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              where ip.IsActive == true && ip.IntConfigId == putItemPurchase.Id
                              select new GetItemPurchaseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  PurchaseDescription = ip.StrPurchaseDescription,
                                  Hscode = ip.StrHscode,
                                  MaxLeadDays = ip.NumMaxLeadDays,
                                  MinLeadDays = ip.NumMinLeadDays,
                                  MinOrderQuantity = ip.NumMinOrderQuantity,
                                  LotSize = ip.NumLotSize,
                                  LastActionDateTime = ip.DteLastActionDateTime
                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Purchase Edit Successfully.",
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
        public async Task<object> CancelItemPurchase(CancelItemPurchaseDTO ItemPurchase)
        {
            try
            {
                TblItemPurchase data = _context.TblItemPurchase.First(x => x.IntConfigId == ItemPurchase.Id);
                data.IntActionBy = ItemPurchase.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblItemPurchase.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemPurchase
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                              join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                              where ip.IsActive == false && ip.IntConfigId == ItemPurchase.Id
                              select new GetItemPurchaseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = p.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  ItemId = i.IntItemId,
                                  ItemName = i.StrItemName,
                                  PurchaseDescription = ip.StrPurchaseDescription,
                                  Hscode = ip.StrHscode,
                                  MaxLeadDays = ip.NumMaxLeadDays,
                                  MinLeadDays = ip.NumMinLeadDays,
                                  MinOrderQuantity = ip.NumMinOrderQuantity,
                                  LotSize = ip.NumLotSize,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Purchase Cancel Successfully.",
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
        public async Task<Message> getItemPurchasebyClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Plant Ware House List by client Id",
                    data = await Task.FromResult((from ip in _context.TblItemPurchase
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join p in _context.TblPlant on ip.IntPlantId equals p.IntPlantId
                                                  join i in _context.TblItem on ip.IntItemId equals i.IntItemId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetItemPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = p.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      ItemId = i.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      PurchaseDescription = ip.StrPurchaseDescription,
                                                      Hscode = ip.StrHscode,
                                                      MaxLeadDays = ip.NumMaxLeadDays,
                                                      MinLeadDays = ip.NumMinLeadDays,
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
    }
}
