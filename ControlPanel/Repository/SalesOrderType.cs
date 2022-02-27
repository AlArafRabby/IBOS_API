using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesOrderType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class SalesOrderType : ISalesOrderType
    {
        public readonly iBOSContext _context;
        public SalesOrderType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetSalesOrderTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Order Type List ",
                    data = await Task.FromResult((from so in _context.TblSalesOrderType
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitid equals b.IntBusinessUnitId
                                                  join sog in _context.TblSalesOrderGroup on so.IntSalesOrderGroupId equals sog.IntSalesOrderGroupId
                                                  where so.IsActive == true
                                                  select new GetSalesOrderTypeDTO()
                                                  {
                                                      SalesOrderTypeId = so.IntSalesOrderTypeId,
                                                      BusinessUnitid = so.IntBusinessUnitid,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrderGroupId = so.IntSalesOrderGroupId,
                                                      SalesOrderGroupName = sog.StrSalesOrderGroupName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                Message m = new Message();
                Console.WriteLine(m.data);


                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetSalesOrderTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Order Type List By Id ",
                    data = await Task.FromResult((from so in _context.TblSalesOrderType
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitid equals b.IntBusinessUnitId
                                                  join sog in _context.TblSalesOrderGroup on so.IntSalesOrderGroupId equals sog.IntSalesOrderGroupId
                                                  where so.IsActive == true && so.IntSalesOrderTypeId == Id
                                                  select new GetSalesOrderTypeDTO()
                                                  {
                                                      SalesOrderTypeId = so.IntSalesOrderTypeId,
                                                      BusinessUnitid = so.IntBusinessUnitid,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrderGroupId = so.IntSalesOrderGroupId,
                                                      SalesOrderGroupName = sog.StrSalesOrderGroupName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                Message m = new Message();
                Console.WriteLine(m.data);


                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetSalesOrderTypeByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Sales Order Type List By Unit Id ",
                    data = await Task.FromResult((from so in _context.TblSalesOrderType
                                                  join b in _context.TblBusinessUnit on so.IntBusinessUnitid equals b.IntBusinessUnitId
                                                  join sog in _context.TblSalesOrderGroup on so.IntSalesOrderGroupId equals sog.IntSalesOrderGroupId
                                                  where so.IsActive == true && so.IntBusinessUnitid == UId
                                                  select new GetSalesOrderTypeDTO()
                                                  {
                                                      SalesOrderTypeId = so.IntSalesOrderTypeId,
                                                      BusinessUnitid = so.IntBusinessUnitid,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      SalesOrderGroupId = so.IntSalesOrderGroupId,
                                                      SalesOrderGroupName = sog.StrSalesOrderGroupName,
                                                      ActionBy = so.IntActionBy,
                                                      LastActionDateTime = so.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                Message m = new Message();
                Console.WriteLine(m.data);


                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
    }
}
