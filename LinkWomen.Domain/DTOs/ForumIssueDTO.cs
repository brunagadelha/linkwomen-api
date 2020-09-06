using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class ForumIssueDTO
    {
        public int Id { get; set; }
        public ForumTypeEnum ForumType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPinned { get; set; }

        public int UserId { get; set; }
        public string User { get; set; }

        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public string CreatedAt { get; set; }

        public IEnumerable<ForumCommentDTO> Comments { get; set; }
    }
}
