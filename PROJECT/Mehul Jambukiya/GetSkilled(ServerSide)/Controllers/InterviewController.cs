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
    [Authorize(Roles = UserRoles.Admin)]
    public class InterviewController : ControllerBase
    {
        private readonly IInterview _interview;
        public InterviewController(IInterview interview)
        {
            _interview = interview;
        }

        [HttpGet]
        public IActionResult GetInterviewList()
        {
            try
            {
                var result = _interview.GetInterviewList();
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

        [HttpGet("{interviewId}")]
        public IActionResult GetInterviewById(int interviewId)
        {
            try
            {
                var result = _interview.GetInterviewById(interviewId);

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
        public IActionResult AddInterview(Interview interview)
        {
            try
            {
                interview.LastModified = DateTime.Now;
                var result = _interview.CreateData(interview);
                if (result == true)
                {
                    _interview.SaveData();
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
        public IActionResult UpdateInterview(Interview interview)
        {
            try
            {
                interview.LastModified = DateTime.Now;
                if (interview.IsDeleted == false)
                {
                    var result = _interview.UpdateData(interview);
                    if (result == true)
                    {
                        _interview.SaveData();
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

        [HttpDelete("{interviewId}")]
        public IActionResult DeleteInterview(int interviewId)
        {
            try
            {
                var result = _interview.DeleteData(interviewId);
                if (result == true)
                {
                    _interview.SaveData();
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
