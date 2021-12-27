using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StateName { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
