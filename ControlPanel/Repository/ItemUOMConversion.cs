using ControlPanel.DbContexts;
using ControlPanel.DTO.IItemUOMConversion;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanellNew.Helper;

namespace ControlPanel.Repository
{
    public class ItemUOMConversion : IItemUOMConversion
    {
        public readonly iBOSContext _context;
        public ItemUOMConversion(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemUOMConversionAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item UOM Conversion ",

                    data = await Task.FromResult((from bp in _context.TblItemUomconversion
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where bp.IsActive == true
                                           select new GetIItemUOMConversionDTO()
                                           {
                                               Id = bp.IntConfigId,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               BaseUom = bp.IntBaseUom,
                                               ConvertedUom = bp.IntConvertedUom,
                                               ConversionRate = bp.NumConversionRate,
                                               LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetItemUOMConversionById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item UOM Conversion By Id ",
                    data = await Task.FromResult((from bp in _context.TblItemUomconversion
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where bp.IntConfigId == Id && bp.IsActive == true
                                           select new GetIItemUOMConversionDTO()
                                           {
                                               Id = bp.IntConfigId,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               BaseUom = bp.IntBaseUom,
                                               ConvertedUom = bp.IntConvertedUom,
                                               ConversionRate = bp.NumConversionRate,
                                               LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetItemUOMConversionByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item UOM Conversion By Client Id ",
                    data = await Task.FromResult((from bp in _context.TblItemUomconversion
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetIItemUOMConversionDTO()
                                                  {
                                                      Id = bp.IntConfigId,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BaseUom = bp.IntBaseUom,
                                                      ConvertedUom = bp.IntConvertedUom,
                                                      ConversionRate = bp.NumConversionRate,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> CreateItemUOMConversion(CreateIItemUOMConversionDTO postIItemUOMConversion)
        {
            try
            {
                var detalis = new TblItemUomconversion
                {
                    IntClientId = postIItemUOMConversion.ClientId,
                    IntBusinessUnitId = postIItemUOMConversion.BusinessUnitId,
                    IntItemId = postIItemUOMConversion.ItemId,
                    IntBaseUom = postIItemUOMConversion.BaseUom,
                    IntConvertedUom = postIItemUOMConversion.ConvertedUom,
                    NumConversionRate = postIItemUOMConversion.ConversionRate,
                    IntActionBy = postIItemUOMConversion.ActionBy,
                    DteLastActionDateTime = postIItemUOMConversion.LastActionDateTime
                };
                await _context.TblItemUomconversion.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblItemUomconversion
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IntConfigId == detalis.IntConfigId && bp.IsActive == true
                              select new GetIItemUOMConversionDTO()
                              {
                                  Id = bp.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BaseUom = bp.IntBaseUom,
                                  ConvertedUom = bp.IntConvertedUom,
                                  ConversionRate = bp.NumConversionRate,
                                  LastActionDateTime = bp.DteLastActionDateTime
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
        public async Task<Message> EditItemUOMConversion(EidtIItemUOMConversionDTO putIItemUOMConversion)
        {
            try
            {
                TblItemUomconversion data = _context.TblItemUomconversion.First(x => x.IntConfigId == putIItemUOMConversion.Id);
                data.IntItemId = putIItemUOMConversion.ItemId;
                data.IntBaseUom = putIItemUOMConversion.BaseUom;
                data.IntConvertedUom = putIItemUOMConversion.ConvertedUom;
                data.NumConversionRate = putIItemUOMConversion.ConversionRate;
                data.IntActionBy = putIItemUOMConversion.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblItemUomconversion.Update(data);
                await _context.SaveChangesAsync();
                
                var Details = from bp in _context.TblItemUomconversion
                       join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                       where bp.IntConfigId == putIItemUOMConversion.Id && bp.IsActive == true
                       select new GetIItemUOMConversionDTO()
                       {
                           Id = bp.IntConfigId,
                           BusinessUnitId = b.IntBusinessUnitId,
                           BusinessUnitName = b.StrBusinessUnitName,
                           BaseUom = bp.IntBaseUom,
                           ConvertedUom = bp.IntConvertedUom,
                           ConversionRate = bp.NumConversionRate,
                           LastActionDateTime = bp.DteLastActionDateTime
                       };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item UOM Conversioin Edit Successfully.",
                    data = Details
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
        public async Task<Message> CancelItemUOMConversion(CancelIItemUOMConversionDTO putIItemUOMConversion)
        {
            try
            {
                TblItemUomconversion data = _context.TblItemUomconversion.First(x => x.IntConfigId == putIItemUOMConversion.Id);
                data.IntActionBy = putIItemUOMConversion.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemUomconversion.Update(data);
                await _context.SaveChangesAsync();
                var Details = from bp in _context.TblItemUomconversion
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IntConfigId == putIItemUOMConversion.Id && bp.IsActive == false
                              select new GetIItemUOMConversionDTO()
                              {
                                  Id = bp.IntConfigId,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BaseUom = bp.IntBaseUom,
                                  ConvertedUom = bp.IntConvertedUom,
                                  ConversionRate = bp.NumConversionRate,
                                  LastActionDateTime = bp.DteLastActionDateTime
                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item UOM Conversioin Cancel Successfully.",
                    data = Details
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
