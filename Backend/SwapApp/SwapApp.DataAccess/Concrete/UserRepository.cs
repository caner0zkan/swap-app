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

        public override List<User> GetAll()
        {
            using (var context = new SwapDbContext())
            {
                return context.Set<User>().Include(x => x.Products).ToList();
            }
        }

        public override User GetById(int id)
        {
            using (var context = new SwapDbContext())
            {
                User user = context.Set<User>().Include(x=>x.Products).FirstOrDefault(x=>x.ID ==id);
                return user;
            }
        }
    }
}
