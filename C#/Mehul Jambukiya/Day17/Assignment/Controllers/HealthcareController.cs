using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day17_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HealthcareController : ControllerBase
    {
        private readonly IHealthcareRepository _healthcareRepository;
        public HealthcareController(IHealthcareRepository healthcareRepository)
        {
            _healthcareRepository = healthcareRepository;
        }

        [HttpGet]
        public IActionResult GetPatientsInfoForAllDoctors()
        {
            try
            {
                if (_healthcareRepository.GetPatientsInfoForAllDoctors() != null)
                {
                    return Ok(_healthcareRepository.GetPatientsInfoForAllDoctors());
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("{doctorId}")]
        public IActionResult GetPatientsInfoForDoctor(int doctorId)
        {
            try
            {
                if (_healthcareRepository.GetPatientsInfoForDoctor(doctorId) != null)
                {
                    return Ok(_healthcareRepository.GetPatientsInfoForDoctor(doctorId));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("medicine/{patientId}")]
        public IActionResult GetPatientMedicineInfo(int patientId)
        {
            try
            {
                if (_healthcareRepository.GetMedicineInfoForPatient(patientId) != null)
                {
                    return Ok(_healthcareRepository.GetMedicineInfoForPatient(patientId));
                }
                else
                {
                    return NotFound();
                }
        }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
