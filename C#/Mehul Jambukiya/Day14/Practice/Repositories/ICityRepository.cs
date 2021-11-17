using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Practice.Models;

namespace Day14_Practice.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCityList();
        City GetCity(int cityId);
        IEnumerable<City> GetCityListByState(int stateId);
        City PostCity(City city);
        void PutCity(City city);
        void DeleteCity(int cityId);
    }
}
