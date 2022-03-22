using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();

        User GetById(int id);

        void Create(User entity);

        void Update(User entity);

        void Delete(int id);
    }
}
