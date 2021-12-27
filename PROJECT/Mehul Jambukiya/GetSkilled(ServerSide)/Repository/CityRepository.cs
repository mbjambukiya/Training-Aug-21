using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class CityRepository : GenericRepository<City>, ICity
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public CityRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public CityDto GetCityById(int id)
        {
            var city = GetDataById(id);
            if (city.IsDeleted == false)
            {
                var cityDto = _mapper.Map<CityDto>(city);
                var state = context.States.Find(city.StateId);
                cityDto.StateName = state.StateName;
                return cityDto;
            }
            else
            {
                return null;
            }
        }
        public IList<CityDto> GetCityList()
        {
            var citylist = GetAllData();
            var cityDtoList = new List<CityDto>();
            foreach (var city in citylist)
            {
                if (city.IsDeleted == false)
                {
                    var cityDto = _mapper.Map<CityDto>(city);
                    var state = context.States.Find(city.StateId);
                    cityDto.StateName = state.StateName;
                    cityDtoList.Add(cityDto);
                }
            }

            return cityDtoList;
        }
        public override bool DeleteData(int cityId)
        {
            var city = context.Cities.Find(cityId);
            if (city != null && city.IsDeleted == false)
            {
                city.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}