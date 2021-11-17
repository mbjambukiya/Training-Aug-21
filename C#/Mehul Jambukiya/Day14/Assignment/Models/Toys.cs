using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class Toys
    {
        public Toys()
        {
            Items = new HashSet<Items>();
        }

        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public double ToyPrice { get; set; }
        public int ToyPlantId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ToyPlants ToyPlant { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
