using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class UserCreateDTO
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string GitHub { get; set; }
        public string Password { get; set; }
    }
}
