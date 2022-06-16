using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override List<Product> GetAll()
        {
            using (var context = new SwapDbContext())
            {
                return context.Set<Product>().Include(x => x.Comments).ToList();
            }
        }

        public override Product GetById(int id)
        {
            using (var context = new SwapDbContext())
            {
                Product product = context.Set<Product>().Include(x => x.Comments).FirstOrDefault(x => x.ID == id);
                return product;
            }
        }

        public void UpdateField(int urlId, int id)
        {
            using (var context = new SwapDbContext())
            {
                var product = context.Set<Product>().Find(urlId);
                product.UserID = id;
                context.SaveChanges();
            }
        }

        public void AcceptBid(int id)
        {
            using (var context = new SwapDbContext())
            {
                Product product1 = context.Products.Find(id);
                Product product2 = context.Products.Find(product1.Fid);
                context.Products.Remove(product1);
                context.Products.Remove(product2);
                context.SaveChanges();
            }
        }
    }
}
