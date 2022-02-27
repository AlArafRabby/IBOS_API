using ControlPanel.DTO.BankInstrumentType;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBankInstrumentType
    {
        Task<Message> GetBankInstrumentTypeAll();
        Task<Message> GetBankInstrumentTypeById(long Id);
        Task<object> CreateBankInstrumentType(CreateBankInstrumentTypeDTO postBankInstrumentType);
        Task<object> EditBankInstrumentType(EditBankInstrumentTypeDTO BankInstrumentType);
        Task<object> CancelBankInstrumentType(CancelBankInstrumentTypeDTO BankInstrumentType);
    }
}
