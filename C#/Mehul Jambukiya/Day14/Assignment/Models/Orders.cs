using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Items = new HashSet<Items>();
        }

        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
