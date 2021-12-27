using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class InterviewResultRepository : GenericRepository<InterviewResult>, IInterviewResult
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;
        public InterviewResultRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public override bool CreateData(InterviewResult entity)
        {
            if (base.CreateData(entity))
            {
                SaveData();
                var interview = context.Interviews.Find(entity.InterviewId);
                var recruitment = context.Recruitments.Find(interview.RecruitmentId);
                var course = context.Courses.Find(recruitment.CourseId);
                var faculty = context.ApplicantFaculties.Where(f=>f.FacultyId==entity.FacultyId).FirstOrDefault();
                faculty.IsSelected = true;
                course.FacultyId = faculty.FacultyId;
                return true;
            }
            else
            {
                return false;
            }
        }

        public InterviewResultDto GetResultById(int id)
        {
            var result = GetDataById(id);
            if (result.IsDeleted == false)
            {
                var resultDto = _mapper.Map<InterviewResultDto>(result);
                var faculty = context.Faculties.Find(result.FacultyId);
                resultDto.FacultyName = faculty.FirstName + faculty.LastName;
                return resultDto;
            }
            else
            {
                return null;
            }
        }
        public IList<InterviewResultDto> GetResultList()
        {
            var resultlist = GetAllData();
            var resultDtoList = new List<InterviewResultDto>();
            foreach (var result in resultlist)
            {
                if (result.IsDeleted == false)
                {
                    var resultDto = _mapper.Map<InterviewResultDto>(result);
                    var faculty = context.Faculties.Find(result.FacultyId);
                    resultDto.FacultyName = faculty.FirstName + faculty.LastName;
                    resultDtoList.Add(resultDto);
                }
            }
            return resultDtoList;
        }
        public override bool DeleteData(int resultId)
        {
            var result = context.InterviewResults.Find(resultId);
            if (result != null && result.IsDeleted == false)
            {
                result.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
