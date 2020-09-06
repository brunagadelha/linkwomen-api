using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class ForumCommentService : IForumCommentService
    {
        private readonly IGenericRepository<ForumComment> _forumCommentRepository;

        public ForumCommentService(IGenericRepository<ForumComment> forumCommentRepository)
        {
            _forumCommentRepository = forumCommentRepository; 
        }

        public void Add(ForumComment comment)
        {
            comment.CreatedAt = DateTime.Now;
            _forumCommentRepository.Add(comment); 
        }

        public void Delete(ForumComment comment)
        {
            comment.Deleted = true; 
            _forumCommentRepository.Update(comment);
        }

        public ForumComment GetById(int id)
        {
            return _forumCommentRepository.GetById(id); 
        }

        public void Update(ForumComment comment)
        {
            comment.UpdatedAt = DateTime.Now;
            _forumCommentRepository.Update(comment);
        }
    }
}
