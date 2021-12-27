using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class RecruitmentRepository : GenericRepository<Recruitment>, IRecruitment
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public RecruitmentRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }
        public RecruitmentDto GetRecruitmentById(int id)
        {
            var recruitment = GetDataById(id);
            if (recruitment.IsDeleted == false)
            {
                var recruitmentDto = _mapper.Map<RecruitmentDto>(recruitment);
                var course = context.Courses.Find(recruitment.CourseId);
                recruitmentDto.CourseName = course.CourseName;
                return recruitmentDto;
            }
            else
            {
                return null;
            }
        }
        public IList<RecruitmentDto> GetRecruitmentList()
        {
            var recruitmentlist = GetAllData();
            var recruitmentDtoList = new List<RecruitmentDto>();
            foreach (var recruitment in recruitmentlist)
            {
                if (recruitment.IsDeleted == false)
                {
                    var recruitmentDto = _mapper.Map<RecruitmentDto>(recruitment);
                    var course = context.Courses.Find(recruitment.CourseId);
                    recruitmentDto.CourseName = course.CourseName;
                    recruitmentDtoList.Add(recruitmentDto);
                }
            }
            return recruitmentDtoList;
        }
        public override bool DeleteData(int recruitmentId)
        {
            var recruitment = context.Recruitments.Find(recruitmentId);
            if (recruitment != null && recruitment.IsDeleted == false)
            {
                recruitment.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
