using System;
using System.Collections.Generic;

namespace University.Models
{
    public class Course
    {
        public string Course_Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Semester { get; set; } = string.Empty;
        public string Lecturer { get; set; } = string.Empty;
        public bool IsSelected { get; set; } = false;
        public virtual ICollection<Student>? Students { get; set; } = null;
    }
}
