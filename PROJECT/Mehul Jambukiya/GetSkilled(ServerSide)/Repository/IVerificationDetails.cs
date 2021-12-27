using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public interface IVerificationDetails : IGeneric<VerificationDetail>
    {
        IList<VerificationDto> GetVerificationList();
        VerificationDto GetVerificationById(int id);
    }
}