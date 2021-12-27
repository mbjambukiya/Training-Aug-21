using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Student
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
        [Required]
        public int CityId { get; set; }
        public City City { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<EnrolledStudent> EnrolledStudents { get; set; }
    }
}
