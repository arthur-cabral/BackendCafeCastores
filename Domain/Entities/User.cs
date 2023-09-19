using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Password { get; private set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
