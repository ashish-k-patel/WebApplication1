using System;
using System.Collections.Generic;

namespace WebAppication1.Models
{
    public class Students
    {

        public double AverageGrade { get; set; }

        public List<StudentGradeDetail> StudentGradeDetail { get; set; }

        public List<StudentGrade> ListOfStudents { get; set; }

    }
}
