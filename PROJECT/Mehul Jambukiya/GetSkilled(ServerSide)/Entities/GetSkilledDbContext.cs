using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GetSkilled.Entities
{
    public class GetSkilledDbContext : IdentityDbContext
    {
        public GetSkilledDbContext()
        {

        }
        public GetSkilledDbContext(DbContextOptions<GetSkilledDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Recruitment> Recruitments { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewResult> InterviewResults { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<EnrolledStudent> EnrolledStudents { get; set; }
        public DbSet<ApplicantFaculty> ApplicantFaculties { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<VerificationDetail> VerificationDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicantFaculty>()
                .HasOne(f => f.Faculty)
                .WithMany(s => s.ApplicantFaculties)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ApplicantFaculty>()
                .HasOne(f => f.Interview)
                .WithMany(s => s.ApplicantFaculties)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InterviewResult>()
                .HasOne(f => f.Interview)
                .WithMany(s => s.InterviewResults)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InterviewResult>()
                .HasOne(f => f.Faculty)
                .WithMany(s => s.InterviewResults)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Course>()
                .Property(p => p.Certificate)
                .HasDefaultValue(true);

            modelBuilder.Entity<Faculty>()
                .Property(p => p.IsVarified)
                .HasDefaultValue(false);

            modelBuilder.Entity<ApplicantFaculty>()
                .Property(p => p.IsSelected)
                .HasDefaultValue(false);

            modelBuilder.Entity<ApplicantFaculty>()
                .Property(p => p.InterviewId)
                .HasDefaultValue(null);

            modelBuilder.Entity<VerificationDetail>()
                .Property(p => p.IsVerified)
                .HasDefaultValue(false);

            modelBuilder.Entity<ApplicantFaculty>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Category>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<City>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Course>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Document>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<EnrolledStudent>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Faculty>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Gender>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Interview>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Interviewer>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<InterviewResult>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Recruitment>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<State>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Student>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<VerificationDetail>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<ApplicantFaculty>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<City>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Course>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Document>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EnrolledStudent>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Faculty>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Gender>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Interview>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Interviewer>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<InterviewResult>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Recruitment>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<State>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Student>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<VerificationDetail>()
                .Property(p => p.LastModified)
                .HasDefaultValueSql("getdate()");
        }

    }
}
