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
    public class BidsController : ControllerBase
    {
        private IBidService _bidService;

        public BidsController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpGet]
        public List<Bid> Get()
        {
            return _bidService.GetAll();
        }

        [HttpGet("{id}")]
        public Bid Get(int id)
        {
            return _bidService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Bid user)
        {
            _bidService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] Bid user)
        {
            _bidService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bidService.Delete(id);
        }
    }
}
