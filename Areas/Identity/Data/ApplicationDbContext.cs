using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace StudentBeheer2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<StudentBeheer2.Models.Student> Student { get; set; }

        public DbSet<StudentBeheer2.Models.Module> Module { get; set; }

        public DbSet<StudentBeheer2.Models.Inschrijvingen> Inschrijvingen { get; set; }
        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating (builder);
        }
    }
}