using ControlPanel.DTO.ProductDivision;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IProductDivision
    {
        Task<Message> GetProductDivisionAll();
        Task<Message> GetProductDivisionById(long Id);
        Task<Message> GetProductDivisionByUnitId(long UId);
        Task<Message> GetProductDivisionByClientId(long CId);
        Task<object> CreateProductDivision(CreateProductDivisionDTO postProductDivision);
        Task<object> EditProductDivision(EditProductDivisionDTO productDivision);
        Task<object> CancelProductDivision(CancelProductDivisionDTO productDivision);
    }
}
