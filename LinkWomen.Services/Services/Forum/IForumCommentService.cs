using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface IForumCommentService
    {
        void Add(ForumComment comment);
        void Update(ForumComment comment);
        void Delete(ForumComment comment);
        ForumComment GetById(int id); 
    }
}
