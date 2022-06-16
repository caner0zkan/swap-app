using Microsoft.AspNetCore.JsonPatch;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        void Create(Product entity);

        void Update(Product entity);

        void UpdateField(int urlId, int id);

        void Delete(int id);
        void AcceptBid(int id);
    }
}
