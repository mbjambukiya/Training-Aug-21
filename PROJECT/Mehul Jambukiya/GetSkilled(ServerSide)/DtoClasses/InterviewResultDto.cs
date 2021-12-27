using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class InterviewResultDto
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public string FacultyName { get; set; }
        public DateTime LastModified { get; set; }
    }
}
