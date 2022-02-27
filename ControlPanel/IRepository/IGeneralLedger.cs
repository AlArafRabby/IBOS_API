using ControlPanel.DTO.GeneralLedger;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IGeneralLedger
    {
        Task<Message> GetGeneralLedgerAll();
        Task<Message> GetGeneralLedgerById(long Id);
        Task<Message> GetGeneralLedgerByClientId(long CId);
        Task<object> CreateGeneralLedger(CreateGeneralLedgerDTO postGeneralLedger);
        Task<object> EditGeneralLedger(EditGeneralLedgerDTO generalledger);
        Task<object> CancelGeneralLedger(CancelGeneralLedgerDTO generalledger);
    }
}
