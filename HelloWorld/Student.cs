namespace StudentRegistrationApp

{
    class Student
    {
        public int id;
        public string name;
        public string department;
        public double gpa;

        public Student(string aName, string aDepartment, double aGpa)
        { 
            name = aName;
            department = aDepartment;
            gpa = aGpa; 
        }
    }
}

