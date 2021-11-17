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
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.Create(user);
        }

        [HttpPut]
        public void Put([FromBody] User user)
        {
            _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(User user)
        {
            _userService.Delete(user);
        }
    }
}
