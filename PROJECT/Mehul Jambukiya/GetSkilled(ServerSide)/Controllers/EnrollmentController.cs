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
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrolledStudent _enrolledStudent;
        public EnrollmentController(IEnrolledStudent enrolledStudent)
        {
            _enrolledStudent = enrolledStudent;
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public IActionResult GetEnrolledStudentList()
        {
            try
            {
                var result = _enrolledStudent.GetEnrolledStudentsList();

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

        [HttpGet("{studentId}")]
        public IActionResult GetEnrolledStudentById(int studentId)
        {
            try
            {
                var result = _enrolledStudent.GetEnrolledStudentById(studentId);
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

        [Authorize(Roles = UserRoles.Student)]

        [HttpPost]
        public IActionResult AddStudent(EnrolledStudent student)
        {
            try
            {
                student.LastModified = DateTime.Now;
                var result = _enrolledStudent.CreateData(student);
                if (result == true)
                {
                    _enrolledStudent.SaveData();
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

        [Authorize(Roles = UserRoles.Student)]
        [HttpPut()]
        public IActionResult UpdateStudent(EnrolledStudent student)
        {
            try
            {
                student.LastModified = DateTime.Now;
                if (student.IsDeleted == false)
                {
                    var result = _enrolledStudent.UpdateData(student);
                    if (result == true)
                    {
                        _enrolledStudent.SaveData();
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
        [HttpDelete("{studentId}")]
        public IActionResult DeleteStudent(int studentId)
        {
            try
            {
                var result = _enrolledStudent.DeleteData(studentId);
                if (result == true)
                {
                    _enrolledStudent.SaveData();
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
