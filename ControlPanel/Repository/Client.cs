using ControlPanel.DbContexts;
using ControlPanel.DTO.Client;
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
    public class Client : IClient
    {
        public readonly iBOSContext _context;
        public Client(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetClientAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Client List.",
                    data = await _context.TblClient.Where(x => x.IsActive == true).Select(t => new GetClientDTO()
                    {
               
                        ClientId = t.IntClientId,
                        ClientCode = t.StrClientCode,
                        ClientName = t.StrClientName,
                        ClientAddress = t.StrClientAddress,
                        ActionBy = t.IntActionBy,
                        LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetClientById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Client List By Id.",
                    data = await _context.TblClient.Where(x => x.IntClientId == Id && x.IsActive == true).Select(t => new GetClientDTO()
                    {
                        ClientId = t.IntClientId,      
                        ClientCode = t.StrClientCode,
                        ClientName = t.StrClientName,
                        ClientAddress = t.StrClientAddress,
                        ActionBy = t.IntActionBy,
                        LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<object> CreateClient(CreateClientDTO postClient)
        {
            try
            {
                var detalis = new TblClient
                {
                    StrClientCode = postClient.ClientName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrClientName = postClient.ClientName,
                    StrClientAddress = postClient.ClientAddress,
                    IntActionBy = postClient.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblClient.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = new GetClientDTO
                {
                    ClientId = detalis.IntClientId,
                    ClientCode = detalis.StrClientCode,
                    ClientName = detalis.StrClientName,
                    ClientAddress = detalis.StrClientAddress,
                    ActionBy = detalis.IntActionBy,
                    LastActionDateTime = detalis.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Client Created Successfully.",
                    data = detalisView
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
        public async Task<object> EditClient(EditClientDTO client)
        {
            try
            {
                TblClient data = _context.TblClient.First(x => x.IntClientId == client.ClientId);

                data.IntClientId = client.ClientId;
                data.StrClientCode = client.ClientCode;
                data.StrClientName = client.ClientName;
                data.StrClientAddress = client.ClientAddress;
                data.IntActionBy = client.ActionBy;

                _context.TblClient.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetClientDTO
                {
                    ClientId = data.IntClientId,
                    ClientCode = data.StrClientCode,
                    ClientName = data.StrClientName,
                    ClientAddress = data.StrClientAddress,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Client Edited Successfully.",
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
        public async Task<object> CancelClient(CancelClientDTO client)
        {
            try
            {
                TblClient data = _context.TblClient.First(x => x.IntClientId == client.ClientId);

                data.IntActionBy = client.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblClient.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetClientDTO
                {
                    ClientId = data.IntClientId,
                    ClientCode = data.StrClientCode,
                    ClientName = data.StrClientName,
                    ClientAddress = data.StrClientAddress,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Client Cancelled Successfully.",
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
