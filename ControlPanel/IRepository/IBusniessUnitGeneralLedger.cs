using ControlPanellNew.Helper;
using ControlPanel.DTO.BusniessUnitGeneralLedger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBusniessUnitGeneralLedger
    {
        Task<Message> GetBusniessUnitGeneralLedgerAll();
        Task<Message> GetBusniessUnitGeneralLedgerById(long Id);
        Task<Message> GetBusniessUnitGeneralLedgerByUnitId(long UId);
        Task<Message> GetBusniessUnitGeneralLedgerByClientId(long CId);
        Task<object> CreateBusniessUnitGeneralLedger(CreateBusniessUnitGeneralLedgerDTO postBusniessUnitGeneralLedger);
        Task<object> EditBusniessUnitGeneralLedger(EditBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger);
        Task<object> CancelBusniessUnitGeneralLedger(CancelBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger);
    }
}
