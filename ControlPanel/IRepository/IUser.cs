using ControlPanel.DTO.User;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IUser
    {
        Task<Message> GetUserAll();
        Task<Message> GetUserById(long Id);
        Task<Message> GetUserByClientId(long CId);
        Task<object> CreateUser(CreateUserDTO postUser);
        Task<object> EditUser(EditUserDTO user);
        Task<object> CancelUser(CancelUserDTO user);

    }
}
