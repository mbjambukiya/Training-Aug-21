using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class ApplicantFaculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int? InterviewId { get; set; }
        public Interview Interview { get; set; }
        public bool IsSelected { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
