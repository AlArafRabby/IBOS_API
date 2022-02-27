using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountReceivablePayableCommon;
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
    public class AccountReceivablePayableCommon : IAccountReceivablePayableCommon
    {
        public readonly iBOSContext _context;
        public AccountReceivablePayableCommon(iBOSContext context)
        {
            _context = context;
        }

        public async Task<object> CancelAccountReceivablePayableCommon(CancelAccountReceivablePayableHeaderDTO putAccountReceivablePayableHeader)
        {
            try
            {
                TblAccountReceivablePayableHeader data = _context.TblAccountReceivablePayableHeader.First(x => x.IntAdjustmentJournalId == putAccountReceivablePayableHeader.AccountReceivablePayableId && x.IsActive == true);

                data.IntActionBy = putAccountReceivablePayableHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblAccountReceivablePayableHeader.Update(data);
                await _context.SaveChangesAsync();

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Receivable Payable Canceled Successfully.",
                    data = putAccountReceivablePayableHeader
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> CompleteAccountReceivablePayableCommon(EditAccountReceivablePayableCommonDTO putAccountReceivablePayableCommon)
        {
            try
            {
                TblAccountReceivablePayableHeader dataParent = _context.TblAccountReceivablePayableHeader.First(x => x.IntAccountReceivablePayableId == putAccountReceivablePayableCommon.AccountReceivablePayableHeader.AccountReceivablePayableId 
                && x.IsCleared == false && x.IsActive == true);

                dataParent.IsCleared = true;
                dataParent.IntActionBy = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.ActionBy;
                dataParent.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblAccountReceivablePayableHeader.Update(dataParent);
                await _context.SaveChangesAsync();

                var successmsg = new
                {
                    status = true,
                    message = "Edited Successfully.",
                    data = dataParent
                };
                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> CreateAccountReceivablePayableCommon(CreateAccountReceivablePayableCommonDTO postAccountReceivablePayableCommon)
        {
            try
            {
                var detalis = new TblAccountReceivablePayableHeader
                {
                    IntClientId = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.ClientId,
                    IntBusinessUnitId = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessUnitId,
                    IntBusinessAreaId = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessAreaId,
                    IntBusinessPartnerId = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessPartnerId,
                    StrInvoiceCode = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.InvoiceCode,
                    IntAdjustmentJournalId = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.AdjustmentJournalId,
                    StrAdjustmentJournalCode = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.AdjustmentJournalCode,
                    NumAmount = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.Amount,
                    StrNarration = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.Narration,
                    IsReceivable = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsReceivable,
                    IntPayTerm = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.PayTerm,
                    DteTransactionDate = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.TransactionDate,
                    DteDueDate = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.DueDate,
                    IsCleared = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsCleared,
                    DteClearingDate = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.ClearingDate,
                    IntActionBy = postAccountReceivablePayableCommon.AccountReceivablePayableHeader.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblAccountReceivablePayableHeader.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var payableRows = new List<TblAccountPayableRow>(postAccountReceivablePayableCommon.AccountPayableRowList.Count);
                foreach (var datas in postAccountReceivablePayableCommon.AccountPayableRowList)
                {
                    var detalisrow = new TblAccountPayableRow { };
                    detalisrow.IntAccountReceivablePayableId = detalis.IntAccountReceivablePayableId;
                    detalisrow.StrInvoiceCode = detalis.StrInvoiceCode;
                    detalisrow.IntDeliveryId = datas.DeliveryId;
                    detalisrow.StrDeliveryCode = datas.DeliveryCode;
                    detalisrow.IntSalesOrderId = datas.SalesOrderId;
                    detalisrow.StrSalesOrderCode = datas.SalesOrderCode;

                    detalisrow.IntDeliveryRowId = datas.DeliveryRowId;
                    detalisrow.IntItemId = datas.ItemId;
                    detalisrow.StrItemSalesCode = datas.ItemSalesCode;
                    detalisrow.StrItemSalesName = datas.ItemSalesName;
                    detalisrow.StrItemCode = datas.ItemCode;
                    detalisrow.StrItemName = datas.ItemName;

                    detalisrow.IntUom = datas.IntUom;
                    detalisrow.StrUom = datas.StrUom;
                    detalisrow.NumQuantity = datas.Quantity;
                    detalisrow.NumItemPrice = datas.ItemPrice;
                    detalisrow.NumDeliveryValue = datas.DeliveryValue;
                    detalisrow.NumTotalDiscountValue = datas.TotalDiscountValue;

                    detalisrow.NumTotalShipingValue = datas.TotalShipingValue;
                    detalisrow.NumTotalTax = datas.TotalTax;
                    detalisrow.NumNetValue = datas.NetValue;
                    detalisrow.IsFreeItem = datas.IsFreeItem;
                    detalisrow.IsActive = true;

                    payableRows.Add(detalisrow);
                }
                await _context.TblAccountPayableRow.AddRangeAsync(payableRows);
                await _context.SaveChangesAsync();

                var receivableRows = new List<TblAccountReceivableRow>(postAccountReceivablePayableCommon.AccountReceivableRowList.Count);
                foreach (var datasR in postAccountReceivablePayableCommon.AccountReceivableRowList)
                {
                    var detalisRrow = new TblAccountReceivableRow { };
                    detalisRrow.IntAccountReceivablePayableId = detalis.IntAccountReceivablePayableId;
                    detalisRrow.StrInvoiceCode = detalis.StrInvoiceCode;
                    detalisRrow.IntDeliveryId = datasR.DeliveryId;
                    detalisRrow.StrDeliveryCode = datasR.DeliveryCode;
                    detalisRrow.IntSalesOrderId = datasR.SalesOrderId;
                    detalisRrow.StrSalesOrderCode = datasR.SalesOrderCode;

                    detalisRrow.IntDeliveryRowId = datasR.DeliveryRowId;
                    detalisRrow.IntItemId = datasR.ItemId;
                    detalisRrow.StrItemSalesCode = datasR.ItemSalesCode;
                    detalisRrow.StrItemSalesName = datasR.ItemSalesName;
                    detalisRrow.StrItemCode = datasR.ItemCode;
                    detalisRrow.StrItemName = datasR.ItemName;

                    detalisRrow.IntUom = datasR.IntUom;
                    detalisRrow.StrUom = datasR.StrUom;
                    detalisRrow.NumQuantity = datasR.Quantity;
                    detalisRrow.NumItemPrice = datasR.ItemPrice;
                    detalisRrow.NumDeliveryValue = datasR.DeliveryValue;
                    detalisRrow.NumTotalDiscountValue = datasR.TotalDiscountValue;

                    detalisRrow.NumTotalShipingValue = datasR.TotalShipingValue;
                    detalisRrow.NumTotalTax = datasR.TotalTax;
                    detalisRrow.NumNetValue = datasR.NetValue;
                    detalisRrow.IsFreeItem = datasR.IsFreeItem;
                    detalisRrow.IsActive = true;

                    receivableRows.Add(detalisRrow);
                }
                await _context.TblAccountReceivableRow.AddRangeAsync(receivableRows);
                await _context.SaveChangesAsync();

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Payable Receivable Created Successfully.",
                    data = postAccountReceivablePayableCommon
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<object> EditAccountReceivablePayableCommon(EditAccountReceivablePayableCommonDTO putAccountReceivablePayableCommon)
        {
            try
            {
                TblAccountReceivablePayableHeader dataParent = _context.TblAccountReceivablePayableHeader.First(x => x.IntAccountReceivablePayableId == putAccountReceivablePayableCommon.AccountReceivablePayableHeader.AccountReceivablePayableId
                && putAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsCleared == false && putAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsActive == true);

                dataParent.IntClientId = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.ClientId;
                dataParent.IntBusinessUnitId = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessUnitId;
                dataParent.IntBusinessAreaId = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessAreaId;
                dataParent.IntBusinessPartnerId = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.BusinessPartnerId;
                dataParent.StrInvoiceCode = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.InvoiceCode;
                dataParent.IntAdjustmentJournalId = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.AdjustmentJournalId;
                dataParent.StrAdjustmentJournalCode = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.AdjustmentJournalCode;
                dataParent.NumAmount = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.Amount;
                dataParent.StrNarration = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.Narration;
                dataParent.IsReceivable = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsReceivable;
                dataParent.IntPayTerm = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.PayTerm;
                dataParent.DteTransactionDate = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.TransactionDate;
                dataParent.DteDueDate = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.DueDate;
                dataParent.IsCleared = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.IsCleared;
                dataParent.DteClearingDate = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.ClearingDate;
                dataParent.IntActionBy = putAccountReceivablePayableCommon.AccountReceivablePayableHeader.ActionBy;
                dataParent.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblAccountReceivablePayableHeader.Update(dataParent);
                await _context.SaveChangesAsync();

                var JournalRows = new List<TblAccountPayableRow>(putAccountReceivablePayableCommon.AccountPayableRowList.Count);
                foreach (var datasR in putAccountReceivablePayableCommon.AccountPayableRowList)
                {
                    TblAccountPayableRow detalisRrow = _context.TblAccountPayableRow.First(x => x.IntRowId == datasR.RowId);

                    detalisRrow.IntAccountReceivablePayableId = dataParent.IntAccountReceivablePayableId;
                    detalisRrow.StrInvoiceCode = dataParent.StrInvoiceCode;
                    detalisRrow.IntDeliveryId = datasR.DeliveryId;
                    detalisRrow.StrDeliveryCode = datasR.DeliveryCode;
                    detalisRrow.IntSalesOrderId = datasR.SalesOrderId;
                    detalisRrow.StrSalesOrderCode = datasR.SalesOrderCode;

                    detalisRrow.IntDeliveryRowId = datasR.DeliveryRowId;
                    detalisRrow.IntItemId = datasR.ItemId;
                    detalisRrow.StrItemSalesCode = datasR.ItemSalesCode;
                    detalisRrow.StrItemSalesName = datasR.ItemSalesName;
                    detalisRrow.StrItemCode = datasR.ItemCode;
                    detalisRrow.StrItemName = datasR.ItemName;

                    detalisRrow.IntUom = datasR.IntUom;
                    detalisRrow.StrUom = datasR.StrUom;
                    detalisRrow.NumQuantity = datasR.Quantity;
                    detalisRrow.NumItemPrice = datasR.ItemPrice;
                    detalisRrow.NumDeliveryValue = datasR.DeliveryValue;
                    detalisRrow.NumTotalDiscountValue = datasR.TotalDiscountValue;

                    detalisRrow.NumTotalShipingValue = datasR.TotalShipingValue;
                    detalisRrow.NumTotalTax = datasR.TotalTax;
                    detalisRrow.NumNetValue = datasR.NetValue;
                    detalisRrow.IsFreeItem = datasR.IsFreeItem;
                    detalisRrow.IsActive = datasR.IsActive;

                    JournalRows.Add(detalisRrow);
                }
                _context.TblAccountPayableRow.UpdateRange(JournalRows);
                await _context.SaveChangesAsync();

                var JournalRRows = new List<TblAccountReceivableRow>(putAccountReceivablePayableCommon.AccountReceivableRowList.Count);
                foreach (var datasR in putAccountReceivablePayableCommon.AccountReceivableRowList)
                {
                    TblAccountReceivableRow detalisRrow = _context.TblAccountReceivableRow.First(x => x.IntRowId == datasR.RowId);

                    detalisRrow.IntAccountReceivablePayableId = dataParent.IntAccountReceivablePayableId;
                    detalisRrow.StrInvoiceCode = dataParent.StrInvoiceCode;
                    detalisRrow.IntDeliveryId = datasR.DeliveryId;
                    detalisRrow.StrDeliveryCode = datasR.DeliveryCode;
                    detalisRrow.IntSalesOrderId = datasR.SalesOrderId;
                    detalisRrow.StrSalesOrderCode = datasR.SalesOrderCode;

                    detalisRrow.IntDeliveryRowId = datasR.DeliveryRowId;
                    detalisRrow.IntItemId = datasR.ItemId;
                    detalisRrow.StrItemSalesCode = datasR.ItemSalesCode;
                    detalisRrow.StrItemSalesName = datasR.ItemSalesName;
                    detalisRrow.StrItemCode = datasR.ItemCode;
                    detalisRrow.StrItemName = datasR.ItemName;

                    detalisRrow.IntUom = datasR.IntUom;
                    detalisRrow.StrUom = datasR.StrUom;
                    detalisRrow.NumQuantity = datasR.Quantity;
                    detalisRrow.NumItemPrice = datasR.ItemPrice;
                    detalisRrow.NumDeliveryValue = datasR.DeliveryValue;
                    detalisRrow.NumTotalDiscountValue = datasR.TotalDiscountValue;

                    detalisRrow.NumTotalShipingValue = datasR.TotalShipingValue;
                    detalisRrow.NumTotalTax = datasR.TotalTax;
                    detalisRrow.NumNetValue = datasR.NetValue;
                    detalisRrow.IsFreeItem = datasR.IsFreeItem;
                    detalisRrow.IsActive = datasR.IsActive;

                    JournalRRows.Add(detalisRrow);
                }
                _context.TblAccountPayableRow.UpdateRange(JournalRows);
                await _context.SaveChangesAsync();

                var successmsg = new
                {
                    status = true,
                    message = "Edited Successfully.",
                    data = putAccountReceivablePayableCommon
                };
                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public async Task<Message> GetAccountPayableRowById(long receivablePayableId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Payable Row",

                    data = await _context.TblAccountPayableRow.Where(x => x.IntAccountReceivablePayableId == receivablePayableId && x.IsActive == true).Select(t => new GetAccountPayableRowDTO()
                    {
                        RowId = t.IntRowId,
                        AccountReceivablePayableId = t.IntAccountReceivablePayableId,
                        InvoiceCode = t.StrInvoiceCode,
                        DeliveryId = t.IntDeliveryId,
                        DeliveryCode = t.StrDeliveryCode,
                        SalesOrderId = t.IntSalesOrderId,
                        SalesOrderCode = t.StrInvoiceCode,
                        DeliveryRowId = t.IntDeliveryRowId,
                        ItemId = t.IntItemId,
                        ItemSalesCode = t.StrItemSalesCode,
                        ItemSalesName = t.StrItemSalesName,
                        ItemCode = t.StrItemCode,
                        ItemName = t.StrItemName,
                        IntUom = t.IntUom,
                        StrUom = t.StrUom,
                        Quantity = t.NumQuantity,
                        ItemPrice = t.NumItemPrice,
                        DeliveryValue = t.NumDeliveryValue,
                        TotalDiscountValue = t.NumTotalDiscountValue,
                        TotalShipingValue = t.NumTotalShipingValue,
                        TotalTax = t.NumTotalTax,
                        NetValue = t.NumNetValue,
                        IsFreeItem = t.IsFreeItem,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAccountReceivablePayableHeaderById(long ReceivablePayableId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Receivable Payable Header",

                    data = await _context.TblAccountReceivablePayableHeader.Where(x => x.IntAccountReceivablePayableId == ReceivablePayableId && x.IsActive == true && x.IsCleared == iscomplete).Select(t => new GetAccountReceivablePayableHeaderDTO()
                    {
                        AccountReceivablePayableId = t.IntAdjustmentJournalId,
                        ClientId = t.IntClientId,
                        BusinessUnitId = t.IntBusinessUnitId,
                        BusinessAreaId = t.IntBusinessAreaId,
                        BusinessPartnerId = t.IntBusinessPartnerId,
                        InvoiceCode = t.StrInvoiceCode,
                        AdjustmentJournalId = t.IntAdjustmentJournalId,
                        AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                        Amount = t.NumAmount,
                        Narration = t.StrNarration,
                        IsReceivable = t.IsReceivable,
                        PayTerm = t.IntPayTerm,
                        TransactionDate = t.DteTransactionDate,
                        DueDate = t.DteDueDate,
                        IsCleared = t.IsCleared,
                        ClearingDate = t.DteClearingDate,
                        ActionBy = t.IntActionBy,
                        LastActionDateTime = t.DteLastActionDateTime,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAccountReceivablePayableHeaderClientBusinessUnitArea(long ClientId, long BusinessUnitId, long BusinessAreaId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Receivable Payable Header",

                    data = await _context.TblAccountReceivablePayableHeader.Where(x => x.IntClientId == ClientId && x.IsActive == true && x.IsCleared == iscomplete
                        && x.IntBusinessUnitId == BusinessUnitId && x.IntBusinessAreaId == BusinessAreaId).Select(t => new GetAccountReceivablePayableHeaderDTO()
                        {
                            AccountReceivablePayableId = t.IntAdjustmentJournalId,
                            ClientId = t.IntClientId,
                            BusinessUnitId = t.IntBusinessUnitId,
                            BusinessAreaId = t.IntBusinessAreaId,
                            BusinessPartnerId = t.IntBusinessPartnerId,
                            InvoiceCode = t.StrInvoiceCode,
                            AdjustmentJournalId = t.IntAdjustmentJournalId,
                            AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                            Amount = t.NumAmount,
                            Narration = t.StrNarration,
                            IsReceivable = t.IsReceivable,
                            PayTerm = t.IntPayTerm,
                            TransactionDate = t.DteTransactionDate,
                            DueDate = t.DteDueDate,
                            IsCleared = t.IsCleared,
                            ClearingDate = t.DteClearingDate,
                            ActionBy = t.IntActionBy,
                            LastActionDateTime = t.DteLastActionDateTime,
                            IsActive = t.IsActive
                        }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAccountReceivablePayableHeaderClientBusinessUnitPartner(long ClientId, long BusinessUnitId, long BusinessPartnerId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Receivable Payable Header",

                    data = await _context.TblAccountReceivablePayableHeader.Where(x => x.IntClientId == ClientId && x.IsActive == true && x.IsCleared == iscomplete
                        && x.IntBusinessUnitId == BusinessUnitId && x.IntBusinessPartnerId == BusinessPartnerId).Select(t => new GetAccountReceivablePayableHeaderDTO()
                        {
                            AccountReceivablePayableId = t.IntAdjustmentJournalId,
                            ClientId = t.IntClientId,
                            BusinessUnitId = t.IntBusinessUnitId,
                            BusinessAreaId = t.IntBusinessAreaId,
                            BusinessPartnerId = t.IntBusinessPartnerId,
                            InvoiceCode = t.StrInvoiceCode,
                            AdjustmentJournalId = t.IntAdjustmentJournalId,
                            AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                            Amount = t.NumAmount,
                            Narration = t.StrNarration,
                            IsReceivable = t.IsReceivable,
                            PayTerm = t.IntPayTerm,
                            TransactionDate = t.DteTransactionDate,
                            DueDate = t.DteDueDate,
                            IsCleared = t.IsCleared,
                            ClearingDate = t.DteClearingDate,
                            ActionBy = t.IntActionBy,
                            LastActionDateTime = t.DteLastActionDateTime,
                            IsActive = t.IsActive
                        }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAccountReceivablePayableHeaderClientIdBusinessUnitId(long ClientId, long BusinessUnitId, bool iscomplete)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Receivable Payable Header",

                    data = await _context.TblAccountReceivablePayableHeader.Where(x => x.IntClientId == ClientId && x.IsActive == true && x.IsCleared == iscomplete
                        && x.IntBusinessUnitId == BusinessUnitId).Select(t => new GetAccountReceivablePayableHeaderDTO()
                        {
                            AccountReceivablePayableId = t.IntAdjustmentJournalId,
                            ClientId = t.IntClientId,
                            BusinessUnitId = t.IntBusinessUnitId,
                            BusinessAreaId = t.IntBusinessAreaId,
                            BusinessPartnerId = t.IntBusinessPartnerId,
                            InvoiceCode = t.StrInvoiceCode,
                            AdjustmentJournalId = t.IntAdjustmentJournalId,
                            AdjustmentJournalCode = t.StrAdjustmentJournalCode,
                            Amount = t.NumAmount,
                            Narration = t.StrNarration,
                            IsReceivable = t.IsReceivable,
                            PayTerm = t.IntPayTerm,
                            TransactionDate = t.DteTransactionDate,
                            DueDate = t.DteDueDate,
                            IsCleared = t.IsCleared,
                            ClearingDate = t.DteClearingDate,
                            ActionBy = t.IntActionBy,
                            LastActionDateTime = t.DteLastActionDateTime,
                            IsActive = t.IsActive
                        }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }

        public async Task<Message> GetAccountReceivableRowById(long receivablePayableId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Account Receivable Row",

                    data = await _context.TblAccountReceivableRow.Where(x => x.IntAccountReceivablePayableId == receivablePayableId && x.IsActive == true).Select(t => new GetAccountReceivableRowDTO()
                    {
                        RowId = t.IntRowId,
                        AccountReceivablePayableId = t.IntAccountReceivablePayableId,
                        InvoiceCode = t.StrInvoiceCode,
                        DeliveryId = t.IntDeliveryId,
                        DeliveryCode = t.StrDeliveryCode,
                        SalesOrderId = t.IntSalesOrderId,
                        SalesOrderCode = t.StrInvoiceCode,
                        DeliveryRowId = t.IntDeliveryRowId,
                        ItemId = t.IntItemId,
                        ItemSalesCode = t.StrItemSalesCode,
                        ItemSalesName = t.StrItemSalesName,
                        ItemCode = t.StrItemCode,
                        ItemName = t.StrItemName,
                        IntUom = t.IntUom,
                        StrUom = t.StrUom,
                        Quantity = t.NumQuantity,
                        ItemPrice = t.NumItemPrice,
                        DeliveryValue = t.NumDeliveryValue,
                        TotalDiscountValue = t.NumTotalDiscountValue,
                        TotalShipingValue = t.NumTotalShipingValue,
                        TotalTax = t.NumTotalTax,
                        NetValue = t.NumNetValue,
                        IsFreeItem = t.IsFreeItem,
                        IsActive = t.IsActive
                    }).ToListAsync()
                };
            }
            catch (Exception ex)
            {
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
