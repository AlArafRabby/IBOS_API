using ControlPanel.DTO.BankJournalHeader;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBankJournalHeader
    {
        Task<Message> BankJournalbyClientId(long ClientId);
        Task<Message> BankJournalbyBusinessUnitId(long UnitId, bool isPosted);
        Task<Message> BankJournalbyBusinessAreaId(long AreaId);
        Task<Message> BankJournalbyVoucherId(long VoucherId);
        Task<object> CreateBankJournalVoucher(CreateBankJournalHeaderCommonDTO postBankJournalHeaderCommon);
        Task<object> EditBankJournalVoucher(EditBankJournalHeaderCommonDTO BankJournalHeaderCommon);
        Task<object> CompleteBankJournalVoucher(EditBankJournalHeaderDTO BankJournalHeader);
        Task<object> CancelBankJournalVoucher(CancelBankJournalHeaderDTO BankJournalHeader);
    }
}
