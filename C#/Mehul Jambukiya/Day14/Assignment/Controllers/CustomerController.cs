using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;
using Day14_Assignmnt.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day14_Assignmnt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //get method
        [HttpGet()]
        public IActionResult GetCustomers()
        {
            try
            {
                if (_customerRepository.GetCustomers() != null)
                {
                    return Ok(_customerRepository.GetCustomers());
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{customerId}")]
        public IActionResult GetCustomer(int customerId)
        {
            try
            {
                if (_customerRepository.GetCustomer(customerId) != null)
                {
                    return Ok(_customerRepository.GetCustomer(customerId));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //post method

        [HttpPost()]
        public IActionResult PostCustomer(Customers customer)
        {
            try
            {
                return Ok(_customerRepository.PostCustomer(customer));
            }
            catch (Exception)
            {
                throw;
            }
        }


        //put method

        [HttpPut()]
        public IActionResult PutCustomer(Customers customer)
        {
            try
            {
                if (_customerRepository.PutCustomer(customer)==true)
                {
                    _customerRepository.PutCustomer(customer);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //delete method

        [HttpDelete("{customerId}")]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                if (_customerRepository.DeleteCustomer(customerId) == true)
                {
                    _customerRepository.DeleteCustomer(customerId);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
