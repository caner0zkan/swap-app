using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
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

        static int sid;
        static string sname;

        [HttpPost]
        [EnableCors]
        public IActionResult Post([FromBody] User user)
        {
            var login = context.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if(login != null)
            {
                sid = login.ID;
                sname = login.Name;

                HttpContext.Session.SetString("name", login.Name);
                HttpContext.Session.SetInt32("id", login.ID);

                //HttpContext.Response.Cookies.Append("cname", login.Name);
                //HttpContext.Response.Cookies.Append("cid", login.ID.ToString());

                return CreatedAtAction("Get", new { id = login.ID }, login);
            }
            else
            {
                return BadRequest("Girdiğiniz bilgiler uyuşmamaktadır. Lütfen tekrar deneyiniz.");
            }
        }

        public int LoginId()
        {
            return sid;
        }

        public string LoginName()
        {
            return sname;
        }

    }
}
