using Application.DTOs.Products;
using Application.DTOs.Response;
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
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetProductDTO>> GetProducts()
        {
            var productEntity = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<GetProductDTO>>(productEntity);
        }

        public async Task<GetProductDTO> GetProductById(int id)
        {
            var productEntity = await _productRepository.GetProductById(id);
            return _mapper.Map<GetProductDTO>(productEntity);
        }

        public async Task<GetProductDTO> GetProductByName(string name)
        {
            var productEntity = await _productRepository.GetProductByName(name);
            return _mapper.Map<GetProductDTO>(productEntity);
        }

        public async Task<MessageResponseDTO> CreateProduct(CreateProductDTO productDTO)
        {
            try
            {
                var productEntity = _mapper.Map<Product>(productDTO);
                await _productRepository.CreateProduct(productEntity);

                return new MessageResponseDTO("Criado com sucesso", true);
            } catch (Exception ex)
            {   
                return new MessageResponseDTO(ex.Message, false);
            }
        }

        public async Task<MessageResponseDTO> UpdateProduct(int id, CreateProductDTO productDTO)
        {
            bool productExists = await _productRepository.ExistsProduct(id);
            if (!productExists)
            {
                return new MessageResponseDTO("O produto não existe", false);
            }
            try
            {
                var productEntity = _mapper.Map<Product>(productDTO);
                productEntity.Id = id;
                await _productRepository.UpdateProduct(productEntity);

                return new MessageResponseDTO("Atualizado com sucesso", true);
            } catch (Exception ex)
            {
                return new MessageResponseDTO(ex.Message, false);
            }
        }

        public async Task<MessageResponseDTO> DeleteProduct(int id)
        {
            bool productExists = await _productRepository.ExistsProduct(id);
            if (!productExists)
            {
                return new MessageResponseDTO("O produto não existe", false);
            }
            try
            {
                await _productRepository.DeleteProduct(id);
                return new MessageResponseDTO("Deletado com sucesso", true);
            }
            catch (Exception ex)
            {
                return new MessageResponseDTO(ex.Message, false);
            }
        }

        
    }
}
