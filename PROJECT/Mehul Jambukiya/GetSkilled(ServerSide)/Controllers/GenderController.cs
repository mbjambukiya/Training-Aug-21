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
    public class GenderController : ControllerBase
    {
        private readonly IGender _gender;
        public GenderController(IGender gender)
        {
            _gender = gender;
        }

        [HttpGet]
        public IActionResult GetGenderList()
        {
            try
            {
                var result = _gender.GetAllData();
                var genderList = new List<Gender>();
                foreach (var i in result)
                {
                    if (i.IsDeleted == false)
                    {
                        genderList.Add(i);
                    }
                }
                if (genderList.Any())
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

        [HttpGet("{genderId}")]
        public IActionResult GetGenderById(int genderId)
        {
            try
            {
                var result = _gender.GetDataById(genderId);

                if (result != null && result.IsDeleted == false)
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
        public IActionResult AddGender(Gender gender)
        {
            try
            {
                gender.LastModified = DateTime.Now;
                var result = _gender.CreateData(gender);
                if (result == true)
                {
                    _gender.SaveData();
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
    }
}
