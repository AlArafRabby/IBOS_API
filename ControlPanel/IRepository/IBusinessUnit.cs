using ControlPanel.DTO;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessUnit
    {
        Task<Message> GetBusinessUnitAll();
        Task<Message> GetBusinessUnitById(long Id);
        Task<Message> GetBusinessUnitByClientId(long CId);
        Task<object> CreateBusinessUnit(CreateBusinessUnitDTO postBusinessUnit);
        Task<object> EditBusinessUnit(EditBusinessUnitDTO businessUnit);
        Task<object> CancelBusinessUnit(CancelBusinessUnitDTO businessUnit);

    }
}

