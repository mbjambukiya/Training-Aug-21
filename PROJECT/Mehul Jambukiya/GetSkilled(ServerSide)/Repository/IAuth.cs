using System.Threading.Tasks;
using GetSkilled.Entities;
using GetSkilled.Models;
using Microsoft.AspNetCore.Identity;

namespace GetSkilled.Repository
{
    public interface IAuth
    {
        Task<IdentityResult> StudentRegistration(Student student);
        Task<IdentityResult> FacultyRegistration(Faculty faculty);
        Task<IdentityResult> InterviewerRegistration(Interviewer interviewer);
        Task<string> StudentLogin(SignInModel signInModel);
        Task<string> FacultyLogin(SignInModel signInModel);
        Task<string> InterviewerLogin(SignInModel signInModel);
        Task<IdentityResult> AdminRegistration(Admin admin);
        Task<string> AdminLogin(SignInModel signInModel);
    }
}