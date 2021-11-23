using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Entities;
using Day17_Assignment.Models;
using Day17_Assignment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Day17_Assignment.Controllers
{
    [Route("api/[controller]")]

    [Authorize(Roles = UserRoles.Admin)]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAllDoctorsData()
        {
            try
            {
                if (_doctorRepository.GetAllData().Any())
                {
                    return Ok(_doctorRepository.GetAllData());
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
        public IActionResult GetDoctorDataById(int doctorId)
        {
            try
            {
                if (_doctorRepository.GetDataById(doctorId)!=null)
                {
                    return Ok(_doctorRepository.GetDataById(doctorId));
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

        [HttpPost]
        public IActionResult AddNewDoctorData(Doctors doctor)
        {
            try
            {
                var result = _doctorRepository.CreateData(doctor);
                if (result == true)
                {
                    return Ok();
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

        [HttpPut("{doctorId}")]
        public IActionResult UpdateDoctorData(int doctorId,Doctors doctor)
        {
            try
            {
                var result = _doctorRepository.UpdateData(doctorId,doctor);
                if (result == true)
                {
                    return Ok();
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

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctorData(int doctorId)
        {
            try
            {
                var result = _doctorRepository.DeleteData(doctorId);
                if (result == true)
                {
                    return Ok();
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
