using ControlPanel.DTO.BusinessPartnerLedger;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerLedger
    {
        Task<Message> GetBusinessPartnerLedgerById(long Id);
        Task<Message> GetBusinessPartnerLedgerByClientId(long CId);
        Task<Message> GetBusinessPartnerLedgerByUnitId(long UId);
        Task<object> CreateBusinessPartnerLedger(CreateBusinessPartnerLedgerDTO postBusinessPartnerLedger);
        Task<object> EditBusinessPartnerLedger(EditBusinessPartnerLedgerDTO BusinessPartnerLedger);
        Task<object> CancelBusinessPartnerLedger(CancelBusinessPartnerLedgerDTO BusinessPartnerLedger);
    }
}
