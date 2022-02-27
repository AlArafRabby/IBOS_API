using ControlPanel.DTO.SalesOrganization;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ISalesOrganization
    {
        Task<Message> GetSalesOrganizationAll();
        Task<Message> GetSalesOrganizationById(long Id);
        Task<Message> GetSalesOrganizationByUnitId(long UId);
        Task<Message> GetSalesOrganizationByClientId(long CId);
        Task<object> CreateSalesOrganization(CreateSalesOrganizationDTO postSalesOrganization);
        Task<object> EditSalesOrganization(EditSalesOrganizationDTO salesOrganization);
        Task<object> CancelSalesOrganization(CancelSalesOrganizationDTO salesOrganization);
    }
}
