using System;
using System.Collections.Generic;

namespace Farward___Robin_Lab_3.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public int? Grade1 { get; set; }
        public DateTime? GradeSet { get; set; }
        public int? FkTeacherId { get; set; }
        public int? FkCourseId { get; set; }
        public int? FkStudentId { get; set; }

        public virtual Course? FkCourse { get; set; }
        public virtual Student? FkStudent { get; set; }
        public virtual Employee? FkTeacher { get; set; }
    }
}
