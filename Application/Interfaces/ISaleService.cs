using Application.DTOs.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISaleService
    {
        Task<IEnumerable<SaleDTO>> GetSales();
        Task<SaleDTO> GetSaleById(int id);
        Task<SaleDTO> CreateSale(SaleDTO sale);
        Task<SaleDTO> UpdateSale(SaleDTO sale);
        Task DeleteSale(int id);
    }
}
