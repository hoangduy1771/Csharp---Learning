using System;

namespace ConsoleAppOOP1
{
    class Students
    {
        private string studentID;
        private string name;
        private double gradeMath;
        private double gradeLiterature;
        private double gradePhysics;

        public Students
            (
            string cstudentID,
            string cname,
            double cgradeMath,
            double cgradeLiturature,
            double cgradePhysics
            )
        {
            StudentID = cstudentID;
            Name = cname;
            GradeMath = cgradeMath;
            GradePhysics = cgradePhysics;
            GradeLiterature = cgradeLiturature;
        }


        public string StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public double GradeMath
        {
            get { return gradeMath; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    gradeMath = value;
                }
                else
                {
                    Console.WriteLine("Grade Invalid");
                }
            }
        }

        public double GradeLiterature
        {
            get { return gradeLiterature; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    gradeLiterature = value;
                }
                else
                {
                    Console.WriteLine("Grade Invalid");
                }
            }
        }

        public double GradePhysics
        {
            get { return gradePhysics; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    gradePhysics = value;
                }
                else
                {
                    Console.WriteLine("Grade Invalid");
                }
            }
        }
    }
}
