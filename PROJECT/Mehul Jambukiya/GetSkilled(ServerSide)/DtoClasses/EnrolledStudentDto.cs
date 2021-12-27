using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class EnrolledStudentDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime LastModified { get; set; }

    }
}
