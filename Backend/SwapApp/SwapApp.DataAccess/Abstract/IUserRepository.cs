using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Abstract
{
    public interface IUserRepository: IRepository<User>
    {
        User GetLoggedIn(int id);
    }
}
