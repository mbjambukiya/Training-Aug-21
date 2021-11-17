using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class Items
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ToyId { get; set; }
        public int OrderId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Toys Toy { get; set; }
    }
}
