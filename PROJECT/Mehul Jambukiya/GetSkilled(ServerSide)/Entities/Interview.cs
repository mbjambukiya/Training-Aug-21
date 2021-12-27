using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Interview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RecruitmentId { get; set; }
        public Recruitment Recruitment { get; set; }
        [Required]
        public int InterviewerId { get; set; }
        public Interviewer Interviewer { get; set; }
        [Required]
        public DateTime InterviewDate { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ApplicantFaculty> ApplicantFaculties { get; set; }
        public ICollection<InterviewResult> InterviewResults { get; set; }
    }
}
