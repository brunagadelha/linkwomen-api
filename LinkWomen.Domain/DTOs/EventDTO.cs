using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
    }
}
