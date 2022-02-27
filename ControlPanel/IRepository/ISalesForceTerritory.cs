using ControlPanel.DTO.SalesForceTerritory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ISalesForceTerritory
    {
        Task<Message> GetSalesForceTerritoryAll();
        Task<Message> GetSalesForceTerritoryById(long Id);
        Task<Message> GetSalesForceTerritoryByUnitId(long UId);
        Task<Message> GetSalesForceTerritoryByClientId(long CId);
        Task<object> CreateSalesForceTerritory(CreateSalesForceTerritoryDTO postSalesForceTerritory);
        Task<object> EditSalesForceTerritory(EditSalesForceTerritoryDTO SalesForceTerritory);
        Task<object> CancelSalesForceTerritory(CancelSalesForceTerritoryDTO SalesForceTerritory);
    }
}
