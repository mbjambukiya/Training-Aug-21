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
    
    public class FacultyController : ControllerBase
    {
        private readonly IFaculty _faculty;
        public FacultyController(IFaculty faculty)
        {
            _faculty = faculty;
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public IActionResult GetFacultyList()
        {
            try
            {
                var result = _faculty.GetFacultyList();
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
        public IActionResult GetFacultyById(int facultyId)
        {
            try
            {
                var result = _faculty.GetFacultyById(facultyId);

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
        [HttpPut()]
        public IActionResult UpdateFaculty(Faculty faculty)
        {
            try
            {
                faculty.LastModified = DateTime.Now;
                if (faculty.IsDeleted == false)
                {
                    var result = _faculty.UpdateData(faculty);
                    if (result == true)
                    {
                        _faculty.SaveData();
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
                var result = _faculty.DeleteData(facultyId);
                if (result == true)
                {
                    _faculty.SaveData();
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
        [HttpPut("verification/{facultyId}")]
        public IActionResult MarkAsVerified(int facultyId)
        {
            try
            {
                var result = _faculty.MarkAsVerified(facultyId);
                if (result == true)
                {
                    _faculty.SaveData();
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
