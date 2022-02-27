using ControlPanel.DTO.BusinessPartnerGeneralLedger;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ControlPanel.IRepository
{
    public  interface IBusinessPartnerGeneralLedger
    {
        Task<Message> GetBusinessPartnerGeneralLedgerAll();
        Task<Message> GetBusinessPartnerGeneralLedgerById(long Id);
        Task<Message> GetBusinessPartnerGeneralLedgerByUnitId(long UId);
        Task<Message> GetBusinessPartnerGeneralLedgerByClientId(long CId);
        Task<object> CreateBusinessPartnerGeneralLedger(CreateBusinessPartnerGeneralLedgerDTO postBusinessPartnerGeneralLedger);
        Task<object> EditBusinessPartnerGeneralLedger(EditBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger);
        Task<object> CancelBusinessPartnerGeneralLedger(CancelBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger);
    }
}
