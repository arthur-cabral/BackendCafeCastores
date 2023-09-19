using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Users
{
    public class CreateUserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is mandatory!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email is mandatory!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Cpf is mandatory!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "The password is mandatory!")]
        public string Password { get; set; }
    }
}
