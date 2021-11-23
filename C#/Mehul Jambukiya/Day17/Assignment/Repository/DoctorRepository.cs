using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day17_Assignment.Repository
{
    public class DoctorRepository : GenericRepository<Doctors>,IDoctorRepository
    {
        public DoctorRepository(HealthCareDbContext context) : base(context)
        {
        }

        public override bool UpdateData(int doctorId, Doctors doctor)
        {
            if (_context.Doctors.Find(doctorId) != null)
            {
                _context.Entry(doctor).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool DeleteData(int doctorId)
        {
            var doctor = _context.Doctors.Find(doctorId);
            if (doctor != null)
            {
                doctor.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
