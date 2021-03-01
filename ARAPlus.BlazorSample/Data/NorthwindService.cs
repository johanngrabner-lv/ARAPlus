using ARAPlus.DatabaseSample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ARAPlus.BlazorSample.Data
{
    public class NorthwindService: INorthwindService
    {
        private readonly NorthwindContext db;
        public NorthwindService(NorthwindContext db)
        {
            this.db = db;
        }
        public Task<List<Customer>> GetCustomersAsync()
        {
            return db.Customers.ToListAsync();
        }
        public Task<Customer> GetCustomerAsync(string id)
        {
            return db.Customers.FirstOrDefaultAsync
              (c => c.CustomerId == id);
        }
        public Task<Customer> CreateCustomerAsync(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChangesAsync();
            return Task.FromResult<Customer>(c);
        }
        public Task<Customer> UpdateCustomerAsync(Customer c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChangesAsync();
            return Task.FromResult<Customer>(c);
        }
        public Task DeleteCustomerAsync(string id)
        {
            Customer customer = db.Customers.FirstOrDefaultAsync
              (c => c.CustomerId == id).Result;
            db.Customers.Remove(customer);
            return db.SaveChangesAsync();
        }
    }
}
