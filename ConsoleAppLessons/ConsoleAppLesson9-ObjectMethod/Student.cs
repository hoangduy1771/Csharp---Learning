using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson9_ObjectMethod
{
    class Student
    {
        public string name;
        public string field;
        public double gpa;

        public Student(string stuName, string stuField, double stuGpa)
        {
            name = stuName;
            field = stuField;
            gpa = stuGpa;
        }

        // Object method
        public bool HasHonors()
        {
            if (gpa > 3.5)
            {
                return true;
            }
            return false; 
        }
    }
}
