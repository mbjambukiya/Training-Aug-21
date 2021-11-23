using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day17_Assignment.Entities
{
    public partial class DrugTiming
    {
        public DrugTiming()
        {
            PatientTakesMedicine = new HashSet<PatientTakesMedicine>();
        }

        public int TimingId { get; set; }
        public string Part { get; set; }

        public virtual ICollection<PatientTakesMedicine> PatientTakesMedicine { get; set; }
    }
}
