using LinkWomen.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "CPF obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username obrigatório")]
        public string Username { get; set; }

        public string GitHub { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        public string Password { get; set; }
    }
}
