using ControlPanel.DTO.AccountCategory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IAccountCategory
    {
        Task<Message> GetAccountCategoryAll();
        Task<Message> GetAccountCategoryById(long Id);
        Task<Message> GetAccountCategoryByClientId(long CId);
        Task<object> CreateAccountCategory(CreateAccountCategoryDTO postAccountCategory);
        Task<object> EditAccountCategory(EditAccountCategoryDTO AccountCategory);
        Task<object> CancelAccountCategory(CancelAccountCategoryDTO AccountCategory);

    }
}
