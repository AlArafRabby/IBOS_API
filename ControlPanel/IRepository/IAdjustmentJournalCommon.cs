using ControlPanel.DTO.AdjustmentJournalCommon;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IAdjustmentJournalCommon
    {
        Task<Message> GetAdjustmentJournalHeaderbyClientId(long ClientId, bool iscomplete);
        Task<Message> GetAdjustmentJournalHeaderbyBusinessUnitId(long UnitId, bool iscomplete);
        Task<Message> GetAdjustmentJournalHeaderByAreaId(long AreaId, bool iscomplete);
        Task<Message> GetAdjustmentJournalHeaderbyVoucherId(long VoucherId);
        Task<object> CreateAdjustmentJournalVoucher(CreateAdjustmentJournalCommonDTO postAdjustmentJournalCommonDTO);
        Task<object> EditAdjustmentJournalVoucher(EditAdjustmentJournalCommonDTO putAdjustmentJournalCommon);
        Task<object> CompleteAdjustmentJournalVoucher(EditAdjustmentJournalCommonDTO putAdjustmentJournalCommon);
        Task<object> CancelAdjustmentJournalVoucher(CancelAdjustmentJournalHeaderDTO putAdjustmentJournalHeader);
        Task<Message> GetAdjustmentJournalRowDetailsById(long VoucherId);
    }
}
