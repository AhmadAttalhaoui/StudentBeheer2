using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentBeheer2.Models;

namespace StudentBeheer2.Data
{
    public class StudentBeheer2Context : DbContext
    {
        public StudentBeheer2Context (DbContextOptions<StudentBeheer2Context> options)
            : base(options)
        {
        }

        public DbSet<StudentBeheer2.Models.Student> Student { get; set; }

        public DbSet<StudentBeheer2.Models.Module> Module { get; set; }

        public DbSet<StudentBeheer2.Models.Inschrijvingen> Inschrijvingen { get; set; }
    }
}
