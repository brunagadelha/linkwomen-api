using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
        public string UserName { get; set; }
        public string GitHub { get; set; }
        public UserRoleEnum UserRole { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool IsHighlighted { get; set; }
      
    }
}
