using Microsoft.EntityFrameworkCore;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class UserRepository : GenericRepository<User, SwapDbContext>, IUserRepository
    {
    }
}
