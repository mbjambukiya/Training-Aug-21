using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GetSkilled.Entities;
using GetSkilled.Helper;
using GetSkilled.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace GetSkilled.Repository
{
    public class AuthRepository : IAuth
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        protected readonly GetSkilledDbContext _context;
        public AuthRepository(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            GetSkilledDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _roleManager = roleManager;
            _context = context;
        }
        public async Task<IdentityResult> StudentRegistration(Student student)
        {
            var user = new IdentityUser()
            {
                Email = student.Email,
                UserName = student.Email
            };

            var result = await _userManager.CreateAsync(user, student.Password);


            if (!await _roleManager.RoleExistsAsync(UserRoles.Student))
            {
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Student));
                await _userManager.AddToRoleAsync(user, UserRoles.Student);
            }
            else
            {
                await _userManager.AddToRoleAsync(user, UserRoles.Student);
            }
            student.Password = SecurePassword.EncodePassword(student.Password);
            _context.Add(student);
            _context.SaveChanges();
            return result;
        }

        public async Task<IdentityResult> FacultyRegistration(Faculty faculty)
        {
            var user = new IdentityUser()
            {
                Email = faculty.Email,
                UserName = faculty.Email
            };

            var result = await _userManager.CreateAsync(user, faculty.Password);


            if (!await _roleManager.RoleExistsAsync(UserRoles.Faculty))
            {
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Faculty));
                await _userManager.AddToRoleAsync(user, UserRoles.Faculty);
            }
            else
            {
                await _userManager.AddToRoleAsync(user, UserRoles.Faculty);
            }
            faculty.Password = SecurePassword.EncodePassword(faculty.Password);
            _context.Add(faculty);
            _context.SaveChanges();
            return result;
        }

        public async Task<IdentityResult> InterviewerRegistration(Interviewer interviewer)
        {
            var user = new IdentityUser()
            {
                Email = interviewer.Email,
                UserName = interviewer.Email
            };

            var result = await _userManager.CreateAsync(user, interviewer.Password);


            if (!await _roleManager.RoleExistsAsync(UserRoles.Interviewer))
            {
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Interviewer));
                await _userManager.AddToRoleAsync(user, UserRoles.Interviewer);
            }
            else
            {
                await _userManager.AddToRoleAsync(user, UserRoles.Interviewer);
            }
            interviewer.Password = SecurePassword.EncodePassword(interviewer.Password);
            _context.Add(interviewer);
            _context.SaveChanges();
            return result;
        }
        public async Task<string> StudentLogin(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"student"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<string> FacultyLogin(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"faculty"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<string> InterviewerLogin(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"interviewer"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public async Task<IdentityResult> AdminRegistration(Admin admin)
        {
            var filePath = "./AdminCredentials/AdminCredentials.json";
            JObject adminCredentials = JObject.Parse(System.IO.File.ReadAllText(filePath));
            Boolean isDefAdmin = false;
            foreach (var i in adminCredentials["admin"])
            {
                if (admin.Email == i["Email"].ToString() && admin.Password == i["Password"].ToString())
                {
                    isDefAdmin = true;
                    break;
                }
            }
            if (isDefAdmin == true)
            {

                var user = new IdentityUser()
                {
                    Email = admin.Email,
                    UserName = admin.Email
                };

                var result = await _userManager.CreateAsync(user, admin.Password);

                if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                    await _userManager.AddToRoleAsync(user, UserRoles.Admin);
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, UserRoles.Admin);
                }

                return result;
            }
            return IdentityResult.Failed();
        }

        public async Task<string> AdminLogin(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,signInModel.Email),
                new Claim(ClaimTypes.Role,"admin"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
