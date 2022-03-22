using Microsoft.EntityFrameworkCore;
using SwapApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class GenericRepository<T, TContext> : IRepository<T>
        where T : class
        where TContext : SwapDbContext, new()
    {
        public void Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }



        public virtual void Delete(int id)
        {
            using (var context = new TContext())
            {

            }
        }

        public virtual List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public virtual T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
