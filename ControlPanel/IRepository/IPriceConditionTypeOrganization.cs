using ControlPanel.DTO.PriceConditionTypeOrganization;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IPriceConditionTypeOrganization
    {
        Task<Message> GetPriceConditionTypeOrganizationAll();
        Task<Message> GetPriceConditionTypeOrganizationById(long Id);
    }
}
