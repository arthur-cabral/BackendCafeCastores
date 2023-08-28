using Application.DTOs.Sales;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SaleService : ISaleService
    {
        Task<SaleDTO> ISaleService.CreateSale(SaleDTO sale)
        {
            throw new NotImplementedException();
        }

        Task ISaleService.DeleteSale(int id)
        {
            throw new NotImplementedException();
        }

        Task<SaleDTO> ISaleService.GetSaleById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<SaleDTO>> ISaleService.GetSales()
        {
            throw new NotImplementedException();
        }

        Task<SaleDTO> ISaleService.UpdateSale(SaleDTO sale)
        {
            throw new NotImplementedException();
        }
    }
}
