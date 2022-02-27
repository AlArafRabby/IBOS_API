using ControlPanel.DTO.Bank;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBank
    {
        Task<Message> GetBankAll();
        Task<Message> GetBankById(long Id);
        Task<object> CreateBank(CreateBankDTO postBank);
        Task<object> EditBank(EditBankDTO Bank);
        Task<object> CancelBank(CancelBankDTO Bank);
    }
}
