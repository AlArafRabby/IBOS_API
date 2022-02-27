using ControlPanel.DTO.PurchaseOrganization;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public  interface IPurchaseOrganization
    {
        Task<Message> GetPurchaseOrganizationAll();
        Task<Message> GetPurchaseOrganizationById(long Id);
        Task<Message> GetPurchaseOrganizationByClientId(long CId);
    }
}
