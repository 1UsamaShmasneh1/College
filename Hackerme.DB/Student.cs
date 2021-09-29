using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class Student
    {
        public string? Id {  get; set; }
        public string? FirstName {  get; set; }
        public string? LastName {  get; set; }
        public DateTime DOB {  get; set; }
        public string? Phone {  get; set; }
        public string? Email {  get; set; }
        public string? City {  get; set; }
        public double AmountToPay {  get; set; }
        public double AmountPaid { get; set; } = 0;
        public string? Courses { get; set; } = "Click"; //for data greade
        public List<Course> CoursesList { get; set; } = new List<Course>();


    }
}
