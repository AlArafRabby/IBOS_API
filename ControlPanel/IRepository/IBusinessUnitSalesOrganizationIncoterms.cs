using ControlPanel.DTO.BusinessUnitSalesOrganizationIncoterms;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBusinessUnitSalesOrganizationIncoterms
    {
        Task<Message> GetBusinessUnitSalesOrganizationIncotermsAll();
        Task<Message> GetBusinessUnitSalesOrganizationIncotermsById(long Id);
        Task<Message> GetBusinessUnitSalesOrganizationIncotermsByUnitId(long UId);
        Task<Message> GetBusinessUnitSalesOrganizationIncotermsByClientId(long CId);
        Task<object> CreateBusinessUnitSalesOrganizationIncoterms(CreateBusinessUnitSalesOrganizationIncotermsDTO postBusinessUnitSalesOrganizationIncoterms);
        Task<object> EditBusinessUnitSalesOrganizationIncoterms(EditBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms);
        Task<object> CancelBusinessUnitSalesOrganizationIncoterms(CancelBusinessUnitSalesOrganizationIncotermsDTO BusinessUnitSalesOrganizationIncoterms);
    }
}
