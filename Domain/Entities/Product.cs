using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public Product() { 
            this.Sales = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public string Name { get; private set; }
        public float Price { get; private set; }
        public int Stock { get; private set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
