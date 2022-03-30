using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();

        Comment GetById(int id);

        void Create(Comment entity);

        void Update(Comment entity);

        void Delete(int id);
    }
}
