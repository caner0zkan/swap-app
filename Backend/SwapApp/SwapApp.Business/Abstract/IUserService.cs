using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
