using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemMaster;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemMaster
    {
        Task<Message> GetItemMasteryAll();
        Task<Message> GetItemMasterById(long Id);
        Task<Message> GetItemMasterByClientId(long CId);
        Task<object> CreateItemMaster(CreateItemMasterDTO postItemMaster);
        Task<object> EditItemMaster(EditItemMasterDTO putIItemMaster);
        Task<object> CancelItemMaster(CancelItemMasterDTO ItemItemMaster);
    }
}
