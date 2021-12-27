using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetSkilled.Entities;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace GetSkilled
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<GetSkilledDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ConnStr"))
            );

            services.AddAutoMapper(typeof(Startup));

            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<GetSkilledDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IAuth, AuthRepository>();
            services.AddTransient<IState, StateRepository>();
            services.AddTransient<ICity, CityRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddTransient<ICourse, CourseRepository>();
            services.AddTransient<IInterview, InterviewRepository>();
            services.AddTransient<IInterviewer, InterviewerRepository>();
            services.AddTransient<IInterviewResult, InterviewResultRepository>();
            services.AddTransient<IStudent, StudentRepository>();
            services.AddTransient<IFaculty, FacultyRepository>();
            services.AddTransient<IDocument, DocumentRepository>();
            services.AddTransient<IVerificationDetails, VerificationDetailsRepository>();
            services.AddTransient<IRecruitment, RecruitmentRepository>();
            services.AddTransient<IGender, GenderRepository>();
            services.AddTransient<IApplicantFaculty, ApplicantFacultyRepository>();
            services.AddTransient<IEnrolledStudent, EnrolledStudentsRepository>();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(option =>
            {
                option.SaveToken = true;
                option.RequireHttpsMetadata = false;
                option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
