using ControlPanel.DTO;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControlPanel.IRepository
{
    public interface IItem
    {
        Task<Message> GetIItemAll();
        Task<Message> GetIItemById(long Id);
        Task<Message> GetIItemByClientId(long CId);
        Task<Message> GetIItemByUnitId(long UId);
        Task<object> CreateIItem(CreateItemDTO postIItem);
        Task<object> EditIItem(EditItemDTO IItem);
        Task<object> CancelIItem(CancelItemDTO Item);
    }
}
