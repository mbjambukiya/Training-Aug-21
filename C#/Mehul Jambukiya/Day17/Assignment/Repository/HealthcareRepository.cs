using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Entities;

namespace Day17_Assignment.Repository
{
    public class HealthcareRepository : IHealthcareRepository
    {
        private readonly HealthCareDbContext _context;

        public HealthcareRepository(HealthCareDbContext context)
        {
            _context = context;
        }
        public IEnumerable GetMedicineInfoForPatient(int patientId)
        {
            var result = _context.MadicineForPatient.Where(p => p.PatientId == patientId);
            return result;
        }
        public IEnumerable GetPatientsInfoForAllDoctors()
        {
            var result = _context.PatientsPerDoctor.ToList();
            return result;
        }
        public IEnumerable GetPatientsInfoForDoctor(int doctorId)
        {
            var result = _context.PatientsPerDoctor.Where(p => p.DoctorId == doctorId);
            return result;
        }
    }
}
