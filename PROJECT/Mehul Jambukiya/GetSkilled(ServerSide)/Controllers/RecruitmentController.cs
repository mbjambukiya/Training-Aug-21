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
    public class RecruitmentController : ControllerBase
    {
        private readonly IRecruitment _recruitment;
        public RecruitmentController(IRecruitment recruitment)
        {
            _recruitment = recruitment;
        }

        [HttpGet]
        public IActionResult GetRecruitmentList()
        {
            try
            {
                var result = _recruitment.GetRecruitmentList();
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

        [HttpGet("{recruitmentId}")]
        public IActionResult GetRecruitmentById(int recruitmentId)
        {
            try
            {
                var result = _recruitment.GetRecruitmentById(recruitmentId);

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
        public IActionResult AddRecruitment(Recruitment recruitment)
        {
            try
            {
                recruitment.LastModified = DateTime.Now;
                var result = _recruitment.CreateData(recruitment);
                if (result == true)
                {
                    _recruitment.SaveData();
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
        public IActionResult UpdateRecruitment(Recruitment recruitment)
        {
            try
            {
                recruitment.LastModified = DateTime.Now;
                if (recruitment.IsDeleted == false)
                {
                    var result = _recruitment.UpdateData(recruitment);
                    if (result == true)
                    {
                        _recruitment.SaveData();
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

        [HttpDelete("{recruitmentId}")]
        public IActionResult DeleteRecruitment(int recruitmentId)
        {
            try
            {
                var result = _recruitment.DeleteData(recruitmentId);
                if (result == true)
                {
                    _recruitment.SaveData();
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
