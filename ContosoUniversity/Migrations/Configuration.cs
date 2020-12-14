namespace ContosoUniversity.Migrations
{
    using ContosoUniversity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ContosoUniversity.DAL.SchoolContext";
        }

        protected override void Seed(DAL.SchoolContext context)
        {

        

            var students = new List<Student> {
                              new Student
            {
                LastName = "Alexander",
                FirstMidName = "Carson",
                EnrollmentDate = DateTime.Parse("9-1-2005")

            },                new Student
            {
                LastName = "Alonso",
                FirstMidName = "Meredith",
                EnrollmentDate = DateTime.Parse("9-1-2002")

            },
                              new Student
            {
                LastName = "Barzdukas",
                FirstMidName = "Gylis",
                EnrollmentDate = DateTime.Parse("9-1-2002")

            },
                              new Student
            {
                LastName = "Li",
                FirstMidName = "Yan",
                EnrollmentDate = DateTime.Parse("9-1-2002")

            },
                              new Student
            {
                LastName = "Justice",
                FirstMidName = "Peggy",
                EnrollmentDate = DateTime.Parse("9-1-2001")

            },
                              new Student
            {
                LastName = "Norman",
                FirstMidName = "Laura",
                EnrollmentDate = DateTime.Parse("9-1-2003")

            },
                              new Student
            {
                LastName = "Olivetto",
                FirstMidName = "Nino",
                EnrollmentDate = DateTime.Parse("9-1-2005")

            }


            };

            students.ForEach(x => context.Students.AddOrUpdate(j => j.ID, x));




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
