using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class Event : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
