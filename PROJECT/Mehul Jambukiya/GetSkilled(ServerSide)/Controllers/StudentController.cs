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
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public IActionResult GetStudentList()
        {
            try
            {
                var result = _student.GetStudentList();
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
        public IActionResult GetStudentById(int studentId)
        {
            try
            {
                var result = _student.GetStudentById(studentId);

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
        [HttpPut()]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                student.LastModified = DateTime.Now;
                if (student.IsDeleted == false)
                {
                    var result = _student.UpdateData(student);
                    if (result == true)
                    {
                        _student.SaveData();
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
                var result = _student.DeleteData(studentId);
                if (result == true)
                {
                    _student.SaveData();
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
