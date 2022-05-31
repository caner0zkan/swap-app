using SwapApp.Business.Abstract;
using SwapApp.DataAccess.Abstract;
using SwapApp.DataAccess.Concrete;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Concrete
{
    public class UserManager : IUserService
    {

        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User entity)
        {
            _userRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetLoggedIn(int id)
        {
            return _userRepository.GetLoggedIn(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
