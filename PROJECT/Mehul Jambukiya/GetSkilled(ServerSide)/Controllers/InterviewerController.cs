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
    public class InterviewerController : ControllerBase
    {
        private readonly IInterviewer _interviewer;
        public InterviewerController(IInterviewer interviewer)
        {
            _interviewer = interviewer;
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public IActionResult GetInterviewerList()
        {
            try
            {
                var result = _interviewer.GetInterviewerList();
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
        [HttpGet("{interviewerId}")]
        public IActionResult GetInterviewerById(int interviewerId)
        {
            try
            {
                var result = _interviewer.GetInterviewerById(interviewerId);

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

        [Authorize(Roles = UserRoles.Interviewer)]
        [HttpPut()]
        public IActionResult UpdateInterviewer(Interviewer interviewer)
        {
            try
            {
                interviewer.LastModified = DateTime.Now;
                if (interviewer.IsDeleted == false)
                {
                    var result = _interviewer.UpdateData(interviewer);
                    if (result == true)
                    {
                        _interviewer.SaveData();
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
        [HttpDelete("{interviewerId}")]
        public IActionResult DeleteInterviewer(int interviewerId)
        {
            try
            {
                var result = _interviewer.DeleteData(interviewerId);
                if (result == true)
                {
                    _interviewer.SaveData();
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
