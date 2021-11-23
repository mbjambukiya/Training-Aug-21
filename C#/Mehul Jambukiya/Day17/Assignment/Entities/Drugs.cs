using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day17_Assignment.Entities
{
    public partial class Drugs
    {
        public Drugs()
        {
            PatientTakesMedicine = new HashSet<PatientTakesMedicine>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public short Mg { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PatientTakesMedicine> PatientTakesMedicine { get; set; }
    }
}
