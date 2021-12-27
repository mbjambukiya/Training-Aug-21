using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class ApplicantFacultyRepository:GenericRepository<ApplicantFaculty>, IApplicantFaculty
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;
        public ApplicantFacultyRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }
        public ApplicantFacultyDto GetApplicantFacultyById(int id)
        {
            var apFaculty = GetDataById(id);
            if (apFaculty.IsDeleted == false)
            {
                var apFacultyDto = _mapper.Map<ApplicantFacultyDto>(apFaculty);
                var faculty = context.Faculties.Find(apFaculty.FacultyId);
                var course = context.Courses.Find(apFaculty.CourseId);
                apFacultyDto.FacultyName = faculty.FirstName + faculty.LastName;
                apFacultyDto.CourseName = course.CourseName;
                return apFacultyDto;
            }
            else
            {
                return null;
            }
        }
        public IList<ApplicantFacultyDto> GetApplicantFacultyList()
        {
            var apFacultylist = GetAllData();
            var apFacultyDtoList = new List<ApplicantFacultyDto>();
            foreach (var apFaculty in apFacultylist)
            {
                if (apFaculty.IsDeleted == false)
                {
                    var apFacultyDto = _mapper.Map<ApplicantFacultyDto>(apFaculty);
                    var faculty = context.Faculties.Find(apFaculty.FacultyId);
                    var course = context.Courses.Find(apFaculty.CourseId);
                    apFacultyDto.FacultyName = faculty.FirstName + faculty.LastName;
                    apFacultyDto.CourseName = course.CourseName;
                    apFacultyDtoList.Add(apFacultyDto);
                }
            }
            return apFacultyDtoList;
        }
        public override bool DeleteData(int apFacultyId)
        {
            var apFaculty = context.ApplicantFaculties.Find(apFacultyId);
            if (apFaculty != null && apFaculty.IsDeleted == false)
            {
                apFaculty.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
