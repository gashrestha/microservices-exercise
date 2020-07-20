using ECommerce.API.Products.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Products.Interfaces
{
    public interface IProductsProvider
    {
        Task<(bool IsSucces, IEnumerable<Models.Product> Products, string ErrorMessage)> GetProductsAsync();
        Task<(bool IsSuccess, Models.Product Product, string ErrorMessage)> GetProductAsync(int id);

    }
}
