using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day17_Assignment.Entities
{
    public partial class Assistants
    {
        public Assistants()
        {
            PatientTakesMedicine = new HashSet<PatientTakesMedicine>();
            Treatment = new HashSet<Treatment>();
        }

        public int AssistantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? WorksUnder { get; set; }
        public decimal YearsOfExperience { get; set; }
        public bool? IsActive { get; set; }

        public virtual Doctors WorksUnderNavigation { get; set; }
        public virtual ICollection<PatientTakesMedicine> PatientTakesMedicine { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
