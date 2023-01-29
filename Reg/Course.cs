namespace StudentRegistrationApp

{
    class Course
    {
        public int id;
        public string name;
        public Student[] Students = new Student[] { };

        public Course(string aName)
        {
            name = aName;
        }
          public void RegisterStudent(Student student)
        {
            student.id = Students.Length;
            Students.Append(student);
        }
    }
}

