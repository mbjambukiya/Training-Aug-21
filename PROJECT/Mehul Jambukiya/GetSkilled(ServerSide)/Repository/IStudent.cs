using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IStudent : IGeneric<Student>
    {
        StudentDto GetStudentById(int id);
        IList<StudentDto> GetStudentList();
    }
}
