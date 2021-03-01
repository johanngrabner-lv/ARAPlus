using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using ARAPlus.DatabaseSample;

namespace ARAPlus.BlazorSample.Data
{
  
        public interface INorthwindService
        {
            Task<List<Customer>> GetCustomersAsync();
            Task<Customer> GetCustomerAsync(string id);
            Task<Customer> CreateCustomerAsync(Customer c);
            Task<Customer> UpdateCustomerAsync(Customer c);
            Task DeleteCustomerAsync(string id);
        }
    }

