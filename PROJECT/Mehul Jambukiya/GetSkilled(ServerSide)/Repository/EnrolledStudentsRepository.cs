using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class EnrolledStudentsRepository : GenericRepository<EnrolledStudent>, IEnrolledStudent
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;
        public EnrolledStudentsRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public EnrolledStudentDto GetEnrolledStudentById(int id)
        {
            var enStudent = GetDataById(id);
            if (enStudent.IsDeleted == false)
            {
                var enStudentDto = _mapper.Map<EnrolledStudentDto>(enStudent);
                var course = context.Courses.Find(enStudent.CourseId);
                var student = context.Students.Find(enStudent.StudentId);
                enStudentDto.CourseName = course.CourseName;
                enStudentDto.StudentName = student.FirstName + student.LastName;
                return enStudentDto;
            }
            else
            {
                return null;
            }
        }
        public IList<EnrolledStudentDto> GetEnrolledStudentsList()
        {
            var enStudentlist = GetAllData();
            var enStudentDtoList = new List<EnrolledStudentDto>();
            foreach (var enStudent in enStudentlist)
            {
                if (enStudent.IsDeleted == false)
                {
                    var enStudentDto = _mapper.Map<EnrolledStudentDto>(enStudent);
                    var course = context.Courses.Find(enStudent.CourseId);
                    var student = context.Students.Find(enStudent.StudentId);
                    enStudentDto.CourseName = course.CourseName;
                    enStudentDto.StudentName = student.FirstName + student.LastName;
                    enStudentDtoList.Add(enStudentDto);
                }
            }
            return enStudentDtoList;
        }
        public override bool DeleteData(int studentId)
        {
            var student = context.EnrolledStudents.Find(studentId);
            if (student != null && student.IsDeleted == false)
            {
                student.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
