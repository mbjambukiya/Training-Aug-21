using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IInterviewer : IGeneric<Interviewer>
    {
        InterviewerDto GetInterviewerById(int id);
        IList<InterviewerDto> GetInterviewerList();
    }
}
