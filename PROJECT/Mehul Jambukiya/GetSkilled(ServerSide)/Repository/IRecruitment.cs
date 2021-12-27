using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IRecruitment : IGeneric<Recruitment>
    {
        RecruitmentDto GetRecruitmentById(int id);
        IList<RecruitmentDto> GetRecruitmentList();
    }
}