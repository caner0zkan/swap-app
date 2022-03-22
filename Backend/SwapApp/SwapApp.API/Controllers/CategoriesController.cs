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
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Category user)
        {
            _categoryService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] Category user)
        {
            _categoryService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }
    }
}
