using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class ForumIssue : Entity
    {
        public ForumIssue()
        {
            Comments = new List<ForumComment>(); 
        }

        public ForumTypeEnum ForumType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPinned { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public ForumCategory Category { get; set; }

        public bool Deleted { get; set; }

        public IEnumerable<ForumComment> Comments { get; set; }
    }
}
