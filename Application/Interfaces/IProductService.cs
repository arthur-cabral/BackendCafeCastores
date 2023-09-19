using Application.DTOs.Products;
using Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDTO>> GetProducts();
        Task<GetProductDTO> GetProductById(int id);
        Task<GetProductDTO> GetProductByName(string name);
        Task<MessageResponseDTO> CreateProduct(CreateProductDTO productDTO);
        Task<MessageResponseDTO> UpdateProduct(int id, CreateProductDTO productDTO);
        Task<MessageResponseDTO> DeleteProduct(int id);

    }
}
