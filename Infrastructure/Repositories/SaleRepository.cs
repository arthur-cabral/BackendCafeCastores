using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<Sale> CreateSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSale(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetSaleById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sale>> GetSales()
        {
            throw new NotImplementedException();
        }

        public Task<Sale> UpdateSale(int id, Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
