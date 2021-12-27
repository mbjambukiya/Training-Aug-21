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
    public class VerificationController : ControllerBase
    {
        private readonly IVerificationDetails _verification;
        public VerificationController(IVerificationDetails verification)
        {
            _verification = verification;
        }

        [HttpGet]
        public IActionResult GetVerificationList()
        {
            try
            {
                var result = _verification.GetVerificationList();
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

        [HttpGet("{verificationId}")]
        public IActionResult GetVerificationById(int verificationId)
        {
            try
            {
                var result = _verification.GetVerificationById(verificationId);

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
        public IActionResult AddVerification(VerificationDetail verification)
        {
            try
            {
                verification.LastModified = DateTime.Now;
                var result = _verification.CreateData(verification);
                if (result == true)
                {
                    _verification.SaveData();
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
        public IActionResult UpdateVerification(VerificationDetail verification)
        {
            try
            {
                verification.LastModified = DateTime.Now;
                if (verification.IsDeleted == false)
                {
                    var result = _verification.UpdateData(verification);
                    if (result == true)
                    {
                        _verification.SaveData();
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

        [HttpDelete("{verificationId}")]
        public IActionResult DeleteVerification(int verificationId)
        {
            try
            {
                var result = _verification.DeleteData(verificationId);
                if (result == true)
                {
                    _verification.SaveData();
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
