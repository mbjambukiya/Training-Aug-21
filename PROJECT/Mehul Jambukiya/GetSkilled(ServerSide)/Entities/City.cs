using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public int StateId { get; set; }
        public State State { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
        public ICollection<Interviewer> Interviewers { get; set; }
    }
}
