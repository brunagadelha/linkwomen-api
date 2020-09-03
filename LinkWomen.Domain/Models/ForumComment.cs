using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class ForumComment : Entity
    {
        public int ForumIssueId { get; set; }
        public ForumIssue ForumIssue { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
