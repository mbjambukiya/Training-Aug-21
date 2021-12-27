using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class ApplicantFacultyDto
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? InterviewId { get; set; }
        public bool IsSelected { get; set; }
        public DateTime LastModified { get; set; }
    }
}
