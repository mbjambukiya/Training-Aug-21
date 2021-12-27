using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Decimal CourseDuration { get; set; }
        [Required]
        public string Syllabus { get; set; }
        public int? FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        [Required]
        public Decimal Fees { get; set; }
        [Required]
        public bool Certificate { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Recruitment> Recruitments { get; set; }
        public ICollection<ApplicantFaculty> ApplicantFaculties { get; set; }
        public ICollection<EnrolledStudent> EnrolledStudents { get; set; }
    }
}
