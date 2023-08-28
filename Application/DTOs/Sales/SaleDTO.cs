using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Sales
{
    public class SaleDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The products list cannot be empty")]
        public ICollection<Product> Products { get; set; }
    }
}
