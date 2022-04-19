using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class CommentRepository : GenericRepository<Comment, SwapDbContext>, ICommentRepository
    {
        public void Create(Comment entity, int? sessionId, string sessionName)
        {
            using (var context = new SwapDbContext())
            {
                entity.Name = sessionName;
                int id = (int)sessionId;
                entity.UserID = id;
                context.Set<Comment>().Add(entity);
                context.SaveChanges();
            }
        }
    }
}
