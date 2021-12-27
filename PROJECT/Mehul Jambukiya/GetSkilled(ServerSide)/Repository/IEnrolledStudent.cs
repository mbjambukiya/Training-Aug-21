using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IEnrolledStudent : IGeneric<EnrolledStudent>
    {
        EnrolledStudentDto GetEnrolledStudentById(int id);
        IList<EnrolledStudentDto> GetEnrolledStudentsList();
    }
}