using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day17_Assignment.Entities
{
    public partial class MadicineForPatient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Medicine { get; set; }
        public short Dose { get; set; }
        public string Time { get; set; }
        public string PrescribedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
