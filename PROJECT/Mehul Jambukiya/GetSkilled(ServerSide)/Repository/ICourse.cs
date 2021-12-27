using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface ICourse : IGeneric<Course>
    {
        CourseDto GetCourseById(int id);
        IList<CourseDto> GetCourseList();
    }
}
