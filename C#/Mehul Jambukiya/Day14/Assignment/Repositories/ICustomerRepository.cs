using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customers> GetCustomers();
        Customers GetCustomer(int customerId);
        Customers PostCustomer(Customers customer);
        bool PutCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
