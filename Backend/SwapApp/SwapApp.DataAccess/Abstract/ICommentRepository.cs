using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Abstract
{
    public interface ICommentRepository : IRepository<Comment>
    {
        void Create(Comment entity, int? sessiınId, string sessionName);
    }
}
