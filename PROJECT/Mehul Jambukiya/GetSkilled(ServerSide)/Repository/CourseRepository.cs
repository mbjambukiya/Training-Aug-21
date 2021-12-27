using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourse
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public CourseRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public CourseDto GetCourseById(int id)
        {
            var course = GetDataById(id);
            if (course.IsDeleted == false)
            {
            var courseDto = _mapper.Map<CourseDto>(course);
            var category = context.Categories.Find(course.CategoryId);
            var faculty = context.Faculties.Find(course.FacultyId);
            courseDto.CategoryName = category.CategoryName;
            courseDto.FacultyName = faculty.FirstName + faculty.LastName;
            return courseDto;
            }
            else
            {
                return null;
            }
        }
        public IList<CourseDto> GetCourseList()
        {
            var courselist = GetAllData();
            var courseDtoList = new List<CourseDto>();
            foreach (var course in courselist)
            {
                if (course.IsDeleted == false)
                {
                    if (course.FacultyId != null)
                    {
                        var courseDto = _mapper.Map<CourseDto>(course);
                        var category = context.Categories.Find(course.CategoryId);
                        var faculty = context.Faculties.Find(course.FacultyId);
                        courseDto.CategoryName = category.CategoryName;
                        courseDto.FacultyName = faculty.FirstName + faculty.LastName;
                        courseDtoList.Add(courseDto);
                    }
                    else
                    {
                        var courseDto = _mapper.Map<CourseDto>(course);
                        var category = context.Categories.Find(course.CategoryId);
                        courseDto.CategoryName = category.CategoryName;
                        courseDto.FacultyName = "Not Selected";
                        courseDtoList.Add(courseDto);
                    }
                }
            }
            return courseDtoList;
        }
        public override bool DeleteData(int courseId)
        {
            var course = context.Courses.Find(courseId);
            if (course != null && course.IsDeleted == false)
            {
                course.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
