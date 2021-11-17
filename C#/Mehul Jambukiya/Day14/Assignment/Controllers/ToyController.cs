using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day14_Assignmnt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToyController : ControllerBase
    {
        private readonly IToyRepository _toyRepository;
        public ToyController(IToyRepository toyRepository)
        {
            _toyRepository = toyRepository;
        }
        //get method
        [HttpGet()]
        public IActionResult GetToys()
        {
            try
            {
                if (_toyRepository.GetToys() != null)
                {
                    return Ok(_toyRepository.GetToys());
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

        [HttpGet("{toyId}")]
        public IActionResult GetToy(int toyId)
        {
            try
            {
                if (_toyRepository.GetToy(toyId) != null)
                {
                    return Ok(_toyRepository.GetToy(toyId));
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
