using ControlPanel.DTO.ItemCategory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IItemCategory
    {
        Task<Message> GetItemCategoryAll();
        Task<Message> GetItemCategoryById(long Id);
        Task<Message> GetItemCategoryByClientId(long CId);
        Task<Message> GetItemCategoryByUnitId(long UId);
        Task<Message> CreateItemCategory(CreateItemCategoryDTO postItemAttribute);
        Task<Message> EditItemCategory(EditItemCategoryDTO putItemAttribute);
        Task<Message> CancelItemCategory(CancelItemCategoryDTO ItemAttribute);
    }
}
