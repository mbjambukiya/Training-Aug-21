using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;
using Day15_Assignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day15_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empsController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public empsController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("{employeeId}")]
        public IActionResult GetEmployee(long employeeId)
        {
            try
            {
                if (_employeeRepository.GetEmployee(employeeId) != null)
                {
                    return Ok(_employeeRepository.GetEmployee(employeeId));
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

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetEmployees([FromHeader(Name = "arrOfEmployeeId")] long[] arrOfEmployeeId)
        {
            try
            {
                if (_employeeRepository.GetEmployees(arrOfEmployeeId).Any())
                {
                    return Ok(_employeeRepository.GetEmployees(arrOfEmployeeId));
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
        [HttpGet()]
        public IActionResult GetAllEmployees()
        {
            try
            {
                if (_employeeRepository.GetAllEmployees().Any()){
                    return Ok(_employeeRepository.GetAllEmployees());
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

        [HttpPost()]
        public IActionResult PostEmployee(Employee employee)
        {
            try
            {
                if (_employeeRepository.PostEmployee(employee) == true)
                {
                    return Ok(_employeeRepository.PostEmployee(employee));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut()]
        public IActionResult PutEmployee(Employee employee)
        {
            try
            {
                if (_employeeRepository.PutEmployee(employee) == true)
                {
                    return Ok(_employeeRepository.PutEmployee(employee));
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

        [HttpDelete("{empId}")]
        public IActionResult DeleteEmployee(long empId)
        {
            try
            {
                if (_employeeRepository.DeleteEmployee(empId) == true)
                {
                    return Ok(_employeeRepository.DeleteEmployee(empId));
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
