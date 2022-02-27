using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemAttributeConfig;
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
    public class ItemAttributeConfig : IItemAttributeConfig
    {
        public readonly iBOSContext _context;

        public ItemAttributeConfig(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemAttributeConfigAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All ItemAttribute Config ",
                    data = await Task.FromResult((from ia in _context.TblItemAttributeConfig
                                                  join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                                                  join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                                                  where ia.IsActive == true
                                                  select new GetItemAttributeConfigDTO()
                                                  {
                                                      ConfigId = ia.IntConfigId,
                                                      ClientId = ia.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemMasterId = i.IntItemMasterId,
                                                      ItemMastername = i.StrItemMasterName,
                                                      AttributeId = ia.IntAttributeId,
                                                      AttributeName = ia.StrAttributeName,
                                                      AttributeUom = ia.StrAttributeUom,
                                                      ActionBy = ia.IntActionBy,
                                                      LastActionDateTime = ia.DteLastActionDateTime

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
        public async Task<Message> GetItemAttributeConfigById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "ItemAttribute Config by Id ",
                    data = await Task.FromResult((from ia in _context.TblItemAttributeConfig
                                                  join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                                                  join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                                                  where ia.IsActive == true && ia.IntConfigId == Id
                                                  select new GetItemAttributeConfigDTO()
                                                  {
                                                      ConfigId = ia.IntConfigId,
                                                      ClientId = ia.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemMasterId = i.IntItemMasterId,
                                                      ItemMastername = i.StrItemMasterName,
                                                      AttributeId = ia.IntAttributeId,
                                                      AttributeName = ia.StrAttributeName,
                                                      AttributeUom = ia.StrAttributeUom,
                                                      ActionBy = ia.IntActionBy,
                                                      LastActionDateTime = ia.DteLastActionDateTime

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
        public async Task<Message> GetItemAttributeConfigByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "ItemAttribute config Business unit  Id ",
                    data = await Task.FromResult((from ia in _context.TblItemAttributeConfig
                                                  join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                                                  join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                                                  where ia.IsActive == true && ia.IntBusinessUnitId == UId
                                                  select new GetItemAttributeConfigDTO()
                                                  {
                                                      ConfigId = ia.IntConfigId,
                                                      ClientId = ia.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemMasterId = i.IntItemMasterId,
                                                      ItemMastername = i.StrItemMasterName,
                                                      AttributeId = ia.IntAttributeId,
                                                      AttributeName = ia.StrAttributeName,
                                                      AttributeUom = ia.StrAttributeUom,
                                                      ActionBy = ia.IntActionBy,
                                                      LastActionDateTime = ia.DteLastActionDateTime

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
        public async Task<Message> GetItemAttributeConfigByClient(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "ItemAttribute Config by Client Id ",
                    data = await Task.FromResult((from ia in _context.TblItemAttributeConfig
                                                  join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                                                  join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                                                  where ia.IsActive == true && ia.IntClientId == CId
                                                  select new GetItemAttributeConfigDTO()
                                                  {
                                                      ConfigId = ia.IntConfigId,
                                                      ClientId = ia.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemMasterId = i.IntItemMasterId,
                                                      ItemMastername = i.StrItemMasterName,
                                                      AttributeId = ia.IntAttributeId,
                                                      AttributeName = ia.StrAttributeName,
                                                      AttributeUom = ia.StrAttributeUom,
                                                      ActionBy = ia.IntActionBy,
                                                      LastActionDateTime = ia.DteLastActionDateTime

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
        public async Task<Message> CreateItemAttributeConfig(CreateItemAttributeConfigDTO postItemAttributeConfig)
        {
            try
            {
                var detalis = new TblItemAttributeConfig
                {
                    IntClientId= postItemAttributeConfig.ClientId,
                    IntBusinessUnitId = postItemAttributeConfig.BusinessUnitId,
                    IntItemMasterId = postItemAttributeConfig.ItemMasterId,
                    IntAttributeId = postItemAttributeConfig.AttributeId,
                    StrAttributeName = postItemAttributeConfig.AttributeName,
                    StrAttributeUom = postItemAttributeConfig.AttributeUom,
                    DteLastActionDateTime = DateTime.UtcNow,
                    DteServerDateTime = DateTime.UtcNow,
                    IntActionBy = postItemAttributeConfig.ActionBy
                };
                await _context.TblItemAttributeConfig.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ia in _context.TblItemAttributeConfig
                                  join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                                  join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                                  where ia.IsActive == true && ia.IntConfigId == detalis.IntConfigId
                                  select new GetItemAttributeConfigDTO()
                                  {
                                      ConfigId = ia.IntConfigId,
                                      ClientId = ia.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      ItemMasterId = i.IntItemMasterId,
                                      ItemMastername = i.StrItemMasterName,
                                      AttributeId = ia.IntAttributeId,
                                      AttributeName = ia.StrAttributeName,
                                      AttributeUom = ia.StrAttributeUom,
                                      ActionBy = ia.IntActionBy,
                                      LastActionDateTime = ia.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute Config Create Successfully.",
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
        public async Task<Message> EditItemAttributeConfig(EditItemAttributeConfigDTO putItemAttributeConfig)
        {
            try
            {
                TblItemAttributeConfig data = _context.TblItemAttributeConfig.First(x => x.IntConfigId == putItemAttributeConfig.ConfigId);

                data.IntConfigId = putItemAttributeConfig.ConfigId;
                data.IntBusinessUnitId = putItemAttributeConfig.BusinessUnitId;
                data.IntItemMasterId = putItemAttributeConfig.ItemMasterId;
                data.IntAttributeId = putItemAttributeConfig.AttributeId;
                data.StrAttributeName = putItemAttributeConfig.AttributeName;
                data.StrAttributeUom = putItemAttributeConfig.AttributeUom;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putItemAttributeConfig.ActionBy;

                _context.TblItemAttributeConfig.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ia in _context.TblItemAttributeConfig
                              join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                              join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                              join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                              where ia.IsActive == true && ia.IntConfigId == putItemAttributeConfig.ConfigId
                              select new GetItemAttributeConfigDTO()
                              {
                                  ConfigId = ia.IntConfigId,
                                  ClientId = ia.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemMasterId = i.IntItemMasterId,
                                  ItemMastername = i.StrItemMasterName,
                                  AttributeId = ia.IntAttributeId,
                                  AttributeName = ia.StrAttributeName,
                                  AttributeUom = ia.StrAttributeUom,
                                  ActionBy = ia.IntActionBy,
                                  LastActionDateTime = ia.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute config Edit Successfully.",
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
        public async Task<Message> CancelItemAttributeConfig(CancelItemAttributeConfigDTO putItemAttributeConfig)
        {
            try
            {
                TblItemAttributeConfig data = _context.TblItemAttributeConfig.First(x => x.IntConfigId == putItemAttributeConfig.ConfigId);
                data.IntActionBy = putItemAttributeConfig.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemAttributeConfig.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ia in _context.TblItemAttributeConfig
                              join b in _context.TblBusinessUnit on ia.IntBusinessUnitId equals b.IntBusinessUnitId
                              join i in _context.TblItemMaster on ia.IntItemMasterId equals i.IntItemMasterId
                              join c in _context.TblClient on ia.IntClientId equals c.IntClientId
                              where ia.IsActive == false && ia.IntConfigId == putItemAttributeConfig.ConfigId
                              select new GetItemAttributeConfigDTO()
                              {
                                  ConfigId = ia.IntConfigId,
                                  ClientId = ia.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemMasterId = i.IntItemMasterId,
                                  ItemMastername = i.StrItemMasterName,
                                  AttributeId = ia.IntAttributeId,
                                  AttributeName = ia.StrAttributeName,
                                  AttributeUom = ia.StrAttributeUom,
                                  ActionBy = ia.IntActionBy,
                                  LastActionDateTime = ia.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute Config Cancel Successfully.",
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
