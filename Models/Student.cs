using System;
using System.Collections.Generic;

namespace Farward___Robin_Lab_3.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
        }

        public int StudentId { get; set; }
        public string Ssn { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
