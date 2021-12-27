using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IInterviewResult : IGeneric<InterviewResult>
    {
        InterviewResultDto GetResultById(int id);
        IList<InterviewResultDto> GetResultList();
    }
}
