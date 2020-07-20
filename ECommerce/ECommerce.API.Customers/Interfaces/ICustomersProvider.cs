using ECommerce.API.Customers.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Customers.Interfaces
{
    public interface ICustomersProvider
    {
        Task<(bool IsSucces, IEnumerable<Models.Customer> Customers, string ErrorMessage)> GetCustomersAsync();
        Task<(bool IsSuccess, Models.Customer Customer, string ErrorMessage)> GetCustomerAsync(int id);
    }
}
