using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Decimal CourseDuration { get; set; }
        public string Syllabus { get; set; }
        public int? FacultyId { get; set; }
        public string? FacultyName { get; set; }
        public Decimal Fees { get; set; }
        public bool Certificate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
