using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository; 
        }

        public void Add(User user)
        {
            user.CreatedAt = DateTime.Now; 
            _userRepository.Add(user); 
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
