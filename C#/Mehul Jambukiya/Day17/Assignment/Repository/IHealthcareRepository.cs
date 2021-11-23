using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Entities;

namespace Day17_Assignment.Repository
{
    public interface IHealthcareRepository
    {
        public IEnumerable GetPatientsInfoForDoctor(int doctorId);
        public IEnumerable GetMedicineInfoForPatient(int patientId);
        public IEnumerable GetPatientsInfoForAllDoctors();
    }
}
