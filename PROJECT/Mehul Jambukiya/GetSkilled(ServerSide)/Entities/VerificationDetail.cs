using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class VerificationDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        [Required]
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public bool IsVerified { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
