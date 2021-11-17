using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwapApp.Business.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStatusesController : ControllerBase
    {
        private IProductStatusService _productStatusService;

        public ProductStatusesController(IProductStatusService productStatusService)
        {
            _productStatusService = productStatusService;
        }

        [HttpGet]
        public List<ProductStatus> Get()
        {
            return _productStatusService.GetAll();
        }

        [HttpGet("{id}")]
        public ProductStatus Get(int id)
        {
            return _productStatusService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] ProductStatus user)
        {
            _productStatusService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] ProductStatus user)
        {
            _productStatusService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(ProductStatus user)
        {
            _productStatusService.Delete(user);
        }
    }
}
