using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemPurchase;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemPurchase
    {
        Task<Message> getItemPurchaseAll();
        Task<Message> getItemPurchasebyId(long Id);
        Task<Message> getItemPurchasebyClientId(long CId);
        Task<Message> getItemPurchasebybusinsessunit(long businsessunitId);
        Task<object> CreateItemPurchase(CreateItemPurchaseDTO postItemPurchase);
        Task<object> EditItemPurchase(EidtItemPurchaseDTO putItemPurchase);
        Task<object> CancelItemPurchase(CancelItemPurchaseDTO putItemPurchase);
    }
}
