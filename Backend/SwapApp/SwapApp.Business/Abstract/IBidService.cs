using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface IBidService
    {
        List<Bid> GetAll();

        Bid GetById(int id);

        void Create(Bid entity);

        void Update(Bid entity);

        void Delete(int id);
    }
}
