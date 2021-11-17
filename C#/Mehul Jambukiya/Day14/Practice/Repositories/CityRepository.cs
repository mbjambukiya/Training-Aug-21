using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Practice.Models;

namespace Day14_Practice.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly testContext _context;
        public CityRepository(testContext context)
        {
            _context = context;
        }
        public void DeleteCity(int cityId)
        {
            var city = _context.City.Find(cityId);
            city.IsDeleted = true;
            _context.SaveChanges();
        }
        public City GetCity(int cityId)
        {
            var city = _context.City.Find(cityId);
            return city;
        }
        public IEnumerable<City> GetCityList()
        {
            return _context.City.ToList();
        }
        public IEnumerable<City> GetCityListByState(int stateId)
        {
            var citylist = _context.City.Where(s=>s.StateId==stateId).ToList();
            return citylist;
        }
        public City PostCity(City city)
        {
            var result = _context.City.Add(city);
            _context.SaveChanges();
            return result.Entity;
        }
        public void PutCity(City city)
        {
            var oldcity = _context.City.Find(city.CityId);
            oldcity.CityName = city.CityName;
            oldcity.StateId = city.StateId;
            _context.SaveChanges();
        }
    }
}
