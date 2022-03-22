using Microsoft.EntityFrameworkCore;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product, SwapDbContext>, IProductRepository
    {
        public override void Delete(int id)
        {
            using (var context = new SwapDbContext())
            {
                Product product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
