using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _451_FinalChallenge.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}