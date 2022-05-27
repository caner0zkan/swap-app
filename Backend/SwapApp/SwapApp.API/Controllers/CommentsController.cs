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
    public class CommentsController : ControllerBase
    {
        private ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public List<Comment> Get()
        {
            return _commentService.GetAll();
        }

        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _commentService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Comment user)
        {
            var login = new LoginController();
            //var sessionName = HttpContext.Session.GetString("name");
            //var sessionId = HttpContext.Session.GetInt32("id");
            var sessionName = login.LoginName();
            var sessionId = login.LoginId();
            _commentService.Create(user, sessionId, sessionName);
        }

        [HttpPut]
        public void Put([FromBody] Comment user)
        {
            _commentService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _commentService.Delete(id);
        }
    }
}
