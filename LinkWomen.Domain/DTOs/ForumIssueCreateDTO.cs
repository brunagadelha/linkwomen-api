using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class ForumIssueCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int? CategoryId { get; set; }
    }
}
