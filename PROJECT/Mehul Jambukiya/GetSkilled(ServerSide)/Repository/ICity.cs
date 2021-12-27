using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface ICity : IGeneric<City>
    {
        CityDto GetCityById(int id);
        IList<CityDto> GetCityList();
    }
}
