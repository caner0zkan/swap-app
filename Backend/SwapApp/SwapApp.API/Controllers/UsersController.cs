using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SwapApp.Business.Abstract;
using SwapApp.Business.Concrete;
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

        public UsersController()
        {
            _userService = new UserManager();
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.CreateUser(user);
        }

        [HttpPut]
        public void Put([FromBody] User user)
        {
            _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(User user)
        {
            _userService.DeleteUser(user);
        }
    }
}
