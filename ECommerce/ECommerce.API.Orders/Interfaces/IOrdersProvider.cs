﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Orders.Interfaces
{
    public interface IOrdersProvider
    {
        Task<(bool IsSucces, IEnumerable<Models.Order> Orders, string ErrorMessage)> GetOrdersAsync();
        Task<(bool IsSuccess, IEnumerable<Models.Order> Orders, string ErrorMessage)> GetOrdersAsync(int customerId);
    }
}
