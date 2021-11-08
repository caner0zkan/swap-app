using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
