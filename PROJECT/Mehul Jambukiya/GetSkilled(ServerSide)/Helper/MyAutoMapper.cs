using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Helper
{
    public class MyAutoMapper:Profile
    {
        public MyAutoMapper()
        {
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Document, DocumentDto>().ReverseMap();
            CreateMap<EnrolledStudent, EnrolledStudentDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
            CreateMap<ApplicantFaculty, ApplicantFacultyDto>().ReverseMap();
            CreateMap<Interviewer, InterviewerDto>().ReverseMap();
            CreateMap<Interview, InterviewDto>().ReverseMap();
            CreateMap<InterviewResult, InterviewResultDto>().ReverseMap();
            CreateMap<Recruitment, RecruitmentDto>().ReverseMap();
            CreateMap<VerificationDetail, VerificationDto>().ReverseMap();
        }
        //public static Mapper _mapper = new Mapper(new MapperConfiguration(
        //    cfg => cfg.CreateMap<TSourse, TSourse>().ReverseMap()
        //    ));

        //public static TDestination Map(TSourse source)
        //{
        //    return _mapper.Map<TDestination>(source);
        //}
    }
}
