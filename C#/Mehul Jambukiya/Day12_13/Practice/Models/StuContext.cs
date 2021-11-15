using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day12_13.Models
{
    class StuContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\Sqlexpress;database=efcorepracticedb;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent-api one to one configuration
            //modelBuilder.Entity<Student>()
            //    .HasOne<Grade>(s=>s.GradeNavigation)
            //    .WithOne(g=>g.StudentNavigation)
            //    .HasForeignKey<Grade>(f=>f.StudentId);

            //fluent - api one to many configuration
            //modelBuilder.Entity<Grade>()
            //    .HasOne<Student>(s => s.StudentNavigation)
            //    .WithMany(g => g.GradeNavigation)
            //    .HasForeignKey(f => f.StudentId);
        }


    }
}
