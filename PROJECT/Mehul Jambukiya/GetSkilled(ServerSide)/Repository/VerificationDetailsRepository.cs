using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class VerificationDetailsRepository : GenericRepository<VerificationDetail>, IVerificationDetails
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public VerificationDetailsRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }
        public VerificationDto GetVerificationById(int id)
        {
            var verification = GetDataById(id);
            if (verification.IsDeleted == false)
            {
                var verificationDto = _mapper.Map<VerificationDto>(verification);
                var faculty = context.Faculties.Find(verification.FacultyId);
                var document = context.Documents.Find(verification.DocumentId);
                verificationDto.FacultyName = faculty.FirstName + faculty.LastName;
                verificationDto.DocumentName = document.DocumentName;
                return verificationDto;
            }
            else
            {
                return null;
            }
        }
        public IList<VerificationDto> GetVerificationList()
        {
            var verificationlist = GetAllData();
            var verificationDtoList = new List<VerificationDto>();
            foreach (var verification in verificationlist)
            {
                if (verification.IsDeleted == false)
                {
                    var verificationDto = _mapper.Map<VerificationDto>(verification);
                    var faculty = context.Faculties.Find(verification.FacultyId);
                    var document = context.Documents.Find(verification.DocumentId);
                    verificationDto.FacultyName = faculty.FirstName + faculty.LastName;
                    verificationDto.DocumentName = document.DocumentName;
                    verificationDtoList.Add(verificationDto);
                }
            }
            return verificationDtoList;
        }
        public override bool DeleteData(int verificationId)
        {
            var verification = context.VerificationDetails.Find(verificationId);
            if (verification != null && verification.IsDeleted == false)
            {
                verification.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
