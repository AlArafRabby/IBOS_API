using ControlPanel.DbContexts;
using ControlPanel.DTO.User;
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
    public class User : IUser
    {
        public readonly iBOSContext _context;
        public User(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetUserAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "User List.",
                    data= await Task.FromResult((from t in _context.TblUser
                                                 join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                 where t.IsActive == true
                                                 select new GetUserDTO()
                                                 {
                                                    UserId = t.IntUserId,
                                                    UserName = t.StrUserName,
                                                    ActionBy = t.IntActionBy,
                                                    ClientId = t.IntClientId,
                                                    ClientName = c.StrClientName,
                                                    LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetUserById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "User List By Id.",
                    data = await Task.FromResult((from t in _context.TblUser
                                                  join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                  where t.IsActive == true && t.IntUserId == Id
                                                  select new GetUserDTO()
                                                  {
                                                      UserId = t.IntUserId,
                                                      UserName = t.StrUserName,
                                                      ActionBy = t.IntActionBy,
                                                      ClientId = t.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<Message> GetUserByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "User List By Client Id.",
                    data = await Task.FromResult((from t in _context.TblUser
                                                  join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                                  where t.IsActive == true && t.IntClientId == CId
                                                  select new GetUserDTO()
                                                  {
                                                      UserId = t.IntUserId,
                                                      UserName = t.StrUserName,
                                                      ActionBy = t.IntActionBy,
                                                      ClientId = t.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      LastActionDateTime = t.DteLastActionDateTime

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
        public async Task<object> CreateUser(CreateUserDTO postUser)
        {
            try
            {
                var detalis = new TblUser
                {
                    StrUserName = postUser.UserName,
                    StrLoginId = postUser.LoginId,
                    StrPassword = postUser.Password,
                    IntActionBy = postUser.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true


                };
                await _context.TblUser.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from t in _context.TblUser
                                  join c in _context.TblClient on t.IntClientId equals c.IntClientId
                                  where t.IsActive == true && t.IntUserId == detalis.IntUserId
                                  select new GetUserDTO()
                                  {
                                      UserId = t.IntUserId,
                                      UserName = t.StrUserName,
                                      ActionBy = t.IntActionBy,
                                      ClientId = t.IntClientId,
                                      ClientName = c.StrClientName,
                                      LastActionDateTime = t.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "User has been Created Successfully.",
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
        public async Task<object> EditUser(EditUserDTO user)
        {
            try
            {
                TblUser data = _context.TblUser.First(x => x.IntUserId == user.UserId);

                data.IntUserId = user.UserId;
                data.StrUserName = user.UserName;
                data.StrLoginId = user.LoginId;
                data.IntActionBy = user.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblUser.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from t in _context.TblUser
                              join c in _context.TblClient on t.IntClientId equals c.IntClientId
                              where t.IsActive == true && t.IntUserId == user.UserId
                              select new GetUserDTO()
                              {
                                  UserId = t.IntUserId,
                                  UserName = t.StrUserName,
                                  ActionBy = t.IntActionBy,
                                  ClientId = t.IntClientId,
                                  ClientName = c.StrClientName,
                                  LastActionDateTime = t.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "User Edited Successfully.",
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
        public async Task<object> CancelUser(CancelUserDTO user)
        {
            try
            {
                TblUser data = _context.TblUser.First(x => x.IntUserId == user.UserId);

                data.IntUserId = user.UserId;
                data.IntActionBy = user.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblUser.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from t in _context.TblUser
                              join c in _context.TblClient on t.IntClientId equals c.IntClientId
                              where t.IsActive == true && t.IntUserId == user.UserId
                              select new GetUserDTO()
                              {
                                  UserId = t.IntUserId,
                                  UserName = t.StrUserName,
                                  ActionBy = t.IntActionBy,
                                  ClientId = t.IntClientId,
                                  ClientName = c.StrClientName,
                                  LastActionDateTime = t.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "User Cancelled Successfully.",
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
