using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class BidManager : IBidService
    {
        private IBidRepository _bidRepository;

        public BidManager(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }

        public void Create(Bid entity)
        {
            _bidRepository.Create(entity);
        }

        public void Delete(Bid entity)
        {
            _bidRepository.Delete(entity);
        }

        public List<Bid> GetAll()
        {
            return _bidRepository.GetAll();
        }

        public Bid GetById(int id)
        {
            return _bidRepository.GetById(id);
        }

        public void Update(Bid entity)
        {
            _bidRepository.Update(entity);
        }
    }
}
