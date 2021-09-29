using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class MyDB
    {
        public static List<Student> students = new List<Student>();
        public static List<Course> courses = new List<Course>();
        public static List<Student> Search (string searchBy, string strToSearch)
        {
            List<Student> newStudents = new List<Student>();
            foreach (Student student in students)
            {
                switch (searchBy)
                {
                    case "First Name":
                        if (strToSearch == student.FirstName)
                            students.Add(student);
                        break;
                    case "Last Name":
                        if (strToSearch == student.LastName)
                            students.Add(student);
                        break;
                    case "Full Name":
                        if (strToSearch == student.FirstName + " " + student.LastName)
                            students.Add(student);
                        break;
                    case "City":
                        if (strToSearch == student.City)
                            students.Add(student);
                        break;
                    case "Id":
                        if (strToSearch == student.Id)
                            students.Add(student);
                        break;
                }
            }
            return newStudents;
        }
        public static void RemoveStudent(string? id)
        {
            foreach(Student student in students)
            {
                if(student.Id == id)
                {
                    students.Remove(student);
                    break;
                }
            }
        }
    }
}
