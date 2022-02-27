using ControlPanel.DTO.BusinessPartnerWarehouseSales;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerSales
    {
        Task<Message> GetBusinessPartnerSalesAll();
        Task<Message> GetBusinessPartnerSalesById(long Id);
        Task<Message> GetBusinessPartnerSalesByClientId(long CId);
        Task<Message> LedgerBalanceUpdateDuringPartnerRecive(long pId, decimal amount);
        Task<Message> UnbilledAmountUpdateDuringSalesOrder(long pId, decimal SOamount);
        Task<Message> UnbilledAmountUpdateDuringPartnerBilling(long pId, decimal Billamount);
        Task<Message> CreditLimitUpdateDuringPartnerCreaditLimit(long pId, decimal Limitamount);
        Task<Message> GetAvailableBalance(long pId);
        Task<object> CreateBusinessPartnerSales(CreateBusinessPartnerSalesDTO postBusinessPartnerSales);
        Task<object> EditBusinessPartnerSales(EditBusinessPartnerSalesDTO putBusinessPartnerSales);
        Task<object> CancelBusinessPartnerSales(CancelBusinessPartnerSalesDTO putBusinessPartnerSales);

    }
}
