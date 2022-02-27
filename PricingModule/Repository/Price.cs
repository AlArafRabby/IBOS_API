using PricingModule.DbContexts;
using PricingModule.DTO;
using PricingModule.DTO.Price;
using PricingModule.Models.iBOS;
using PricingModule.Helper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using PricingModule.IRepository;

namespace PricingModule.Repository
{
    public class Price : IPrice
    {
        public readonly iBOSContext _context;
        public decimal getPrice { get; set; }
        public long getPriceConditionId { get; set; }
        
        public Price(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> GetPrices(long BusinessId, long intPartner, long intItemId, DateTime dtePricingDate, long intTerr, long ChannelId, long sorgid)
        {
            
            await GetPartnerWisePrice(intPartner, intItemId, dtePricingDate);

            if (getPrice == 0)
            {
                await GetTerritoryWisePrice(BusinessId, intItemId, dtePricingDate, intTerr);
            }
            else if (getPrice == 0)
            {
                await GetChannelWisePrice(intItemId, dtePricingDate, ChannelId);
            }
            else if (getPrice == 0)
            {
                await GetSalesOrganizationWisePrice(intItemId, dtePricingDate, sorgid);
            }
            
            return new Message
            {
                status = true,
                message = "Item Price.",
                data = new PriceReturnDTO
                {
                    itemPrice = getPrice,
                    priceConditionId = getPriceConditionId
                }
            };
        }

        private async Task<object> GetPartnerWisePrice(long intPartner, long intItemId, DateTime dtePricingDate)
        {
            var data = await Task.FromResult(_context.TblPriceSetup.Where(x => x.IntConditionTypeId == 4 && x.IntConditionReffId == intPartner && x.IntItemId == intItemId && x.DteStartDate <= dtePricingDate
                && dtePricingDate <= (x.DteEndDate ?? dtePricingDate) && x.IsActive == true));

            foreach (var obj in data)
            {
                getPrice = obj.NumPrice;
                getPriceConditionId = obj.IntPriceConditionId;                
            }
            return data;
        }

        private async Task<object> GetTerritoryWisePrice(long BusinessId, long intItemId, DateTime dtePricingDate, long intTerr)
        {
            var data = await Task.FromResult(_context.TblPriceSetup.Where(x => x.IntBusinessUnitId == BusinessId && x.IntConditionTypeId == 3 && x.IntConditionReffId == intTerr && x.IntItemId == intItemId
            && x.DteStartDate <= dtePricingDate && (dtePricingDate <= (x.DteEndDate ?? dtePricingDate)) && x.IsActive == true));

            foreach (var obj in data)
            {
                getPrice = obj.NumPrice;
                getPriceConditionId = obj.IntPriceConditionId;
            }
                
            if (getPrice == 0)
            {
                data = null;
                while (getPrice == 0 && intTerr > 0)
                {
                    data = _context.TblPriceSetup.Where(x => x.IntBusinessUnitId == BusinessId && x.IntConditionTypeId == 3 && x.IntConditionReffId == intTerr && x.IntItemId == intItemId
                    && x.DteStartDate <= dtePricingDate && (dtePricingDate <= (x.DteEndDate ?? dtePricingDate)) && x.IsActive == true);

                    foreach (var obj in data)
                    {
                        getPrice = obj.NumPrice;
                        getPriceConditionId = obj.IntPriceConditionId;
                    }

                    var objTerrtoryId = _context.TblTerritory.Where(x => x.IntTerritoryId == intTerr);
                    foreach (var objT in objTerrtoryId)
                    {
                        intTerr = objT.IntParentTerritoryId;
                    }
                }
            }
            return data;            
        }

        private async Task<object> GetChannelWisePrice(long intItemId, DateTime dtePricingDate, long ChannelId)
        {
            var data = await Task.FromResult(_context.TblPriceSetup.Where(x => x.IntConditionTypeId == 2 && x.IntConditionReffId == ChannelId && x.IntItemId == intItemId
            && x.DteStartDate <= dtePricingDate && (dtePricingDate <= (x.DteEndDate ?? dtePricingDate)) && x.IsActive == true));

            PriceSet(data);
            return data;
        }

        private async Task<object> GetSalesOrganizationWisePrice(long intItemId, DateTime dtePricingDate, long sorgid)
        {
            var data = await Task.FromResult(_context.TblPriceSetup.Where(x => x.IntConditionTypeId == 1 && x.IntConditionReffId == sorgid && x.IntItemId == intItemId
            && x.DteStartDate <= dtePricingDate && (dtePricingDate <= (x.DteEndDate ?? dtePricingDate)) && x.IsActive == true));
                        
            PriceSet(data);
            return data;
        }
        private async Task<object> CheckPriceCondition(long intItemId, DateTime dtePricingDate, long sorgid)
        {
            var data = await Task.FromResult(_context.TblPriceSetup.Where(x => x.IntConditionTypeId == 1 && x.IntConditionReffId == sorgid && x.IntItemId == intItemId
            && x.DteStartDate <= dtePricingDate && (dtePricingDate <= (x.DteEndDate ?? dtePricingDate)) && x.IsActive == true));

            PriceSet(data);
            return data;
        }
        private void PriceSet(IQueryable<TblPriceSetup> data)
        {
            foreach (var obj in data)
            {
                getPrice = obj.NumPrice;
                getPriceConditionId = obj.IntPriceConditionId;
            };
        }

       
    }
}
