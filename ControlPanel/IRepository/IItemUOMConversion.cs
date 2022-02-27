using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.IItemUOMConversion;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemUOMConversion
    {
        Task<Message> GetItemUOMConversionAll();
        Task<Message> GetItemUOMConversionById(long Id);
        Task<Message> GetItemUOMConversionByClientId(long CId);
        Task<Message> CreateItemUOMConversion(CreateIItemUOMConversionDTO postIItemUOMConversion);
        Task<Message> EditItemUOMConversion(EidtIItemUOMConversionDTO putIItemUOMConversion);
        Task<Message> CancelItemUOMConversion(CancelIItemUOMConversionDTO putIItemUOMConversion);

    }
}
