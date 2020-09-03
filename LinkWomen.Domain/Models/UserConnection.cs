using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.Models
{
    public class UserConnection : Entity
    {
        public int UserHostId { get; set; }
        public User UserHost { get; set; }
        public int UserGuestId { get; set; }
        public User UserGuest { get; set; }
    }
}
