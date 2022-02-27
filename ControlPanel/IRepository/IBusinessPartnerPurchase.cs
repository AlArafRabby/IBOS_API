using ControlPanel.DTO.BusinessPartnerWarehousePurchase;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerPurchase
    {
        Task<Message> GetBusinessPartnerPurchaseAll();
        Task<Message> GetBusinessPartnerPurchaseById(long Id);
        Task<Message> GetBusinessPartnerPurchaseByClientId(long CId);
        Task<Message> LedgerBalanceUpdateDuringPartnerRecive(long pId, decimal amount);
        Task<Message> UnbilledAmountUpdateDuringSalesOrder(long pId, decimal SOamount);
        Task<Message> UnbilledAmountUpdateDuringPartnerBilling(long pId, decimal Billamount);
        Task<Message> CreditLimitUpdateDuringPartnerCreaditLimit(long pId, decimal Limitamount);
        Task<Message> GetAvailableBalance(long pId);
        Task<object> CreateBusinessPartnerPurchase(CreateBusinessPartnerPurchaseDTO postBusinessPartnerPurchase);
        Task<object> EditBusinessPartnerPurchase(EditBusinessPartnerPurchaseDTO putBusinessPartnerPurchase);
        Task<object> CancelBusinessPartnerPurchase(CancelBusinessPartnerPurchaseDTO putBusinessPartnerPurchase);
    }
}
