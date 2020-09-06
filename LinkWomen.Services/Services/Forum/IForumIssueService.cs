using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface IForumIssueService
    {
        void Add(ForumIssue issue);
        void Update(ForumIssue issue);
        void Delete(ForumIssue issue);
        ForumIssue GetById(int id);
        IEnumerable<ForumIssue> GetAll(int categoryId = 0, bool isPinned = false); 
    }
}
