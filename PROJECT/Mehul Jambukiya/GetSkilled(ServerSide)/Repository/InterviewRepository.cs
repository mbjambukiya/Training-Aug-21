using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class InterviewRepository : GenericRepository<Interview>, IInterview
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public InterviewRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public override bool CreateData(Interview entity)
        {
            if (base.CreateData(entity))
            {
                SaveData();
                var recruitment = context.Recruitments.Find(entity.RecruitmentId);
                var course = context.Courses.Find(recruitment.CourseId);
                var applicantFaculty = context.ApplicantFaculties.Where(c => c.CourseId == course.Id);
                foreach (var i in applicantFaculty)
                {
                    i.InterviewId = entity.Id;
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        public InterviewDto GetInterviewById(int id)
        {
            var interview = GetDataById(id);
            if (interview.IsDeleted == false)
            {
                var interviewDto = _mapper.Map<InterviewDto>(interview);
                var interviewer = context.Interviewers.Find(interview.InterviewerId);
                interviewDto.InterviewerName = interviewer.FirstName + interviewer.LastName;
                return interviewDto;
            }
            else
            {
                return null;
            }
        }
        public IList<InterviewDto> GetInterviewList()
        {
            var interviewlist = GetAllData();
            var interviewDtoList = new List<InterviewDto>();
            foreach (var interview in interviewlist)
            {
                if (interview.IsDeleted == false)
                {
                    var interviewDto = _mapper.Map<InterviewDto>(interview);
                    var interviewer = context.Interviewers.Find(interview.InterviewerId);
                    interviewDto.InterviewerName = interviewer.FirstName + interviewer.LastName;
                    interviewDtoList.Add(interviewDto);
                }
            }
            return interviewDtoList;
        }
        public override bool DeleteData(int interviewId)
        {
            var interview = context.Interviews.Find(interviewId);
            if (interview != null && interview.IsDeleted == false)
            {
                interview.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
