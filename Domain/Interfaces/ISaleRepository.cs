using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISaleRepository
    {
        Task<IEnumerable<Sale>> GetSales();
        Task<Sale> GetSaleById(int id);
        Task<Sale> CreateSale(Sale sale);
        Task<Sale> UpdateSale(int id, Sale sale);
        Task DeleteSale(int id);
    }
}
