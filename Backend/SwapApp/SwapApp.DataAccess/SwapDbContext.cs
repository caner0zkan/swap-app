using Microsoft.EntityFrameworkCore;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess
{
    public class SwapDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=CANER\SQLEXPRESS; Database=SwapAppDb; uid=sa; pwd=1234;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
