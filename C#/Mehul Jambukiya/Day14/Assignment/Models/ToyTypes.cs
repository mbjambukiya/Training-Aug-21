using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class ToyTypes
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ToyPlants ToyPlants { get; set; }
    }
}
