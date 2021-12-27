using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IFaculty:IGeneric<Faculty>
    {
        FacultyDto GetFacultyById(int id);
        IList<FacultyDto> GetFacultyList();
        bool MarkAsVerified(int facultyId);
    }
}
