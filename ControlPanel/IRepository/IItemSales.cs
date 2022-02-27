using ControlPanel.DTO.ItemSales;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IItemSales
    {
        Task<Message> GetItemSalesAll();
        Task<Message> GetItemSalesById(long Id);
        Task<Message> GetItemSalesByClientId(long CId);
        Task<Message> GetItemSalesByUnitId(long UId);
        Task<Message> CreateItemSales(CreateItemSalesDTO postItemAttribute);
        Task<Message> EditteItemSales(EditItemSalesDTO putItemAttribute);
        Task<Message> CancelteItemSales(CancelItemSalesDTO ItemAttribute);
    }
}
