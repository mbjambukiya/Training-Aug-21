using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
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
    [Authorize(Roles = UserRoles.Admin)]

    public class CourseController : ControllerBase
    {
        private readonly ICourse _course;
        public CourseController(ICourse course)
        {
            _course = course;
        }

        [HttpGet]
        public IActionResult GetCourseList()
        {
            try
            {
                var result = _course.GetCourseList();
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

        [HttpGet("{courseId}")]
        public IActionResult GetCourseById(int courseId)
        {
            try
            {
                var result = _course.GetCourseById(courseId);

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

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            try
            {
                course.LastModified = DateTime.Now;
                var result = _course.CreateData(course);
                if (result == true)
                {
                    _course.SaveData();
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

        [HttpPut()]
        public IActionResult UpdateCourse(Course course)
        {
            try
            {
                course.LastModified = DateTime.Now;
                if (course.IsDeleted == false)
                {
                    var result = _course.UpdateData(course);
                    if (result == true)
                    {
                        _course.SaveData();
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

        [HttpDelete("{courseId}")]
        public IActionResult DeleteCourse(int courseId)
        {
            try
            {
                var result = _course.DeleteData(courseId);
                if (result == true)
                {
                    _course.SaveData();
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
