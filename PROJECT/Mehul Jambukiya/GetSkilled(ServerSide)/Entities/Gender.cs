using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GenderName { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
        public ICollection<Interviewer> Interviewers { get; set; }
    }
}
