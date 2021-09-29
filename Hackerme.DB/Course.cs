using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class Course
    {
        public string? CourseId { get; set; }
        public string? CourseName { get; set; }
        public DateOnly StartDate { get; set; }
        public int NumOfMeetings { get; set; }
    }
}
