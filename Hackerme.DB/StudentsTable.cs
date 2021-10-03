using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class StudentsTable
    {
        public static LogDelegate? Log { get; set; }
        public static List<Student> students { get; set; } = new List<Student>();
        public static void Add(Student student)
        {
            students.Add(student);
            Log("Added " + student.FirstName);
        }
        public static void Remove(Student student, LogDelegate logParam)
        {
            students.Remove(student);
            logParam("Remove " + student.FirstName);
        }
        public static List<Student> Filter(StudentsFilterDelegate filterDelegate)
        {
            List<Student> list = new List<Student>();
            foreach (var student in students)
            {
                if (filterDelegate(student))
                    list.Add(student);
            }
            return list;
        }

    }
}
