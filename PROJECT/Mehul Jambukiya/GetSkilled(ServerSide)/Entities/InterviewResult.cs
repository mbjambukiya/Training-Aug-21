using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class InterviewResult
    {
        [Key]
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
