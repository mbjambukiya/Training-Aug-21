using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day11.Models
{
    public partial class Patients
    {
        public Patients()
        {
            PatientTakesMedicine = new HashSet<PatientTakesMedicine>();
            Treatment = new HashSet<Treatment>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int City { get; set; }
        public decimal? ContactNo { get; set; }
        public bool? IsActive { get; set; }

        public virtual City CityNavigation { get; set; }
        public virtual ICollection<PatientTakesMedicine> PatientTakesMedicine { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
