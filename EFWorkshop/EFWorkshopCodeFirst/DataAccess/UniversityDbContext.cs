using Microsoft.EntityFrameworkCore;
using System;
using EfWorkshop.DataAccess.Models;

namespace EfWorkshop.DataAccess
{
    internal class UniversityDbContext : DbContext
    {
        private const string ConnectionString = "Server=localhost;Database=University;Trusted_Connection=True;TrustServerCertificate=True;";
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString)
                .LogTo(Console.WriteLine);
        }
    }
}
