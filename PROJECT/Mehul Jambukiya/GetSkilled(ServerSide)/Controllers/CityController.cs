using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;
using GetSkilled.Models;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetSkilled.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = UserRoles.Admin)]
    public class CityController : ControllerBase
    {
        private readonly ICity _city;
        public CityController(ICity city)
        {
            _city = city;
        }

        [HttpGet]
        public IActionResult GetCityList()
        {
            try
            {
                var result = _city.GetCityList();
                if (result.Any())
                {
                    return Ok(result);
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

        [HttpGet("{cityId}")]
        public IActionResult GetCityById(int cityId)
        {
            try
            {
                var result = _city.GetCityById(cityId);

                if (result != null)
                {
                    return Ok(result);
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

        [HttpPost]
        public IActionResult AddCity(City city)
        {
            try
            {
                var result = _city.CreateData(city);
                if (result == true)
                {
                    _city.SaveData();
                    return Ok(result);
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
        public IActionResult UpdateCity(City city)
        {
            try
            {
                var result = _city.UpdateData(city);
                if (result == true)
                {
                    _city.SaveData();
                    return Ok(result);
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

        [HttpDelete("{cityId}")]
        public IActionResult DeleteCity(int cityId)
        {
            try
            {
                var result = _city.DeleteData(cityId);
                if (result == true)
                {
                    _city.SaveData();
                    return Ok(result);
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
