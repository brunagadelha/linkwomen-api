using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class ForumIssueService : IForumIssueService
    {
        private readonly IGenericRepository<ForumIssue> _forumIssueRepository;

        public ForumIssueService(IGenericRepository<ForumIssue> forumIssueRepository)
        {
            _forumIssueRepository = forumIssueRepository;
        }

        public void Add(ForumIssue issue)
        {
            issue.CreatedAt = DateTime.Now;            

            _forumIssueRepository.Add(issue);
        }
        public void Update(ForumIssue issue)
        {
            _forumIssueRepository.Update(issue);
        }

        public void Delete(ForumIssue issue)
        {
            issue.Deleted = true;
            _forumIssueRepository.Update(issue);
        }

        public IEnumerable<ForumIssue> GetAll(int categoryId = 0, bool isPinned = false)
        {
            var query = _forumIssueRepository.GetAll()
                                .Include(x => x.Comments)
                                .Include(x => x.User)
                                .Where(x => !x.Deleted &&
                                            x.IsPinned == isPinned &&
                                            (categoryId > 0 ? x.CategoryId == categoryId : true));

            return query.AsEnumerable();
        }

        public ForumIssue GetById(int id)
        {
            return _forumIssueRepository.GetAll()
                        .Include(x => x.User)
                        .Include(x => x.Comments)
                        .ThenInclude(comm => comm.User)
                    .Where(x => x.Id == id).FirstOrDefault();
        }


    }
}
