using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IProductStatusService
    {
        List<ProductStatus> GetAll();

        ProductStatus GetById(int id);

        void Create(ProductStatus entity);

        void Update(ProductStatus entity);

        void Delete(int id);
    }
}
