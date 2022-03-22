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
    public class ImagesController : ControllerBase
    {
        private IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public List<Image> Get()
        {
            return _imageService.GetAll();
        }

        [HttpGet("{id}")]
        public Image Get(int id)
        {
            return _imageService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Image user)
        {
            _imageService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] Image user)
        {
            _imageService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _imageService.Delete(id);
        }
    }
}
