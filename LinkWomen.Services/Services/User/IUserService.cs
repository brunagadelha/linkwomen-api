﻿using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface IUserService
    {
        void Add(User user); 
        void Update(User user); 
        void Delete(User user); 
        User GetById(int id);
        IEnumerable<User> GetHighlightedUsers();
        User VerifyUser(string userName, string password); 
        User GetByEmail(string email); 
        User GetByUsername(string username); 
        User GetByCPF(string cpf); 
    }
}
