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
    public class InterviewResultController : ControllerBase
    {
        private readonly IInterviewResult _interviewResult;
        public InterviewResultController(IInterviewResult interviewResult)
        {
            _interviewResult = interviewResult;
        }

        [HttpGet]
        public IActionResult GetResultList()
        {
            try
            {
                var result = _interviewResult.GetResultList();
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

        [HttpGet("{resultId}")]
        public IActionResult GetResultById(int resultId)
        {
            try
            {
                var result = _interviewResult.GetResultById(resultId);

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
        public IActionResult AddResult(InterviewResult interviewResult)
        {
            try
            {
                interviewResult.LastModified = DateTime.Now;
                var result = _interviewResult.CreateData(interviewResult);
                if (result == true)
                {
                    _interviewResult.SaveData();
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
        public IActionResult UpdateResult(InterviewResult interviewResult)
        {
            try
            {
                interviewResult.LastModified = DateTime.Now;
                if (interviewResult.IsDeleted == false)
                {
                    var result = _interviewResult.UpdateData(interviewResult);
                    if (result == true)
                    {
                        _interviewResult.SaveData();
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

        [HttpDelete("{resultId}")]
        public IActionResult DeleteResult(int resultId)
        {
            try
            {
                var result = _interviewResult.DeleteData(resultId);
                if (result == true)
                {
                    _interviewResult.SaveData();
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
