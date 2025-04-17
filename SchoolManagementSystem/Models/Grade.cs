using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int StudentCourseID { get; set; }
        public decimal GradeValue { get; set; }
        public DateTime GradeDate { get; set; }
        public string Notes { get; set; }

        public StudentCourse StudentCourse { get; set; }
    }
}
