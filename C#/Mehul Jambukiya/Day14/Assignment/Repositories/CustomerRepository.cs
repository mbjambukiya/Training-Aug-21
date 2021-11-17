using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ToyCompanyDbContext _context;
        public CustomerRepository(ToyCompanyDbContext context)
        {
            _context = context;
        }
        public bool DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if(customer != null)
            {
                customer.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customers GetCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            return customer;
        }
        public IEnumerable<Customers> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        public Customers PostCustomer(Customers customer)
        {
            var result = _context.Customers.Add(customer);
            _context.SaveChanges();
            return result.Entity;
        }
        public bool PutCustomer(Customers customer)
        {
            var oldcustomer = _context.Customers.Find(customer.CustomerId);
            if(oldcustomer != null)
            {
                oldcustomer.FirstName = customer.FirstName;
                oldcustomer.LastName = customer.LastName;
                oldcustomer.PhoneNumber = customer.PhoneNumber;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
