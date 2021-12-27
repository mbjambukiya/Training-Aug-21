using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GetSkilled.Entities
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long Mobile { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Qualification { get; set; }
        public Decimal Experience { get; set; }
        public string ExperienceDetails { get; set; }
        [Required]
        public int CityId { get; set; }
        public City City { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsVarified { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<ApplicantFaculty> ApplicantFaculties { get; set; }
        public ICollection<VerificationDetail> VerificationDetails { get; set; }
        public ICollection<InterviewResult> InterviewResults { get; set; }
    }
}
