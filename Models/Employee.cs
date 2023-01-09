using System;
using System.Collections.Generic;

namespace Farward___Robin_Lab_3.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Grades = new HashSet<Grade>();
        }

        public int EmployeeId { get; set; }
        public string? EmployeeRole { get; set; }
        public string? IsTeacher { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
