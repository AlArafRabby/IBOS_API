using ControlPanel.DTO.AlternativeAndStandardReconGeneralLedger;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IAlternativeAndStandardReconGeneralLedger
    {
        Task<Message> GetAlternativeAndStandardReconGeneralLedgerAll();
        Task<Message> GetAlternativeAndStandardReconGeneralLedgerById(long Id);
        Task<Message> GetAlternativeAndStandardReconGeneralLedgerByClientId(long CId);
        Task<Message> GetAlternativeAndStandardReconGeneralLedgerByUnitId(long UId);
        Task<object> CreateAlternativeAndStandardReconGeneralLedger(CreateAlternativeAndStandardReconGeneralLedgerDTO postAlternativeAndStandardReconGeneralLedger);
        Task<object> EditAlternativeAndStandardReconGeneralLedger(EditAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger);
        Task<object> CancelAlternativeAndStandardReconGeneralLedger(CancelAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger);
    }
}
