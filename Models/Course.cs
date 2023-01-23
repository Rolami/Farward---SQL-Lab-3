using System;
using System.Collections.Generic;

namespace Farward___Robin_Lab_3.Models
{
    public partial class Course
    {
        public Course()
        {
            Grades = new HashSet<Grade>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;

        public string IsActive { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
