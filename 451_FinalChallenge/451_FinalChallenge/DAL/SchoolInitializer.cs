using _451_FinalChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _451_FinalChallenge.DAL
{
    public class SchoolInitializer :System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{StudentFName="Ryan",StudentLName="Bunker",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student{StudentFName="Brady",StudentLName="Lunt",EnrollmentDate=DateTime.Parse("2020-08-15")},
                new Student{StudentFName="Hayden",StudentLName="Newey",EnrollmentDate=DateTime.Parse("2019-01-06")},
                new Student{StudentFName="Cade",StudentLName="Zarbock",EnrollmentDate=DateTime.Parse("2018-09-07")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050, Title="Chemistry",Credits=3,},
                new Course{CourseID=1060, Title="Trigonometry",Credits=4,},
                new Course{CourseID=4025, Title="Anatomy",Credits=4,},
                new Course{CourseID=2040, Title="Literature",Credits=2,},
                new Course{CourseID=3045, Title="Economics",Credits=3,},
                new Course{CourseID=3020, Title="Microbiology",Credits=4,},
                new Course{CourseID=1010, Title="Algebra",Credits=2,},
                new Course{CourseID=1510, Title="English",Credits=3,}
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1, CourseID=1050, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=1060, Grade=Grade.B},
                new Enrollment{StudentID=1, CourseID=1510, Grade=Grade.C},
                new Enrollment{StudentID=2, CourseID=1050, Grade=Grade.F},
                new Enrollment{StudentID=2, CourseID=2040, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=3045, Grade=Grade.D},
                new Enrollment{StudentID=3, CourseID=3045, Grade=Grade.A},
                new Enrollment{StudentID=3, CourseID=3020},
                new Enrollment{StudentID=3, CourseID=1050, Grade=Grade.B},
                new Enrollment{StudentID=4, CourseID=1010, Grade=Grade.A},
                new Enrollment{StudentID=4, CourseID=4025, Grade=Grade.C}
            };
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}