using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day14_Assignmnt.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Orders = new HashSet<Orders>();
        }

        public int AddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
