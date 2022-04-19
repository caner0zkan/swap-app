using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Create(Comment entity,int? sessionId, string sessionName)
        {
            _commentRepository.Create(entity,sessionId,sessionName);
        }

        public void Delete(int id)
        {
            _commentRepository.Delete(id);
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public void Update(Comment entity)
        {
            _commentRepository.Update(entity);
        }
    }
}
