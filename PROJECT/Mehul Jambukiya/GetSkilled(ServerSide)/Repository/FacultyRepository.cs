using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class FacultyRepository : GenericRepository<Faculty>, IFaculty
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public FacultyRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public FacultyDto GetFacultyById(int id)
        {
            var faculty = GetDataById(id);
            if (faculty.IsDeleted == false)
            {
                var facultyDto = _mapper.Map<FacultyDto>(faculty);
                var gender = context.Gender.Find(faculty.GenderId);
                var city = context.Cities.Find(faculty.CityId);
                facultyDto.GenderName = gender.GenderName;
                facultyDto.CityName = city.CityName;
                return facultyDto;
            }
            else
            {
                return null;
            }
        }
        public IList<FacultyDto> GetFacultyList()
        {
            var facultylist = GetAllData();
            var facultyDtoList = new List<FacultyDto>();
            foreach (var faculty in facultylist)
            {
                if (faculty.IsDeleted == false)
                {
                    var facultyDto = _mapper.Map<FacultyDto>(faculty);
                    var gender = context.Gender.Find(faculty.GenderId);
                    var city = context.Cities.Find(faculty.CityId);
                    facultyDto.GenderName = gender.GenderName;
                    facultyDto.CityName = city.CityName;
                    facultyDtoList.Add(facultyDto);
                }
            }
            return facultyDtoList;
        }
        public override bool DeleteData(int facultyId)
        {
            var faculty = context.Faculties.Find(facultyId);
            if (faculty != null && faculty.IsDeleted == false)
            {
                faculty.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MarkAsVerified(int facultyId)
        {
            var faculty = context.Faculties.Find(facultyId);
            if (faculty.IsVarified == false)
            {
                var documents = context.Documents.ToList();
                var verificationData = context.VerificationDetails.Where(v => v.FacultyId == facultyId);
                bool verificationStatus = false;
                foreach (var document in documents)
                {
                    foreach (var v in verificationData)
                    {
                        if (v.DocumentId == document.Id)
                        {
                            if (v.IsVerified == true)
                            {
                                verificationStatus = true;
                            }
                            else
                            {
                                verificationStatus = false;
                                break;
                            }
                        }
                    }
                }
                if (verificationStatus == true)
                {
                    faculty.IsVarified = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
