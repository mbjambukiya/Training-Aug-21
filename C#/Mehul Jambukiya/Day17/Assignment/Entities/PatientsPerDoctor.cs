using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day17_Assignment.Entities
{
    public partial class PatientsPerDoctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Patients { get; set; }
        public int? NoOfPatients { get; set; }
    }
}
