using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemSubCategory;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemSubCategory
    {
        Task<Message> GetItemSubCategoryAll();
        Task<Message> GetItemSubCategoryById(long Id);
        Task<Message> GetItemSubCategoryByClientId(long CId);
        Task<object> CreateItemSubCategory(CreateItemSubCategoryDTO postItemSubCategory);
        Task<object> EditItemSubCategory(EditItemSubCategoryDTO putItemSubCategory);
        Task<object> CancelItemSubCategory(CancelItemSubCategoryDTO ItemSubCategory);
    }
}
