using EfWorkshop.DataAccess.Models;
using EfWorkshop.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFWorkshopCodeFirst
{
    internal class AppRunner
    {
        public void Run()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityDbContext>();

            using (var context = new UniversityDbContext(optionsBuilder.Options))
            {
                context.Database.EnsureCreated();
                #region CreateOperations

                var seedStudents = GetDbSeedStudents();
                context.Students.AddRange(seedStudents);

                TrySaveChanges(context);
                #endregion
            }
        }

        private static List<Student> GetDbSeedStudents()
        {
            var engineeringFaculty = new Faculty()
            {
                Name = "Engineering",
                Description = "Faculty of Engineering"
            };

            var economicsFaculty = new Faculty()
            {
                Name = "Economics",
                Description = "Faculty of Economics"
            };

            var lawFaculty = new Faculty()
            {
                Name = "Law",
                Description = "Faculty of Law"
            };

            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Nick",
                    LastName = "Smith",
                    Email = "n.f@protonmail.edu",
                    PhoneNumber = "123-45-111-22-33",
                    AverageGrade = 8.5,
                    Faculty = engineeringFaculty,
                },

                new Student()
                {
                    FirstName = "Sally",
                    LastName = "Cage",
                    Email = "el@google.couk",
                    PhoneNumber = "222-11-333-23-23",
                    AverageGrade = 5.7,
                    Faculty = economicsFaculty,
                },

                new Student()
                {
                    FirstName = "George",
                    LastName = "Jones",
                    Email = "d.m@yahoo.net",
                    PhoneNumber = "111-22-123-22-11",
                    AverageGrade = 7.5,
                    Faculty = economicsFaculty,
                },

                new Student()
                {
                    FirstName = "Rick",
                    LastName = "Davis",
                    Email = "sit@yahoo.couk",
                    PhoneNumber = "333-33-222-11-00",
                    AverageGrade = 7.8,
                    Faculty = lawFaculty,
                },

                new Student()
                {
                    FirstName = "Erich",
                    LastName = "Miller",
                    Email = "u.p.c@aol.net",
                    PhoneNumber = "321-12-122-33-22",
                    AverageGrade = 4.9,
                    Faculty = lawFaculty,
                },
            };

        }
        private static void TrySaveChanges(DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
