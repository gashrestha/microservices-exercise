using Asp.Versioning;
using ECommerce.API.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Customers.Controllers
{
    [ApiVersion(1, Deprecated = true)]
    [ApiVersion(2)]
    [Route("api/v{v:apiVersion}/customers")]
    [ApiController]
    public class CustomersController(ICustomersProvider customersProvider) : ControllerBase
    {
        private readonly ICustomersProvider customersProvider = customersProvider;

        [MapToApiVersion(1)]
        [HttpGet]
        public async Task<IActionResult> GetCustomersAsync()
        {
            var result = await customersProvider.GetCustomersAsync();
            if (result.IsSucces)
            {
                return Ok(result.Customers);
            }
            return NotFound();
        }

        [MapToApiVersion(2)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerAsync(int id)
        {
            var result = await customersProvider.GetCustomerAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result.Customer);
            }
            return NotFound();
        }

    }
}
