using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Proj
{//working on a good thing
    internal class Student
    {

        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string studentID, string studentName, int studentAge, string studentCourse)
        {
            StudentID = studentID;
            Name = studentName;
            Age = studentAge;
            Course = studentCourse;
        }

        public override string ToString()
        {
            return StudentID + ", " + Name + ", " + Age + ", " + Course;


        }
    }
}
