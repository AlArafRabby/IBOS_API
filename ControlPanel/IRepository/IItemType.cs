using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemType;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemType
    {
        Task<Message> GetItemTypeAll();
        Task<Message> GetItemTypeById(long Id);
        Task<Message> GetItemTypeByClientId(long CId);
        Task<Message> GetItemTypeByBusinessUnitid(long Businessid);
        Task<Message> CreateItemType(CreateItemTypeDTO postItemType);
        Task<Message> EditItemType(EditItemTypeDTO putItemType);
        Task<Message> CancelItemType(CancelItemTypeDTO putItemType);
    }
}
