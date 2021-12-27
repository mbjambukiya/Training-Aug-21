using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudent
    {
        private readonly GetSkilledDbContext context;
        private readonly IMapper _mapper;

        public StudentRepository(GetSkilledDbContext context, IMapper mapper) : base(context)
        {
            this.context = context;
            _mapper = mapper;
        }

        public StudentDto GetStudentById(int id)
        {
            var student = GetDataById(id);
            if (student.IsDeleted == false)
            {
                var studentDto = _mapper.Map<StudentDto>(student);
                var gender = context.Gender.Find(student.GenderId);
                var city = context.Cities.Find(student.CityId);
                studentDto.GenderName = gender.GenderName;
                studentDto.CityName = city.CityName;
                return studentDto;
            }
            else
            {
                return null;
            }
        }
        public IList<StudentDto> GetStudentList()
        {
            var studentlist = GetAllData();
            var studentDtoList = new List<StudentDto>();
            foreach (var student in studentlist)
            {
                if (student.IsDeleted == false)
                {
                    var studentDto = _mapper.Map<StudentDto>(student);
                    var gender = context.Gender.Find(student.GenderId);
                    var city = context.Cities.Find(student.CityId);
                    studentDto.GenderName = gender.GenderName;
                    studentDto.CityName = city.CityName;
                    studentDtoList.Add(studentDto);
                }
            }
            return studentDtoList;
        }
        public override bool DeleteData(int studentId)
        {
            var student = context.Students.Find(studentId);
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
