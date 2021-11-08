using Microsoft.EntityFrameworkCore;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            using (var context = new SwapDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            using (var context = new SwapDbContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var context = new SwapDbContext())
            {
                return context.Users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var context = new SwapDbContext())
            {
                return context.Users.Find(id);
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new SwapDbContext())
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
