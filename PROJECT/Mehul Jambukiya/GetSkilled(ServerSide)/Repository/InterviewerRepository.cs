using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class InterviewerRepository : GenericRepository<Interviewer>, IInterviewer
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;
        public InterviewerRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public InterviewerDto GetInterviewerById(int id)
        {
            var interviewer = GetDataById(id);
            if (interviewer.IsDeleted == false)
            {
                var interviewerDto = _mapper.Map<InterviewerDto>(interviewer);
                var gender = context.Gender.Find(interviewer.GenderId);
                var city = context.Cities.Find(interviewer.CityId);
                interviewerDto.GenderName = gender.GenderName;
                interviewerDto.CityName = city.CityName;
                return interviewerDto;
            }
            else
            {
                return null;
            }
        }
        public IList<InterviewerDto> GetInterviewerList()
        {
            var interviewerList = GetAllData();
            var interviewerDtoList = new List<InterviewerDto>();
            foreach (var interviewer in interviewerList)
            {
                if (interviewer.IsDeleted == false)
                {
                    var interviewerDto = _mapper.Map<InterviewerDto>(interviewer);
                    var gender = context.Gender.Find(interviewer.GenderId);
                    var city = context.Cities.Find(interviewer.CityId);
                    interviewerDto.GenderName = gender.GenderName;
                    interviewerDto.CityName = city.CityName;
                    interviewerDtoList.Add(interviewerDto);
                }
            }
            return interviewerDtoList;
        }
        public override bool DeleteData(int interviewerId)
        {
            var interviewer = context.Interviewers.Find(interviewerId);
            if (interviewer != null && interviewer.IsDeleted == false)
            {
                interviewer.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
