using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Product user)
        {
            _productService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] Product user)
        {
            _productService.Update(user);
        }

        [HttpPatch("{id}")]
        public void Patch(int urlId, int id)
        {
            _productService.UpdateField(urlId, id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
