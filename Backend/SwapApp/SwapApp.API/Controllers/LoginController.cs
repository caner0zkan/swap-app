﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwapApp.DataAccess;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        SwapDbContext context = new SwapDbContext();

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = context.Users.Find(id);
            return user;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            var login = context.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if(login != null)
            {
                return CreatedAtAction("Get", new { id = login.ID }, login);
            }
            else
            {
                return BadRequest("Girdiğiniz bilgiler uyuşmamaktadır. Lütfen tekrar deneyiniz.");
            }
        }

    }
}
