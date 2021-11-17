using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Practice.Models;
using Day14_Practice.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day14_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;
        public DemoController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        //get

        [HttpGet()]
        public IActionResult GetCityList()
        {
            try
            {
                return Ok(_cityRepository.GetCityList());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{cityId}")]
        public IActionResult GetCity(int cityId)
        {
            try
            {
                return Ok(_cityRepository.GetCity(cityId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        //post
        [HttpPost()]
        public IActionResult PostCity(City city)
        {
            try
            {
                return Ok(_cityRepository.PostCity(city));
            }
            catch (Exception)
            {
                throw;
            }
        }

        //put
        [HttpPut()]
        public IActionResult PutCity(City city)
        {
            try
            {
                _cityRepository.PutCity(city);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //delete

        [HttpDelete("{cityId}")]
        public IActionResult DeleteCity(int cityId)
        {
            try
            {
                _cityRepository.DeleteCity(cityId);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }


        ////get method

        //[HttpGet()]
        //public IActionResult GetCity()
        //{
        //    ArrayList citylist = new ArrayList();

        //    using (var context = new testContext())
        //    {
        //        var obj = context.City.ToList();
        //        foreach (var item in obj)
        //        {
        //            citylist.Add(item);
        //        }
        //    }

        //    return Ok(citylist);

        //}

        //[HttpGet("{id}")]
        //public IActionResult GetCityById(int id)
        //{
        //    ArrayList citylist1 = new ArrayList();

        //    using (var context = new testContext())
        //    {
        //        var obj = context.City.Where(c => c.StateId == id).ToList();
        //        foreach (var item in obj)
        //        {
        //            citylist1.Add(item);
        //        }
        //    }

        //    return Ok(citylist1);

        //}

        ////post method

        //[HttpPost]
        //public IActionResult PostNewCity(City city)
        //{
        //    using (var context = new testContext())
        //    {
        //        context.City.Add(new City()
        //        {
        //            CityName = city.CityName,
        //            StateId = city.StateId
        //        });

        //        context.SaveChanges();
        //    }
        //    return Ok();
        //}

        ////put method
        //[HttpPut]
        //public IActionResult PutCity(City newcity)
        //{
        //    using (var context = new testContext())
        //    {
        //        var oldcity = context.City.Find(newcity.CityId);
        //        if (oldcity != null)
        //        {
        //            oldcity.CityName = newcity.CityName;
        //            oldcity.StateId = newcity.StateId;

        //            context.SaveChanges();
        //            return Ok();

        //        }
        //        else
        //        {
        //            return NotFound();
        //        }

        //    }

        //}
        ////delete method
        //[HttpDelete]
        //public IActionResult DeleteCity(int cityid)
        //{
        //    using (var context = new testContext())
        //    {
        //        var city = context.City.Find(cityid);
        //        if (city != null)
        //        {
        //            city.IsDeleted = true;
        //            context.SaveChanges();
        //            return Ok();
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }

        //    }
        //}

    }
}
