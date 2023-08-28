using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await Get().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await GetByProperty((x) => x.Id == id);
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await GetByProperty((x) => x.Name == name);
        }

        public async Task CreateProduct(Product product)
        {
            Add(product);
            await _context.SaveChangesAsync();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
