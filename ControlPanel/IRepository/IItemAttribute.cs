using ControlPanel.DTO;
using ControlPanel.DTO.ItemAttribute;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IItemAttribute
    {
        Task<Message> GetItemAttributeAll();
        Task<Message> GetItemAttributeById(long Id);
        Task<Message> GetItemAttributeByClientId(long CId);
        Task<Message> GetItemAttributeByUnitId(long UId);
        Task<object> CreateItemAttribute(CreateItemAttributeDTO postItemAttribute);
        Task<object> EditItemAttribute(EditItemAttributeDTO putItemAttribute);
        Task<Message> CancelItemAttribute(CancelItemAttributeDTO ItemAttribute);
    }
}
