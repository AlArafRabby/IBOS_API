using ControlPanel.DbContexts;
using ControlPanel.DTO;
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
    public class Item:IItem
    {
        public readonly iBOSContext _context;

        public Item(iBOSContext context)
        {
            _context = context;
        }  
        public async Task<Message> GetIItemAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item List ",
                    data = await Task.FromResult((from bp in _context.TblItem
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where bp.IsActive == true
                                           select new GetItemDTO()
                                           {
                                               Id = bp.IntItemId,
                                               BusinessUnitId = bp.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemCode = bp.StrItemCode,
                                               ItemName = bp.StrItemName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = bp.StrItemTypeName,
                                               ItemCategoryId = bp.IntItemCategoryId,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               ItemSubCategoryName = bp.StrItemSubCategoryName,
                                               Uomid = bp.IntUomid,
                                               Uomname = bp.StrUomname,
                                               GrossWeightKg = bp.NumGrossWeightKg,
                                               NetWeightKg = bp.NumNetWeightKg

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
        public async Task<Message> GetIItemById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item List By Id.",
                    data = await Task.FromResult((from bp in _context.TblItem
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where bp.IntItemId == Id && bp.IsActive == true
                                           select new GetItemDTO()
                                           {
                                               Id = bp.IntItemId,
                                               BusinessUnitId = bp.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemMasterId = bp.IntItemMasterId,
                                               ItemCode = bp.StrItemCode,
                                               ItemName = bp.StrItemName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = bp.StrItemTypeName,
                                               ItemCategoryId = bp.IntItemCategoryId,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               ItemSubCategoryId = bp.IntItemSubCategoryId,
                                               ItemSubCategoryName = bp.StrItemSubCategoryName,
                                               Uomid = bp.IntUomid,
                                               Uomname = bp.StrUomname,
                                               GrossWeightKg = bp.NumGrossWeightKg,
                                               NetWeightKg = bp.NumNetWeightKg

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
        public async Task<Message> GetIItemByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item List By Unit Id. ",
                    data = await Task.FromResult((from bp in _context.TblItem
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where bp.IntBusinessUnitId == UId && bp.IsActive == true
                                           select new GetItemDTO()
                                           {
                                               Id = bp.IntItemId,
                                               BusinessUnitId = bp.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemMasterId = bp.IntItemMasterId,
                                               ItemCode = bp.StrItemCode,
                                               ItemName = bp.StrItemName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = bp.StrItemTypeName,
                                               ItemCategoryId = bp.IntItemCategoryId,
                                               ItemSubCategoryId = bp.IntItemSubCategoryId,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               ItemSubCategoryName = bp.StrItemSubCategoryName,
                                               Uomid = bp.IntUomid,
                                               Uomname = bp.StrUomname,
                                               GrossWeightKg = bp.NumGrossWeightKg,
                                               NetWeightKg = bp.NumNetWeightKg

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
        public async Task<object> CreateIItem(CreateItemDTO postItem)
        {
            try
            {
                List<CreateItemDTO> userList = new List<CreateItemDTO>();

                var detalis = new TblItem
                {   IntClientId=postItem.ClientId,
                    IntBusinessUnitId = postItem.BusinessUnitId,
                    IntItemMasterId = postItem.ItemMasterId,
                    StrItemCode = postItem.ItemName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrItemName = postItem.ItemName,
                    IntItemTypeId = postItem.ItemTypeId,
                    StrItemTypeName = postItem.ItemTypeName,
                    IntItemCategoryId = postItem.ItemCategoryId,
                    StrItemCategoryName = postItem.ItemCategoryName,
                    IntItemSubCategoryId = postItem.ItemSubCategoryId,
                    StrItemSubCategoryName = postItem.ItemSubCategoryName,
                    IntUomid = postItem.Uomid,
                    StrUomname = postItem.Uomname,
                    NumGrossWeightKg = postItem.GrossWeightKg,
                    NumNetWeightKg = postItem.NetWeightKg,
                    IntActionBy = postItem.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                };
                await _context.TblItem.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblItem
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IsActive == true && bp.IntItemId == detalis.IntItemId
                                  select new GetItemDTO()
                              {
                                  Id = bp.IntItemId,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemMasterId = bp.IntItemMasterId,
                                  ItemCode = bp.StrItemCode,
                                  ItemName = bp.StrItemName,
                                  ItemTypeId = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  ItemCategoryId = bp.IntItemCategoryId,
                                  ItemCategoryName = bp.StrItemCategoryName,
                                  ItemSubCategoryId=bp.IntItemSubCategoryId,
                                  ItemSubCategoryName = bp.StrItemSubCategoryName,
                                  Uomid = bp.IntUomid,
                                  Uomname = bp.StrUomname,
                                  GrossWeightKg = bp.NumGrossWeightKg,
                                  NetWeightKg = bp.NumNetWeightKg

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Create Successfully.",
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
        public async Task<object> EditIItem(EditItemDTO Item)
        {
            try
            {
                TblItem data = _context.TblItem.First(x => x.IntItemId == Item.Id);
                data.IntItemMasterId = Item.ItemMasterId;
                data.StrItemName = Item.ItemName;
                data.IntItemTypeId = Item.ItemTypeId;
                data.StrItemTypeName = Item.ItemTypeName;
                data.IntItemCategoryId = Item.ItemCategoryId;
                data.StrItemCategoryName = Item.ItemCategoryName;
                data.IntItemSubCategoryId = Item.ItemSubCategoryId;
                data.StrItemSubCategoryName = Item.ItemSubCategoryName;
                data.IntUomid = Item.Uomid;
                data.StrUomname = Item.Uomname;
                data.NumGrossWeightKg = Item.GrossWeightKg;
                data.NumNetWeightKg = Item.NetWeightKg;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblItem.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblItem
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IsActive == true && bp.IntItemId == Item.Id
                              select new GetItemDTO()
                              {
                                  Id = bp.IntItemId,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemMasterId = bp.IntItemMasterId,
                                  ItemCode = bp.StrItemCode,
                                  ItemName = bp.StrItemName,
                                  ItemTypeId = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  ItemCategoryId = bp.IntItemCategoryId,
                                  ItemCategoryName = bp.StrItemCategoryName,
                                  ItemSubCategoryId = bp.IntItemSubCategoryId,
                                  ItemSubCategoryName = bp.StrItemSubCategoryName,
                                  Uomid = bp.IntUomid,
                                  Uomname = bp.StrUomname,
                                  GrossWeightKg = bp.NumGrossWeightKg,
                                  NetWeightKg = bp.NumNetWeightKg

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Edit Successfully.",
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
        public async Task<object> CancelIItem(CancelItemDTO Item)
        {
            try
            {
                TblItem data = _context.TblItem.First(x => x.IntItemId == Item.Id);

                data.IntActionBy = Item.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblItem.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblItem
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IsActive == false && bp.IntItemId == Item.Id
                              select new GetItemDTO()
                              {
                                  Id = bp.IntItemId,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemCode = bp.StrItemCode,
                                  ItemMasterId = bp.IntItemMasterId,
                                  ItemName = bp.StrItemName,
                                  ItemTypeId = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  ItemCategoryId = bp.IntItemCategoryId,
                                  ItemCategoryName = bp.StrItemCategoryName,
                                  ItemSubCategoryId = bp.IntItemSubCategoryId,
                                  ItemSubCategoryName = bp.StrItemSubCategoryName,
                                  Uomid = bp.IntUomid,
                                  Uomname = bp.StrUomname,
                                  GrossWeightKg = bp.NumGrossWeightKg,
                                  NetWeightKg = bp.NumNetWeightKg

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Cancel Successfully.",
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
        public async Task<Message> GetIItemByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item List By Client Id. ",
                    data = await Task.FromResult((from bp in _context.TblItem
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where  bp.IsActive == true && bp.IntClientId==CId
                                                  select new GetItemDTO()
                                                  {
                                                      Id = bp.IntItemId,
                                                      BusinessUnitId = bp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemMasterId = bp.IntItemMasterId,
                                                      ItemCode = bp.StrItemCode,
                                                      ItemName = bp.StrItemName,
                                                      ItemTypeId = bp.IntItemTypeId,
                                                      ItemTypeName = bp.StrItemTypeName,
                                                      ItemCategoryId = bp.IntItemCategoryId,
                                                      ItemCategoryName = bp.StrItemCategoryName,
                                                      ItemSubCategoryId = bp.IntItemSubCategoryId,
                                                      ItemSubCategoryName = bp.StrItemSubCategoryName,
                                                      Uomid = bp.IntUomid,
                                                      Uomname = bp.StrUomname,
                                                      GrossWeightKg = bp.NumGrossWeightKg,
                                                      NetWeightKg = bp.NumNetWeightKg

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
