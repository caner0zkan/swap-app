using Microsoft.AspNetCore.JsonPatch;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        void UpdateField(int urlId, int id);
        void AcceptBid(int id);
    }
}
