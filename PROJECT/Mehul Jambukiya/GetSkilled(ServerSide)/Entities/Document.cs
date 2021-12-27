using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DocumentName { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<VerificationDetail> VerificationDetails { get; set; }
    }
}
