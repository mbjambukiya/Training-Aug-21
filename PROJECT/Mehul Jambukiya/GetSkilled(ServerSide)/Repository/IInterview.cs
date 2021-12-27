using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IInterview : IGeneric<Interview>
    {
        InterviewDto GetInterviewById(int id);
        IList<InterviewDto> GetInterviewList();
    }
}
