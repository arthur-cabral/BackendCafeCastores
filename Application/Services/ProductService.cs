using Application.DTOs.Products;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IProductRepository repository)
        {
            this._repository = repository ?? 
                throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<CreateProductDTO>> GetProducts()
        {
            var product = await _repository.GetProducts();
            return _mapper.Map<IEnumerable<CreateProductDTO>>(product);
        }

        public async Task<CreateProductDTO> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CreateProductDTO> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task CreateProduct(CreateProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _repository.CreateProduct(productEntity);
        }

        public async Task UpdateProduct(CreateProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
