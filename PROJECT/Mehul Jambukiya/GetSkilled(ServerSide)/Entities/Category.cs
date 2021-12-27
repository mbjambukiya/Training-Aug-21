using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastModified { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
