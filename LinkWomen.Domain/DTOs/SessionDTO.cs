using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class SessionDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
