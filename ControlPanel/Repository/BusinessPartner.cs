using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.BusinessPartner;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using ControlPanellNew.Helper;

namespace ControlPanel.Repository
{
    public class BusinessPartner : IBusinessPartner
    {
        public readonly iBOSContext _context;
        public BusinessPartner(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner List .",
                    data = await Task.FromResult((from a in _context.TblBusinessPartner
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where a.IsActive == true
                                                  select new GetBusinessPartnerDTO()
                                                  {

                                                      BusinessPartnerId = a.IntBusinessPartnerId,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = a.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerCode = a.StrBusinessPartnerCode,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                                      ContactNumber = a.StrContactNumber,
                                                      Email = a.StrEmail,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<Message> GetBusinessPartnerId(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner List By Id.",
                    data = await Task.FromResult((from a in _context.TblBusinessPartner
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where a.IsActive == true && a.IntBusinessPartnerId == Id
                                                  select new GetBusinessPartnerDTO()
                                                  {

                                                      BusinessPartnerId = a.IntBusinessPartnerId,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = a.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerCode = a.StrBusinessPartnerCode,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                                      ContactNumber = a.StrContactNumber,
                                                      Email = a.StrEmail,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<Message> GetBusinessPartnerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner List By Client Id.",
                    data = await Task.FromResult((from a in _context.TblBusinessPartner
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetBusinessPartnerDTO()
                                                  {

                                                      BusinessPartnerId = a.IntBusinessPartnerId,
                                                      BusinessUnitId = a.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ClientId = a.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerCode = a.StrBusinessPartnerCode,
                                                      BusinessPartnerName = a.StrBusinessPartnerName,
                                                      BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                                      ContactNumber = a.StrContactNumber,
                                                      Email = a.StrEmail,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

                                                  }).ToList())
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
        public async Task<object> CreateBusinessPartner(CreateBusinessPartnerDTO postBusinessPartner)
        {
            try
            {
                var detalis = new TblBusinessPartner
                {
                    IntClientId = postBusinessPartner.ClientId,
                    StrBusinessPartnerCode = postBusinessPartner.BusinessPartnerName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrBusinessPartnerName = postBusinessPartner.BusinessPartnerName,
                    StrBusinessPartnerAddress = postBusinessPartner.BusinessPartnerAddress,
                    IntBusinessUnitId = postBusinessPartner.BusinessUnitId,
                    StrContactNumber = postBusinessPartner.ContactNumber,
                    StrEmail = postBusinessPartner.Email,
                    IntActionBy = postBusinessPartner.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblBusinessPartner.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisViews = from a in _context.TblBusinessPartner
                                   join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                   join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                   where a.IsActive == true &&  a.IntBusinessPartnerId == detalis.IntBusinessPartnerId
                                   select new GetBusinessPartnerDTO()
                                   {

                                       BusinessPartnerId = a.IntBusinessPartnerId,
                                       BusinessUnitId = a.IntBusinessUnitId,
                                       BusinessUnitName = u.StrBusinessUnitName,
                                       ClientId = a.IntClientId,
                                       ClientName = c.StrClientName,
                                       BusinessPartnerCode = a.StrBusinessPartnerCode,
                                       BusinessPartnerName = a.StrBusinessPartnerName,
                                       BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                       ContactNumber = a.StrContactNumber,
                                       Email = a.StrEmail,
                                       ActionBy = a.IntActionBy,
                                       LastActionDateTime = a.DteLastActionDateTime

                                   };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Created Successfully.",
                    data = detalisViews
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
        public async Task<object> EditBusinessPartner(EditBusinessPartnerDTO businesspartner)
        {
            try
            {
                TblBusinessPartner data = _context.TblBusinessPartner.First(x => x.IntBusinessPartnerId == businesspartner.BusinessPartnerId);
                data.StrBusinessPartnerName = businesspartner.BusinessPartnerName;
                data.StrBusinessPartnerAddress = businesspartner.BusinessPartnerAddress;
                data.StrContactNumber = businesspartner.ContactNumber;
                data.StrEmail = businesspartner.Email;
                data.IntActionBy = businesspartner.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessPartner.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBusinessPartner
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              where a.IsActive == true && a.IntBusinessPartnerId == businesspartner.BusinessPartnerId
                              select new GetBusinessPartnerDTO()
                              {

                                  BusinessPartnerId = a.IntBusinessPartnerId,
                                  BusinessUnitId = a.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ClientId = a.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessPartnerCode = a.StrBusinessPartnerCode,
                                  BusinessPartnerName = a.StrBusinessPartnerName,
                                  BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                  ContactNumber = a.StrContactNumber,
                                  Email = a.StrEmail,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Edited Successfully.",
                    data = detalis
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
        public async Task<object> CancelBusinessPartner(CancelBusinessPartnerDTO businesspartner)
        {
            try
            {
                TblBusinessPartner data = _context.TblBusinessPartner.First(x => x.IntBusinessPartnerId == businesspartner.BusinessPartnerId);

                data.IntActionBy = businesspartner.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartner.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBusinessPartner
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              where a.IsActive == false && a.IntBusinessPartnerId == businesspartner.BusinessPartnerId
                              select new GetBusinessPartnerDTO()
                              {

                                  BusinessPartnerId = a.IntBusinessPartnerId,
                                  BusinessUnitId = a.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ClientId = a.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessPartnerCode = a.StrBusinessPartnerCode,
                                  BusinessPartnerName = a.StrBusinessPartnerName,
                                  BusinessPartnerAddress = a.StrBusinessPartnerAddress,
                                  ContactNumber = a.StrContactNumber,
                                  Email = a.StrEmail,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Cancelled Successfully.",
                    data = detalis
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

    }
}
