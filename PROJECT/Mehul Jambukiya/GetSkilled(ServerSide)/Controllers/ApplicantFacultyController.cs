using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;
using GetSkilled.Models;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetSkilled.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ApplicantFacultyController : ControllerBase
    {
        private readonly IApplicantFaculty _applicantFaculty;
        public ApplicantFacultyController(IApplicantFaculty applicantFaculty)
        {
            _applicantFaculty = applicantFaculty;
        }

        [Authorize(Roles = UserRoles.Admin)]

        [HttpGet]
        public IActionResult GetApplicantFacultyList()
        {
            try
            {
                var result = _applicantFaculty.GetApplicantFacultyList();
                if (result.Any())
                {
                    return Ok(result);
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
        [Authorize(Roles = UserRoles.Admin)]

        [HttpGet("{facultyId}")]
        public IActionResult GetApplicantFacultyById(int facultyId)
        {
            try
            {
                var result = _applicantFaculty.GetApplicantFacultyById(facultyId);

                if (result != null)
                {
                    return Ok(result);
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
        [Authorize(Roles = UserRoles.Faculty)]

        [HttpPost]
        public IActionResult AddFaculty(ApplicantFaculty faculty)
        {
            try
            {
                faculty.LastModified = DateTime.Now;
                var result = _applicantFaculty.CreateData(faculty);
                if (result == true)
                {
                    _applicantFaculty.SaveData();
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Authorize(Roles = UserRoles.Faculty)]

        [HttpPut()]
        public IActionResult UpdateFaculty(ApplicantFaculty faculty)
        {
            try
            {
                faculty.LastModified = DateTime.Now;
                if (faculty.IsDeleted == false)
                {
                    var result = _applicantFaculty.UpdateData(faculty);
                    if (result == true)
                    {
                        _applicantFaculty.SaveData();
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete("{facultyId}")]
        public IActionResult DeleteFaculty(int facultyId)
        {
            try
            {
                var result = _applicantFaculty.DeleteData(facultyId);
                if (result == true)
                {
                    _applicantFaculty.SaveData();
                    return Ok(result);
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
