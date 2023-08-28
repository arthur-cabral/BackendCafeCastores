using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale
    {
        public Sale() { 
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public DateTime DateSale { get; private set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
