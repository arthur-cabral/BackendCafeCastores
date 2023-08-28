using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        Task<Sale> ISaleRepository.CreateSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        Task ISaleRepository.DeleteSale(int id)
        {
            throw new NotImplementedException();
        }

        Task<Sale> ISaleRepository.GetSaleById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Sale>> ISaleRepository.GetSales()
        {
            throw new NotImplementedException();
        }

        Task<Sale> ISaleRepository.UpdateSale(int id, Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
