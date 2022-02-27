using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemSubCategory;
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
    public class ItemSubCategory : IItemSubCategory
    {
        public readonly iBOSContext _context;
        public ItemSubCategory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemSubCategoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Sub Catagory List ",
                    data = await Task.FromResult((from ip in _context.TblItemSubCategory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                                                  join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                                                  join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                                                  where ip.IsActive == true
                                                  select new GetItemSubCategoryDTO()
                                                  {
                                                   
                                                      Id = ip.IntItemSubCategoryId, 
                                                      Code = ip.StrItemSubCategoryCode,
                                                      ItemSubCategoryName = ip.StrItemSubCategoryName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName=cl.StrClientName,
                                                      BusinessUnitId=ip.IntBusinessUnitId,
                                                      BusinessUnitName=b.StrBusinessUnitName,
                                                      ItemTypeId=ip.IntItemTypeId,
                                                      ItemTypeName=ti.StrItemTypeName,                                                    
                                                      ItemCategoryId=ic.IntItemCategoryId,
                                                      ItemCategoryName=ic.StrItemCategoryName,
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
        public async Task<Message> GetItemSubCategoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Sub Catagory by Id ",
                    data = await Task.FromResult((from ip in _context.TblItemSubCategory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                                                  join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                                                  join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                                                  where ip.IsActive == true && ip.IntItemSubCategoryId == Id
                                                  select new GetItemSubCategoryDTO()
                                                  {
                                                      Id = ip.IntItemSubCategoryId,
                                                      Code = ip.StrItemSubCategoryCode,
                                                      ItemSubCategoryName = ip.StrItemSubCategoryName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemTypeId = ip.IntItemTypeId,
                                                      ItemTypeName = ti.StrItemTypeName,
                                                      ItemCategoryId = ic.IntItemCategoryId,
                                                      ItemCategoryName = ic.StrItemCategoryName,
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
        public async Task<Message> GetItemSubCategoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Sub Catagory by clientid Id ",
                    data = await Task.FromResult((from ip in _context.TblItemSubCategory
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                                                  join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                                                  join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                                                  where ip.IsActive == true && ip.IntClientId == CId
                                                  select new GetItemSubCategoryDTO()
                                                  {
                                                      Id = ip.IntItemSubCategoryId,
                                                      Code = ip.StrItemSubCategoryCode,
                                                      ItemSubCategoryName = ip.StrItemSubCategoryName,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = ip.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemTypeId = ip.IntItemTypeId,
                                                      ItemTypeName = ti.StrItemTypeName,
                                                      ItemCategoryId = ic.IntItemCategoryId,
                                                      ItemCategoryName = ic.StrItemCategoryName,
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
        public async Task<object> CreateItemSubCategory(CreateItemSubCategoryDTO postItemSubCategory)
        {
            try
            {
                var detalis = new TblItemSubCategory
                {
                    IntClientId = postItemSubCategory.ClientId,
                    StrItemSubCategoryCode = postItemSubCategory.ItemSubCategoryName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrItemSubCategoryName = postItemSubCategory.ItemSubCategoryName,
                    IntBusinessUnitId = postItemSubCategory.BusinessUnitId,
                    IntItemTypeId = postItemSubCategory.ItemTypeId,
                    IntActionBy = postItemSubCategory.ActionBy,
                    IntItemCategoryId = postItemSubCategory.ItemCategoryId,
                    DteLastActionDateTime = postItemSubCategory.LastActionDateTime
                };
                await _context.TblItemSubCategory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblItemSubCategory
                                                join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                                                join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                                                join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                                                where ip.IsActive == true && ip.IntItemSubCategoryId == detalis.IntItemSubCategoryId
                                  select new GetItemSubCategoryDTO()
                                                {
                                                    Id = ip.IntItemSubCategoryId,
                                                    Code = ip.StrItemSubCategoryCode,
                                                    ItemSubCategoryName = ip.StrItemSubCategoryName,
                                                    ClientId = ip.IntClientId,
                                                    ClientName = cl.StrClientName,
                                                    BusinessUnitId = ip.IntBusinessUnitId,
                                                    BusinessUnitName = b.StrBusinessUnitName,
                                                    ItemTypeId = ip.IntItemTypeId,
                                                    ItemTypeName = ti.StrItemTypeName,
                                                    ItemCategoryId = ic.IntItemCategoryId,
                                                    ItemCategoryName = ic.StrItemCategoryName,
                                                    LastActionDateTime = ip.DteLastActionDateTime

                                                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Sub Catagory Create Successfully.",
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
        public async Task<object> EditItemSubCategory(EditItemSubCategoryDTO putItemSubCategory)
        {
            try
            {
                TblItemSubCategory data = _context.TblItemSubCategory.First(x => x.IntItemSubCategoryId == putItemSubCategory.Id);                             
                data.StrItemSubCategoryName = putItemSubCategory.ItemSubCategoryName;
                data.IntActionBy = putItemSubCategory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblItemSubCategory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemSubCategory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                              join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                              join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                              where ip.IsActive == true && ip.IntItemSubCategoryId == putItemSubCategory.Id
                              select new GetItemSubCategoryDTO()
                              {
                                  Id = ip.IntItemSubCategoryId,
                                  Code = ip.StrItemSubCategoryCode,
                                  ItemSubCategoryName = ip.StrItemSubCategoryName,
                                  ClientId = ip.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemTypeId = ip.IntItemTypeId,
                                  ItemTypeName = ti.StrItemTypeName,
                                  ItemCategoryId = ic.IntItemCategoryId,
                                  ItemCategoryName = ic.StrItemCategoryName,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Sub Catagory Edit Successfully.",
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
        public async Task<object> CancelItemSubCategory(CancelItemSubCategoryDTO ItemSubCategory)
        {
            try
            {
                TblItemSubCategory data = _context.TblItemSubCategory.First(x => x.IntItemSubCategoryId == ItemSubCategory.Id);
                
                data.IntActionBy = ItemSubCategory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblItemSubCategory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblItemSubCategory
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join ic in _context.TblItemCategory on ip.IntItemCategoryId equals ic.IntItemCategoryId
                              join ti in _context.TblItemType on ip.IntItemTypeId equals ti.IntItemTypeId
                              join cl in _context.TblClient on ip.IntClientId equals cl.IntClientId
                              where ip.IsActive == false && ip.IntItemSubCategoryId == ItemSubCategory.Id
                              select new GetItemSubCategoryDTO()
                              {
                                  Id = ip.IntItemSubCategoryId,
                                  Code = ip.StrItemSubCategoryCode,
                                  ItemSubCategoryName = ip.StrItemSubCategoryName,
                                  ClientId = ip.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = ip.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemTypeId = ip.IntItemTypeId,
                                  ItemTypeName = ti.StrItemTypeName,
                                  ItemCategoryId = ic.IntItemCategoryId,
                                  ItemCategoryName = ic.StrItemCategoryName,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Sub Catagory Cancel Successfully.",
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
