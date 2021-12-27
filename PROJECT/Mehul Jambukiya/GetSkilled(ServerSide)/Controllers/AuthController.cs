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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetSkilled.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth _authRepository;
        public AuthController(IAuth authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register/student")]
        public async Task<IActionResult> StudentRegistration([FromBody] Student student)
        {
            var result = await _authRepository.StudentRegistration(student);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("register/faculty")]
        public async Task<IActionResult> FacultyRegistration([FromBody] Faculty faculty)
        {
            var result = await _authRepository.FacultyRegistration(faculty);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("register/interviewer")]
        public async Task<IActionResult> InterviewerRegistration([FromBody] Interviewer interviewer)
        {
            var result = await _authRepository.InterviewerRegistration(interviewer);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("login/student")]
        public async Task<IActionResult> StudentLogin([FromBody] SignInModel signInModel)
        {
            var result = await _authRepository.StudentLogin(signInModel);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Something went wrong!!Please try again!!");
        }
        [HttpPost("login/faculty")]
        public async Task<IActionResult> FacultyLogin([FromBody] SignInModel signInModel)
        {
            var result = await _authRepository.FacultyLogin(signInModel);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Something went wrong!!Please try again!!");
        }
        [HttpPost("login/interviewer")]
        public async Task<IActionResult> InterviewerLogin([FromBody] SignInModel signInModel)
        {
            var result = await _authRepository.InterviewerLogin(signInModel);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Something went wrong!!Please try again!!");
        }

        [HttpPost("register/admin")]
        public async Task<IActionResult> AdminRegistration([FromBody] Admin admin)
        {
            var result = await _authRepository.AdminRegistration(admin);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized("Your credentials doesn't match with admin credentials!!");
        }

        [HttpPost("login/admin")]
        public async Task<IActionResult> AdminLogin([FromBody] SignInModel signInModel)
        {
            var result = await _authRepository.AdminLogin(signInModel);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Something went wrong!!Please try again!!");
        }
    }
}
