using ControlPanel.DTO.AccountReceivablePayableCommon;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IAccountReceivablePayableCommon
    {
        Task<Message> GetAccountReceivablePayableHeaderById(long ReceivablePayableId, bool iscomplete);
        Task<Message> GetAccountReceivablePayableHeaderClientIdBusinessUnitId(long ClientId, long BusinessUnitId, bool iscomplete);
        Task<Message> GetAccountReceivablePayableHeaderClientBusinessUnitArea(long ClientId, long BusinessUnitId, long BusinessAreaId, bool iscomplete);
        Task<Message> GetAccountReceivablePayableHeaderClientBusinessUnitPartner(long ClientId, long BusinessUnitId, long BusinessPartnerId, bool iscomplete);
        Task<object> CreateAccountReceivablePayableCommon(CreateAccountReceivablePayableCommonDTO postAccountReceivablePayableCommon);
        Task<object> EditAccountReceivablePayableCommon(EditAccountReceivablePayableCommonDTO putAccountReceivablePayableCommon);
        Task<object> CompleteAccountReceivablePayableCommon(EditAccountReceivablePayableCommonDTO putAccountReceivablePayableCommon);
        Task<object> CancelAccountReceivablePayableCommon(CancelAccountReceivablePayableHeaderDTO putAccountReceivablePayableCommon);
        Task<Message> GetAccountReceivableRowById(long receivablePayableId);
        Task<Message> GetAccountPayableRowById(long receivablePayableId);
    }
}
