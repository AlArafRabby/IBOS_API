using ControlPanel.DTO.ItemAttributeConfig;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IItemAttributeConfig
    {
        Task<Message> GetItemAttributeConfigAll();
        Task<Message> GetItemAttributeConfigById(long Id);
        Task<Message> GetItemAttributeConfigByClient(long CId);
        Task<Message> GetItemAttributeConfigByUnitId(long UId);
        Task<Message> CreateItemAttributeConfig(CreateItemAttributeConfigDTO postItemAttributeConfig);
        Task<Message> EditItemAttributeConfig(EditItemAttributeConfigDTO putItemAttributeConfig);
        Task<Message> CancelItemAttributeConfig(CancelItemAttributeConfigDTO putItemAttributeConfig);
    }
}
