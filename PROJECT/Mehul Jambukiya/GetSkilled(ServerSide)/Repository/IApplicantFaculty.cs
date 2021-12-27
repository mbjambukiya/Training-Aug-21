using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;


namespace GetSkilled.Repository
{
    public interface IApplicantFaculty : IGeneric<ApplicantFaculty>
    {
        ApplicantFacultyDto GetApplicantFacultyById(int id);
        IList<ApplicantFacultyDto> GetApplicantFacultyList();
    }
}
