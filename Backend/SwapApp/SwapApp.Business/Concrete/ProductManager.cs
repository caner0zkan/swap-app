using Microsoft.AspNetCore.JsonPatch;
using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.DataAccess.Concrete;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void UpdateField(int urlId, int id)
        {
            _productRepository.UpdateField(urlId, id);
        }
    }
}
