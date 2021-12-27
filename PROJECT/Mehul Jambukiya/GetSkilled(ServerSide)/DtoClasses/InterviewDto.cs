using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class InterviewDto
    {
        public int Id { get; set; }
        public int RecruitmentId { get; set; }
        public int InterviewerId { get; set; }
        public string InterviewerName { get; set; }
        public DateTime InterviewDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
