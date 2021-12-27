using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class VerificationDto
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public bool IsVerified { get; set; }
        public DateTime LastModified { get; set; }
    }
}
