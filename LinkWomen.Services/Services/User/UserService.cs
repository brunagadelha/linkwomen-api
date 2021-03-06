﻿using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            user.UserRole = Domain.Enumerators.UserRoleEnum.Comum; 
            user.CreatedAt = DateTime.Now; 

            _userRepository.Add(user); 
        }

        public void Delete(User user)
        {
            user.Deleted = true;
            _userRepository.Update(user); 
        }

        public User GetByCPF(string cpf)
        {
            return _userRepository.GetAll().Where(x => x.CPF.Equals(cpf)).FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _userRepository.GetAll().Where(x => x.Email.Equals(email)).FirstOrDefault();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetByUsername(string username)
        {
            return _userRepository.GetAll().Where(x => x.UserName.Equals(username)).FirstOrDefault(); 
        }

        public IEnumerable<User> GetHighlightedUsers()
        {
            return _userRepository.GetAll().Where(x => x.IsHighlighted).AsEnumerable();                                                    
        }

        public void Update(User user)
        {
            user.UpdatedAt = DateTime.Now;
            _userRepository.Update(user); 
        }

        public User VerifyUser(string userName, string password)
        {
            var user = _userRepository.GetAll()
                            .Where(x => x.UserName.Equals(userName) && x.PasswordHash.Equals(password)).FirstOrDefault();

            return user; 
        }
    }
}
