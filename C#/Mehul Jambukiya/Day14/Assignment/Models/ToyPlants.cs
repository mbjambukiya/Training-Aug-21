using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class ToyPlants
    {
        public ToyPlants()
        {
            Toys = new HashSet<Toys>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantCity { get; set; }
        public int ToyTypeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ToyTypes ToyType { get; set; }
        public virtual ICollection<Toys> Toys { get; set; }
    }
}
