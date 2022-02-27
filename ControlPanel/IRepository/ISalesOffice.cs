using ControlPanel.DTO.SalesOffice;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface ISalesOffice
    {
        Task<Message> GetSalesOfficeAll();
        Task<Message> GetSalesOfficeById(long Id);
        Task<Message> GetSalesOfficeByUnitId(long UId);
        Task<Message> GetSalesOfficeByClientId(long CId);
        Task<object> CreateSalesOffice(CreateSalesOfficeDTO postSalesOffice);
        Task<object> EditSalesOffice(EditSalesOfficeDTO SalesOffice);
        Task<object> CancelSalesOffice(CancelSalesOfficeDTO SalesOffice);
    }
}
