using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinkWomen.Domain.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Usuário obrigatório")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        public string Password { get; set; }
    }
}
