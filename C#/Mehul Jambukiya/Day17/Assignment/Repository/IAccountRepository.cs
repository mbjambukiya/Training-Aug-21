using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Models;
using Microsoft.AspNetCore.Identity;

namespace Day17_Assignment.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
