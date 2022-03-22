using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class ProductStatusManager : IProductStatusService
    {
        private IProductStatusRepository _productStatusRepository;

        public ProductStatusManager(IProductStatusRepository productStatusRepository)
        {
            _productStatusRepository = productStatusRepository;
        }

        public void Create(ProductStatus entity)
        {
            _productStatusRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _productStatusRepository.Delete(id);
        }

        public List<ProductStatus> GetAll()
        {
            return _productStatusRepository.GetAll();
        }

        public ProductStatus GetById(int id)
        {
            return _productStatusRepository.GetById(id);
        }

        public void Update(ProductStatus entity)
        {
            _productStatusRepository.Update(entity);
        }
    }
}
