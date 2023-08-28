using Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<CreateProductDTO>> GetProducts();
        Task<CreateProductDTO> GetProductById(int id);
        Task<CreateProductDTO> GetProductByName(string name);
        Task CreateProduct(CreateProductDTO productDTO);
        Task UpdateProduct(CreateProductDTO productDTO);
        Task DeleteProduct(int id);

    }
}
