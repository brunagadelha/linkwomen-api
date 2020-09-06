using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class ForumCommentDTO
    {
        public string Content { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }

        public string CreatedAt { get; set; }

    }
}
