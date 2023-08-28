using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Products
{
    public class CreateProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is mandatory!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The price is mandatory!")]
        public float Price { get; set; }

    }
}
